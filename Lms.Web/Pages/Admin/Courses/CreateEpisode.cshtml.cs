using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Courses
{
    public class CreateEpisodeModel : PageModel
    {
        private ICourseService _courseService;

        public CreateEpisodeModel(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [BindProperty]
        public CourseEpisode CourseEpisode { get; set; }
        public void OnGet(int id)
        {
            CourseEpisode = new CourseEpisode();
            CourseEpisode.CourseId = id;

        }


        public IActionResult OnPost(IFormFile fileEpisode)
        {
            if (!ModelState.IsValid || fileEpisode == null)
                return Page();

            if (_courseService.CheckExistFile(fileEpisode.FileName))
            {
                ViewData["IsExistFile"] = true;
                return Page();
            }


            _courseService.AddEpisode(CourseEpisode, fileEpisode);

            return Redirect("/Admin/Courses/IndexEpisode/" + CourseEpisode.CourseId);
        }
    }
}
