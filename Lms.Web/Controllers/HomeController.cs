using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lms.Web.Controllers
{
    public class HomeController : Controller
    {
        private IUserService _userService;
        private IPermissionService _permissionService;
        private ICommonService _commonService;
        private IOrderService _orderService;
        private ICourseService _courseService;
        private IExamService _examService;
        private INewsService _newsService;

        public HomeController(IUserService userService, IPermissionService permissionService, ICommonService commonService, IOrderService orderService, ICourseService courseService, IExamService examService, INewsService newsService)
        {
            _userService = userService;
            _permissionService = permissionService;
            _commonService = commonService;
            _orderService = orderService;
            _courseService = courseService;
            _examService = examService;
            _newsService = newsService;
        }

        public IActionResult Index()
        {
            IEnumerable<ShowCourseListItemViewModel> popular = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44399/api/values/");
                //HTTP GET
                var responseTask = client.GetAsync("https://localhost:44399/api/values/");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<ShowCourseListItemViewModel>>();
                    readTask.Wait();

                    popular = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    popular = Enumerable.Empty<ShowCourseListItemViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            ViewBag.PopularCourse = popular;

            IEnumerable<ShowCourseListItemViewModel> courses = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44399/api/CourseApi/");
                //HTTP GET
                var responseTask = client.GetAsync("https://localhost:44399/api/CourseApi/");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<ShowCourseListItemViewModel>>();
                    readTask.Wait();

                    courses = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    courses = Enumerable.Empty<ShowCourseListItemViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            IEnumerable<NewsForArchiveViewModel> news = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44399/api/NewsApi/");
                //HTTP GET
                var responseTask = client.GetAsync("https://localhost:44399/api/NewsApi/");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<NewsForArchiveViewModel>>();
                    readTask.Wait();

                    news = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    news = Enumerable.Empty<NewsForArchiveViewModel>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            ViewBag.News = news;

            return View(courses);
        }

        //[Route("Login")]
        //public IActionResult login(bool EditProfile = false, bool permission = true)
        //{
        //    ViewBag.EditProfile = EditProfile;
        //    ViewBag.Permission = permission;
        //    return View();
        //}

        //[HttpPost]
        //[Route("Login")]
        //public IActionResult login(LoginViewModel login)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(login);
        //    }

        //    var user = _userService.Login(login);

        //    if (user != null)
        //    {
        //        if (user.IsActive && user.IsDelete == false)
        //        {
        //            var claim = new List<Claim>()
        //            {
        //                new Claim(ClaimTypes.Name,user.UserName),
        //                new Claim(ClaimTypes.NameIdentifier,user.FirstName+" "+user.LastName),
        //                new Claim(ClaimTypes.Email,user.Email),
        //                new Claim(ClaimTypes.MobilePhone,user.Mobile),
        //                new Claim(ClaimTypes.Actor,user.UserAvatar)
        //                                           };
        //            var identity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
        //            var principal = new ClaimsPrincipal(identity);
        //            var properties = new AuthenticationProperties()
        //            {
        //                IsPersistent = true // login.RememberMe
        //            };

        //            HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(principal), properties);
        //            HttpContext.SignInAsync(principal, properties);
        //            return RedirectToPage("/Admin/Index");

        //            var checkuser = _permissionService.CheckUserIsRole(user.UserName);
        //            if (checkuser)
        //            {
        //                return RedirectToPage("/Admin/Index");
        //            }

        //            else
        //            {
        //                return LocalRedirect("/userpanel/home/index");
        //            }
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("UserName", "کاربری شما غیر فعال می باشد");
        //            return View("login", login);
        //        }
        //    }
        //    ModelState.AddModelError("UserName", "کاربری با این مشخصات یافت نشد");
        //    return View("login", login);
        //}


        //[Route("Logout")]
        //public IActionResult Logout()

        //{
        //   HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    return RedirectToAction("Login", "Home");
        //}

        public IActionResult error404()
        {
            return View();
        }

        public IActionResult error500()
        {
            return View();
        }
        public IActionResult error()
        {
            return View();
        }

        public IActionResult GetCityByOstanId(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید" , Value = ""}
            };
            list.AddRange(_commonService.GetCityByProvinceIDSelectList(id));
            return Json(new SelectList(list, "Value", "Text"));
        }

        public IActionResult AddTecherToClass(string teacherId, string courseId)
        {
            int teacherCourseId = _courseService.AddTeacherToClass(Convert.ToInt32(teacherId), Convert.ToInt32(courseId));
            return Json(teacherCourseId);
        }

        public IActionResult AddStudentToClass(string[] userId, string courseId)
        {
            foreach (string id in userId)
            {
                _courseService.AddStudentToClass(Convert.ToInt32(id), Convert.ToInt32(courseId));
            }

            return Json(" مشتریان با موفقیت به کلاس اضافه شدند.");
        }

        #region Exam

        public IActionResult AddQuestionToExam(string[] questionId, string examId)
        {
            foreach (string id in questionId)
            {
                _examService.AddQuestionToExam(Convert.ToInt32(id), Convert.ToInt32(examId));
            }

            return Json(" سوالات با موفقیت به آزمون اضافه شدند.");
        }

        public IActionResult AddStudentToExam(string[] userId, string examId)
        {
            foreach (string id in userId)
            {
                _examService.AddStudentToExam(Convert.ToInt32(id), Convert.ToInt32(examId));
            }

            return Json(" فراگیران با موفقیت به آزمون اضافه شدند.");
        }

        public IActionResult DeleteQuestionFromExam(string[] questionId, string examId)
        {
            foreach (string id in questionId)
            {
                _examService.DeleteQuestionFromExam(Convert.ToInt32(id), Convert.ToInt32(examId));
            }

            return Json(" فراگیران با موفقیت حذف شدند.");
        }


        public IActionResult DeleteStudentFromExam(string[] userId, string examId)
        {
            foreach (string id in userId)
            {
                _examService.DeleteStudentFromExam(Convert.ToInt32(id), Convert.ToInt32(examId));
            }

            return Json(" فراگیران با موفقیت حذف شدند.");
        }
        #endregion

        public IActionResult DeleteStudent(string[] userId, string courseId)
        {
            foreach (string id in userId)
            {
                _courseService.DeleteStudentFromClass(Convert.ToInt32(id), Convert.ToInt32(courseId));
            }

            return Json(" مشتریان با موفقیت حذف شدند.");
        }

        public IActionResult GetSubGroups(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید",Value = ""}
            };

            list.AddRange(_courseService.GetSubGroupForManageCourse(id));
            return Json(new SelectList(list, "Value", "Text"));
        }

        [HttpPost]
        [Route("file-upload")]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            if (upload.Length <= 0) return null;

            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();

            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "wwwroot/MyImages",
                fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);
            }

            var url = $"{"/MyImages/"}{fileName}";

            return Json(new { uploaded = true, url });
        }

        [Route("OnlinePayment/{id}")]
        public IActionResult onlinePayment(int id)
        {
            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok"
                && HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];

                var wallet = _userService.GetWalletByWalletId(id);

                var payment = new ZarinpalSandbox.Payment(wallet.Amount);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    ViewBag.code = res.RefId;
                    ViewBag.IsSuccess = true;
                    wallet.IsPay = true;
                    _userService.UpdateWallet(wallet);
                }

            }

            return View();
        }

    }
}
