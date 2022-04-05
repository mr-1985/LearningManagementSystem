using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Page = Lms.DataLayer.Entities.News.Page;

namespace Lms.Web.Pages.Admin.News
{
    public class CreateNewsModel : PageModel
    {
        private INewsService _newsService;

        public CreateNewsModel(INewsService newsService)
        {
            _newsService = newsService;
        }

        [BindProperty]
        public Page Page { get; set; }
        public void OnGet()
        {
            var groups = _newsService.GetGroupForManageNews();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");

            var authors = _newsService.GetAuthors();
            ViewData["Authors"] = new SelectList(authors, "Value", "Text");
        }

        public IActionResult OnPost(IFormFile imgPage)
        {
            if (!ModelState.IsValid)
                return Page();

            _newsService.AddPage(Page, imgPage);

            return RedirectToPage("Index");
        }
    }
}
