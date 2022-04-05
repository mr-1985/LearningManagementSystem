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
    public class AddQuestionsModel : PageModel
    {
        private IExamService _examService;

        public AddQuestionsModel(IExamService examService)
        {
            _examService = examService;
        }

        [BindProperty]
        public ExamQuestion ExamQuestion { get; set; }

        public Exam Exam { get; set; }

        public List<AddQuestionViewModel> Questions { get; set; }
        public List<AddQuestionViewModel> GetQuestionsInExam { get; set; }

        public void OnGet(int id)
        {
            ExamQuestion=new ExamQuestion();
            ExamQuestion.ExamId = id;

            Exam = _examService.GetExamById(id);
            var courseId = Exam.CourseId;

            ViewData["ExamId"] = id;
            ViewData["CourseId"] = courseId;

            Questions = _examService.GetAllQuestions(id,courseId);
            GetQuestionsInExam = _examService.GetQuestionsInExam(id);
        }
    }
}
