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
    public class IndexModel : PageModel
    {
        private INewsService _newsService;

        public IndexModel(INewsService newsService)
        {
            _newsService = newsService;
        }

        public List<NewsForAdminInListViewModel> NewsForAdminInListViewModels { get; set; }
        public NewsForAdminViewModel NewsForAdminViewModel { get; set; }
        public void OnGet(int PageId = 1, int take = 5, string filter = "")
        {
            if (PageId > 1)
            {
                ViewData["Take"] = (PageId - 1) * take + 1;
            }
            else
            {
                ViewData["Take"] = take;
            }

            ViewData["Filter"] = filter;

            ViewData["PageID"] = (PageId - 1) * take + 1;

            NewsForAdminViewModel = _newsService.GetNews(PageId, take, filter).Item2;
            NewsForAdminInListViewModels= _newsService.GetNews(PageId, take, filter).Item1;

        }
    }
}
