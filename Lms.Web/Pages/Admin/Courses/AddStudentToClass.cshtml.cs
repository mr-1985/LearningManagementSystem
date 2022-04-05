using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Courses
{
    public class AddStudentToClassModel : PageModel
    {
        private ICourseService _courseService;

        public AddStudentToClassModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public List<GetStudentListViewModel> GetStudentListViewModel { get; set; }
        public List<GetStudentListViewModel> GetStudentListInClass { get; set; }

        public void OnGet(int id)
        {
            ViewData["courseId"] = id;

            GetStudentListInClass = _courseService.GetStudentsInClass(id);
            GetStudentListViewModel = _courseService.GetStudents(id);
           
        }

    }
}
