using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Security;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin
{
    public class MyCoursesModel : PageModel
    {
        private ICourseService _courseService;
        private IUserService _userService;

        public MyCoursesModel(ICourseService courseService, IUserService userService)
        {
            _courseService = courseService;
            _userService = userService;
        }

        //public List<CourseForUserListPageViewModel> MyCourse { get; set; }
        public MyCourseViewModel MyCourseViewModel { get; set; }
        public void OnGet(int PageId = 1, int take = 5, string filter = "")
        {
            if (PageId > 1)
            {
                ViewData["Take"] = (PageId - 1) * take + 1;
            }
            else
            {
                ViewData["Take"] = take;
            }

            ViewData["Filter"] = filter;

            ViewData["PageID"] = (PageId - 1) * take + 1;
            int userId = _userService.GetUserIdByUserName(User.Identity.Name);
            //MyCourse = _courseService.GetCoursesUser(userId,PageId, take, filter ).Item1;
            //MyCourseViewModel = _courseService.GetCoursesUser(userId,PageId, take, filter).Item2;
            MyCourseViewModel = _courseService.GetCoursesUsers(userId,PageId, take, filter);
        }
    }
}
