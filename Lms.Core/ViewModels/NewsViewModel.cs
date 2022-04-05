using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.DataLayer.Entities;
using Lms.DataLayer.Entities.News;

namespace Lms.Core.ViewModels
{
    public class NewsForAdminViewModel
    {
        public List<Page> Pages { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int NewsCounts { get; set; }
    }

    public class NewsForAdminInListViewModel
    {
        public int PageId { get; set; }
        public string GroupTitle { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string ImageName { get; set; }
    }

    public class InformationPageViewModel
    {
        public int PageId { get; set; }
        public string GroupTitle { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
    }

    public class NewsForIndexListViewModel
    {
        public int PageId { get; set; }
        public int Visit { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string ImageName { get; set; }
    }

    public class NewsForArchiveViewModel
    {
        public int PageID { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string ShortDescription { get; set; }
        public int Visit { get; set; }
        public string ImageName { get; set; }
        public DateTime CreateDate { get; set; }
        public string Tags { get; set; }
        public List<PageComment> PageComment { get; set; }
    }

    public class NewslistViewModel
    {
        public List<NewsForArchiveViewModel> NewsList { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int NewsCounts { get; set; }
    }
}
