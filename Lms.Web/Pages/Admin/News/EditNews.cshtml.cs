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
    public class EditNewsModel : PageModel
    {
        private INewsService _newsService;

        public EditNewsModel(INewsService newsService)
        {
            _newsService = newsService;
        }

        [BindProperty]
        public Page Page { get; set; }

        public void OnGet(int id)
        {
            Page = _newsService.GetPageById(id);

            var groups = _newsService.GetGroupForManageNews();
            ViewData["Groups"] = new SelectList(groups, "Value", "Text");

            var authors = _newsService.GetAuthors();
            ViewData["Authors"] = new SelectList(authors, "Value", "Text");
        }

        public IActionResult OnPost(IFormFile imgPageUp)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _newsService.UpdatePage(Page, imgPageUp);
            return RedirectToPage("Index");
        }
    }
}
