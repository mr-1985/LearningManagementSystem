using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Quiz
{
    public class IndexModel : PageModel
    {

        private IExamService _examService;

        public IndexModel(IExamService examService)
        {
            _examService = examService;
        }

        public List<ExamForListShowViewModel> ExamForListShow { get; set; }
        public ExamForListAdminViewModel ExamForListAdmin { get; set; }

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

            ExamForListShow = _examService.GetExams(PageId, take, filter).Item1;
            ExamForListAdmin = _examService.GetExams(PageId, take, filter).Item2;
        }
    }
}
