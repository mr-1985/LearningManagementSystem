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
    public class NewsApiController : ControllerBase
    {
        private INewsService _newsService;

        public NewsApiController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public IActionResult GetPopularCourse()
        {
            var news = _newsService.GetNewsForIndex();

            if (news.Count == 0)
            {
                return NotFound();
            }

            return Ok(news);
        }
    }
}
