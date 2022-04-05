using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.ViewModels;
using Lms.DataLayer.Entities.News;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lms.Core.Services.Interfaces
{
    public interface INewsService
    {
        List<SelectListItem> GetGroupForManageNews();
        List<PageGroup> GetAllGroup();
        int AddPage(Page page, IFormFile imgPage);
        Tuple<List<NewsForAdminInListViewModel>, NewsForAdminViewModel> GetNews(int PageId = 1, int take = 5, string filter = "");
        Page GetPageById(int pageId);
        void UpdatePage(Page page, IFormFile imgPage);
        InformationPageViewModel GetPageInformation(int pageId);
        void DeleteNews(int PageId);
        List<NewsForArchiveViewModel> GetNewsForIndex();
        NewslistViewModel GetNewsPage(int pageId = 1, string filter = "", List<int> selectedGroups = null, int take = 0);
        List<SelectListItem> GetAuthors();
        Page GetPageForShow(int pageId);
        void UpdateNews(Page page);
        Tuple<List<PageComment>, int> GetNewsComment(int newsId, int pageId = 1);
        void AddComment(PageComment comment);

    }
}
