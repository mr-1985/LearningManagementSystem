using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Courses
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private ICourseService _courseService;

        public IndexModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        
        public List<CourseForAdminListPageViewModel> CourseForAdminListPage { get; set; }
        public CourseForAdminViewModel CourseForAdminViewModels { get; set; } 
        public void OnGet(int PageId = 1, int take =20, string filter = "")
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

            CourseForAdminListPage = _courseService.GetCourses(PageId, take, filter).Item1;
            CourseForAdminViewModels = _courseService.GetCourses(PageId, take, filter).Item2;
        }
    }
}
