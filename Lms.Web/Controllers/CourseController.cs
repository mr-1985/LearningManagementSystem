﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels.Order;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using SharpCompress.Archives;

namespace Lms.Web.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;
        private IUserService _userService;
        private IOrderService _orderService;

        public CourseController(ICourseService courseService, IUserService userService, IOrderService orderService)
        {
            _courseService = courseService;
            _userService = userService;
            _orderService = orderService;
        }

        public IActionResult Index(int pageId = 1, string filter = ""
            , string getType = "all", string orderByType = "date",
            int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null)
        {
            ViewBag.selectedGroups = selectedGroups;
            ViewBag.Groups = _courseService.GetAllGroups();
            ViewBag.pageId = pageId;

            var course = _courseService.GetCourseForArchive(pageId, filter, getType, orderByType, startPrice, endPrice,
                selectedGroups, 12);
            ViewBag.currentPage = course.CurrentPage;
            ViewBag.PageCount = course.PageCount;
            ViewBag.TotalItems = course.CourseCounts;

            return View(course.ShowCourseList);
        }

        [Authorize(Policy = "ThisRolesOnly")]
        [Route("ShowCourse/{id}")]
        public IActionResult ShowCourse(int id, int episode = 0)
        {
            var course = _courseService.GetCourseForShow(id);
            if (course == null)
            {
                return NotFound();
            }

            if (episode != 0 && User.Identity.IsAuthenticated)
            {
                if (course.CourseEpisodes.All(e => e.EpisodeId != episode))
                {
                    return NotFound();
                }

                if (!course.CourseEpisodes.First(e => e.EpisodeId == episode).IsFree)
                {
                    if (!_orderService.IsUserInCourse(User.Identity.Name, id))
                    {
                        return NotFound();
                    }
                }

                var ep = course.CourseEpisodes.First(e => e.EpisodeId == episode);
                ViewBag.Episode = ep;
                string filePath = "";
                string checkFilePath = "";
                if (ep.IsFree)
                {
                    filePath = "/courseOnline/" + ep.EpisodeFileName.Replace(".rar", ".mp4");
                    checkFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/courseOnline",
                        ep.EpisodeFileName.Replace(".rar", ".mp4"));
                }
                else
                {
                    filePath = "/CourseFilesOnline/" + ep.EpisodeFileName.Replace(".rar", ".mp4");
                    checkFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CourseFilesOnline",
                        ep.EpisodeFileName.Replace(".rar", ".mp4"));
                }


                if (!System.IO.File.Exists(checkFilePath))
                {
                    string targetPath = Directory.GetCurrentDirectory();
                    if (ep.IsFree)
                    {
                        targetPath = System.IO.Path.Combine(targetPath, "wwwroot/courseOnline");
                    }
                    else
                    {
                        targetPath = System.IO.Path.Combine(targetPath, "wwwroot/CourseFilesOnline");
                    }

                    string rarPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/courseFiles",
                        ep.EpisodeFileName);
                    var archive = ArchiveFactory.Open(rarPath);

                    var Entries = archive.Entries.OrderBy(x => x.Key.Length);
                    foreach (var en in Entries)
                    {
                        if (Path.GetExtension(en.Key) == ".mp4")
                        {
                            en.WriteTo(System.IO.File.Create(Path.Combine(targetPath, ep.EpisodeFileName.Replace(".rar", ".mp4"))));
                        }
                    }
                }

                ViewBag.filePath = filePath;
            }

            return View(course);
        }


        [HttpPost]
        public IActionResult CreateComment(CourseComment comment)
        {
            comment.IsDelete = false;
            comment.CreateDate = DateTime.Now;
            comment.UserId = _userService.GetUserIdByUserName(User.Identity.Name);
            _courseService.AddComment(comment);

            return View("ShowComment", _courseService.GetCourseComment(comment.CourseId));
        }

        public IActionResult ShowComment(int id, int pageId = 1)
        {
            return View(_courseService.GetCourseComment(id, pageId));
        }

        [Authorize]
        public ActionResult BuyCourse(int id)
        {
            int orderId = _orderService.AddOrder(User.Identity.Name, id);
            return Redirect("/Admin/MyOrders/ShowOrder/" + orderId);
        }

        [Route("DownloadFile/{episodeId}")]
        public IActionResult DownloadFile(int episodeId)
        {
            var episode = _courseService.GetEpisodeById(episodeId);
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/courseFiles",
                episode.EpisodeFileName);
            string fileName = episode.EpisodeFileName;
            if (episode.IsFree)
            {
                byte[] file = System.IO.File.ReadAllBytes(filepath);
                return File(file, "application/force-download", fileName);
            }

            if (User.Identity.IsAuthenticated)
            {
                if (_orderService.IsUserInCourse(User.Identity.Name, episode.CourseId))
                {
                    byte[] file = System.IO.File.ReadAllBytes(filepath);
                    return File(file, "application/force-download", fileName);
                }
            }

            return Forbid();
        }

        public IActionResult CourseVote(int Id)
        {
            if (!_courseService.IsFree(Id))
            {
                if (!_orderService.IsUserInCourse(User.Identity.Name, Id))
                {
                    ViewBag.NotAccess = true;
                }
            }
            return PartialView(_courseService.GetCourseVotes(Id));
        }

        [Authorize]
        public IActionResult AddVote(int id, bool vote)
        {
            _courseService.AddsVote(_userService.GetUserIdByUserName(User.Identity.Name), id, vote);

            return PartialView("CourseVote", _courseService.GetCourseVotes(id));
        }

        public IActionResult FinalyOrder(int id)
        {
            if (_orderService.FinalyOrder(User.Identity.Name, id))
            {
                return Redirect("/Admin/MyOrders/ShowOrder/" + id + "?finaly=true");
            }

            return BadRequest();
        }

        public IActionResult UseDiscount(int orderId, string code)
        {
            DiscountUseType type = _orderService.UseDiscount(orderId, code);
            return Redirect("/Admin/MyOrders/ShowOrder/" + orderId + "?type=" + type.ToString());
        }
    }
}
