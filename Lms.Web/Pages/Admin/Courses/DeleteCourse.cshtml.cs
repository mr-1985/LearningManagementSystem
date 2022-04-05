using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Courses
{
    public class DeleteCourseModel : PageModel
    {
        private ICourseService _courseService;

        public DeleteCourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public InformationCourseViewModel InformationCourseViewModel { get; set; }
        public void OnGet(int id)
        {
            InformationCourseViewModel = _courseService.GetCourseInformation(id);
            ViewData["CourseId"] = id;
        }

        public IActionResult OnPost(int CourseId)
        {
            _courseService.DeleteCourse(CourseId);
            return RedirectToPage("Index");
        }
    }
}
