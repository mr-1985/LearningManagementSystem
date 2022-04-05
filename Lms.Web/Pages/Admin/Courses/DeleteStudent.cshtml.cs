using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Courses
{
    public class DeleteStudentModel : PageModel
    {
        private ICourseService _courseService;


        public DeleteStudentModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty]
        public UserCourse UserCourse { get; set; }
        public void OnGet(int id)
        {
            ViewData["CourseId"] = id;
        }

    }
}
