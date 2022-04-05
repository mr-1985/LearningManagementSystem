using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Entities.News;

namespace Lms.Web.Controllers
{
    public class NewsController : Controller
    {
        private INewsService _newsService;
        private IUserService _userService;

        public NewsController(INewsService newsService, IUserService userService)
        {
            _newsService = newsService;
            _userService = userService;
        }

        [Route("Archive")]
        public IActionResult Archive(int pageId = 1, string filter = "", List<int> selectedGroups = null, int take = 12)
        {
            ViewBag.selectedGroups = selectedGroups;
            ViewBag.Groups = _newsService.GetAllGroup();
            ViewBag.pageId = pageId;

            var news = _newsService.GetNewsPage(pageId, filter, selectedGroups, 12);
            ViewBag.currentPage=news.CurrentPage;
            ViewBag.PageCount = news.PageCount;
            ViewBag.list = news.NewsList;

            return View(news.NewsList);
        }

        [Route("ShowNews/{id}")]
        public IActionResult ShowNews(int id)
        {
            var news = _newsService.GetPageForShow(id);
            if (news == null)
            {
                return NotFound();
            }

            news.Visit += 1;
            _newsService.UpdateNews(news);

            return View(news);
        }


        [HttpPost]
        public IActionResult CreateComment(PageComment comment)
        {
            comment.IsDelete = false;
            comment.CreateDate = DateTime.Now;
            comment.UserId = _userService.GetUserIdByUserName(User.Identity.Name);
            _newsService.AddComment(comment);

            return View("ShowComment", _newsService.GetNewsComment(comment.PageID));
        }

        public IActionResult ShowComment(int id, int pageId = 1)
        {
            return View(_newsService.GetNewsComment(id,pageId));
        }
    }
}
