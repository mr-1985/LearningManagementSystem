using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;

namespace Lms.Web.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CourseGroupApiController : ControllerBase
    {
        private ICourseService _courseService;

        public CourseGroupApiController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetCourseGroups()
        {
            var groups = _courseService.GetAllGroups();

            if (groups.Count == 0)
            {
                return NotFound();
            }

            return Ok(groups);
        }
    }
}
