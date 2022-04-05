using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Quiz
{
    public class IndexExamModel : PageModel
    {
        private IExamService _examService;

        public IndexExamModel(IExamService examService)
        {
            _examService = examService;
        }

        public List<AddQuestionViewModel> MultipleQuestions { get; set; }
        public void OnGet(int id)
        {
            ViewData["CourseId"] = id;
            MultipleQuestions = _examService.GetQuestionByCourseId(id);
        }
        
    }
}
