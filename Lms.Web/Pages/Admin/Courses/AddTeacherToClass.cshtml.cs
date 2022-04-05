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
    public class AddTeacherToClassModel : PageModel
    {
        private ICourseService _courseService;

        public AddTeacherToClassModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public GetTeacherViewModel GetTeacher { get; set; }
        public void OnGet(int id)
        {
            ViewData["CourseId"] = id;
            GetTeacher = _courseService.getTeacherList(id);
        }
    }
}
