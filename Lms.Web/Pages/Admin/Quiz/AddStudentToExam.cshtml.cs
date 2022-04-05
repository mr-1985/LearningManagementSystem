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
    public class AddStudentToExamModel : PageModel
    {
        private IExamService _examService;

        public AddStudentToExamModel(IExamService examService)
        {
            _examService = examService;
        }

        public QuestionHistory QuestionHistory { get; set; }

        public Exam Exam { get; set; }

        public List<GetStudentListViewModel> GetStudentListViewModel { get; set; }
        public List<GetStudentListViewModel> GetStudentListInExam { get; set; }
        public void OnGet(int id)
        {
            QuestionHistory=new QuestionHistory();
            QuestionHistory.ExamId = id;

            Exam = _examService.GetExamById(id);
            var courseId = Exam.CourseId;

            ViewData["examId"] = id;

            GetStudentListInExam = _examService.GetStudentsInExam(id);
            GetStudentListViewModel = _examService.GetStudents(id,courseId);
        }
    }
}
