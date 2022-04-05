using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;

namespace Lms.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ICourseService _courseService;

        public ValuesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetPopularCourse()
        {
            var popular = _courseService.GetPopularCourse();

            if (popular.Count == 0)
            {
                return NotFound();
            }
           
            return Ok(popular);
        }
    }
}
