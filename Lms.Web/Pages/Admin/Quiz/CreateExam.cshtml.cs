using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Quiz
{
    public class CreateExamModel : PageModel
    {
        private IExamService _examService;
        private ICourseService _courseService;

        public CreateExamModel(IExamService examService, ICourseService courseService)
        {
            _examService = examService;
            _courseService = courseService;
        }

        public Course Course { get; set; }

        [BindProperty]
        public Exam Exam { get; set; }
        public void OnGet(int id,int ExamId)
        {
            //var exam = _examService.GetExamById(ExamId);
            if (ExamId != 0)
            {
                Exam = _examService.GetExamById(ExamId);
            }
            else
            {
                var course = _courseService.GetCourseById(id);
                var teacherId = course.TeacherId;

                Exam = new Exam();
                Exam.CourseId = id;
                Exam.TeacherId = teacherId;
            }
        }

        public IActionResult OnPost(int id, string stDate = "", string endDate = "")
        {
            if (stDate != "")
            {
                string[] std = stDate.Split('/', ' ', ':');
                Exam.ExamStartDate = new DateTime(
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    int.Parse(std[3]),
                    int.Parse(std[4]),
                    int.Parse(std[5]),
                    new GregorianCalendar()
                );
            }

            if (endDate != "")
            {
                //string[] edd = endDate.Split('/');
                string[] edd = endDate.Split('/', ' ', ':');
                Exam.ExamEndDate = new DateTime(int.Parse(edd[0]),
                    int.Parse(edd[1]),
                    int.Parse(edd[2]),
                    int.Parse(edd[3]),
                    int.Parse(edd[4]),
                    int.Parse(edd[5]),
                    new GregorianCalendar()
                );
            }

            if (!ModelState.IsValid)
                return Page();
            _examService.AddExam(Exam, id);

            return Redirect("/Admin/Quiz/AddQuestions/" + Exam.ExamId);
        }
    }
}
