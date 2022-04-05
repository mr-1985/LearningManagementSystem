using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.Convertors;
using Lms.Core.Generators;
using Lms.Core.Security;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Lms.DataLayer.Context;
using Lms.DataLayer.Entities.News;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lms.Core.Services
{

    public class NewsService : INewsService
    {
        private LmsContext _context;

        public NewsService(LmsContext context)
        {
            _context = context;
        }

        public List<SelectListItem> GetGroupForManageNews()
        {
            return _context.PageGroups.Where(g => g.ParentId == null)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.Id.ToString()
                }).ToList();
        }

        public List<PageGroup> GetAllGroup()
        {
            return _context.PageGroups.ToList();
        }

        public int AddPage(Page page, IFormFile imgPage)
        {
            page.CreateDate = DateTime.Now;
            page.ImageName = "CourseDefault.jpg";
            page.Visit = 0;

            if (imgPage != null && imgPage.IsImage())
            {
                page.ImageName = GeneratorName.GenrateUniqeCode() + Path.GetExtension(imgPage.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/NewsPic", page.ImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgPage.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/NewsPic/thumb", page.ImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 150);
            }

            _context.Pages.Add(page);
            _context.SaveChanges();

            return page.PageID;
        }

        public Tuple<List<NewsForAdminInListViewModel>, NewsForAdminViewModel> GetNews(int PageId = 1, int take = 5, string filter = "")
        {
            IQueryable<Page> result = _context.Pages;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.Title.Contains(filter));
            }

            int takeDate = take;
            int skip = (PageId - 1) * takeDate;

            NewsForAdminViewModel list = new NewsForAdminViewModel();
            list.CurrentPage = PageId;
            list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
            list.Pages = result.OrderByDescending(c => c.CreateDate).Skip(skip).Take(takeDate).ToList();
            list.PageCount = _context.Pages.Count();

            var query = result.Where(g => g.IsDelete == false).
                Include(g => g.MainGroup).
                Select(c => new NewsForAdminInListViewModel()
                {
                    GroupTitle = c.MainGroup.GroupTitle,
                    Title = c.Title,
                    PageId = c.PageID,
                    ShortDescription = c.ShortDescription,
                    ImageName = c.ImageName
                }).Skip(skip).Take(takeDate).ToList();

            return Tuple.Create(query, list);
        }

        public Page GetPageById(int pageId)
        {
            return _context.Pages.Find(pageId);
        }

        public void UpdatePage(Page page, IFormFile imgPage)
        {
            if (imgPage != null && imgPage.IsImage())
            {
                if (page.ImageName != "CourseDefault.jpg")
                {
                    string deleteImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/NewsPic",
                        page.ImageName);
                    if (File.Exists(deleteImagePath))
                    {
                        File.Delete(deleteImagePath);
                    }

                    string deleteThumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/NewsPic/Thumb",
                        page.ImageName);
                    if (File.Exists(deleteThumbPath))
                    {
                        File.Delete(deleteThumbPath);
                    }
                }

                page.ImageName = GeneratorName.GenrateUniqeCode() + Path.GetExtension(imgPage.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/NewsPic",
                    page.ImageName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgPage.CopyTo(stream);
                }

                //Resize Image
                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/NewsPic/Thumb",
                    page.ImageName);
                imgResizer.Image_resize(imagePath, thumbPath, 75);
            }

            _context.Pages.Update(page);
            _context.SaveChanges();
        }

        public InformationPageViewModel GetPageInformation(int pageId)
        {
            var page = GetPageById(pageId);
            InformationPageViewModel information = new InformationPageViewModel();
            information.PageId = pageId;
            information.Title = page.Title;
            //information.GroupTitle = page.PageGroup.GroupTitle;
            information.ImageName = page.ImageName;
            return information;
        }

        public void DeleteNews(int PageId)
        {
            var page = GetPageById(PageId);
            page.IsDelete = true;
            _context.Pages.Update(page);
            _context.SaveChanges();
        }

        public List<NewsForArchiveViewModel> GetNewsForIndex()
        {
            return _context.Pages.OrderByDescending(n => n.CreateDate)
                .Take(8)
                .Select(c => new NewsForArchiveViewModel()
                {
                    PageID = c.PageID,
                    Title = c.Title,
                    ImageName = c.ImageName,
                    ShortDescription = c.ShortDescription,
                    Visit = c.Visit,
                    CreateDate = c.CreateDate,
                    AuthorName = c.User.FirstName + " " + c.User.LastName,
                    PageComment = c.PageComments,
                    Tags = c.Tags
                })
                .ToList();
        }

        public NewslistViewModel GetNewsPage(int pageId = 1, string filter = "", List<int> selectedGroups = null, int take = 0)
        {
            if (take == 0)
                take = 8;

            //var result = _context.Pages.Where(p => p.IsDelete == false).
            //    Include(p => p.MainGroup).Include(p => p.User).
            //    Include(p => p.PageComments).
            //    Include(g => g.SubGroup).Select(p => new NewsForArchiveViewModel()
            //    {
            //        PageID = p.PageID,
            //        Visit = p.Visit,
            //        ShortDescription = p.ShortDescription,
            //        CreateDate = p.CreateDate,
            //        Title = p.Title,
            //        ImageName = p.ImageName,
            //        Tags = p.Tags,
            //        AuthorName = p.User.FirstName + " " + p.User.LastName,
            //        PageComment = p.PageComments
            //    });

            IQueryable<Page> result = _context.Pages;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.Title.Contains(filter) || c.Tags.Contains(filter));
            }

            if (selectedGroups != null && selectedGroups.Any())
            {
                foreach (int groupId in selectedGroups)
                {
                    result = result.Where(c => c.MainGroupId == groupId || c.SubGroupId == groupId);
                }
            }

            int takeDate = take;
            int skip = (pageId - 1) * takeDate;

            NewslistViewModel list = new NewslistViewModel();
            list.CurrentPage = pageId;
            list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
            list.NewsCounts = result.Count();
            list.NewsList = result.Select(p => new NewsForArchiveViewModel()
            {
                PageID = p.PageID,
                Visit = p.Visit,
                ShortDescription = p.ShortDescription,
                CreateDate = p.CreateDate,
                Title = p.Title,
                ImageName = p.ImageName,
                Tags = p.Tags,
                AuthorName = p.User.FirstName + " " + p.User.LastName,
                PageComment = p.PageComments
            }).Skip(skip).Take(takeDate).ToList();

            return list;
        }

        public List<SelectListItem> GetAuthors()
        {
            return _context.UserRoles.Where(r => r.RoleId == 4)
                .Include(r => r.User)
                .Select(u => new SelectListItem()
                {
                    Value = u.UserId.ToString(),
                    Text = u.User.FirstName + " " + u.User.LastName
                }).ToList();
        }

        public Page GetPageForShow(int pageId)
        {
            return _context.Pages.Include(c => c.PageComments).
                Include(c => c.MainGroup)
                .Include(c => c.User)
                .FirstOrDefault(c => c.PageID == pageId);
        }

        public void UpdateNews(Page page)
        {
            _context.Pages.Update(page);
            _context.SaveChanges();
        }

        public Tuple<List<PageComment>, int> GetNewsComment(int newsId, int pageId = 1)
        {
            int take = 5;
            int skip = (pageId - 1) * take;
            int pageCount = _context.PageComments.Count(c => !c.IsDelete && c.PageID == newsId) / take;

            if ((pageCount % 2) != 0)
            {
                pageCount += 1;
            }

            return Tuple.Create(
                _context.PageComments.Include(c => c.User).Where(c => !c.IsDelete && c.PageID == newsId).Skip(skip).Take(take)
                    .OrderByDescending(c => c.CreateDate).ToList(), pageCount);
        }

        public void AddComment(PageComment comment)
        {
            _context.PageComments.Add(comment);
            _context.SaveChanges();
        }
    }
}
