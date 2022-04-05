using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.News
{
    public class DeleteNewsModel : PageModel
    {
        private INewsService _newsService;

        public DeleteNewsModel(INewsService newsService)
        {
            _newsService = newsService;
        }

        public InformationPageViewModel InformationPageViewModel { get; set; }
        public void OnGet(int id)
        {
            InformationPageViewModel = _newsService.GetPageInformation(id);
            ViewData["PageId"] = id;
        }

        public IActionResult OnPost(int pageId)
        {
            _newsService.DeleteNews(pageId);
            return RedirectToPage("Index");
        }
    }
}
