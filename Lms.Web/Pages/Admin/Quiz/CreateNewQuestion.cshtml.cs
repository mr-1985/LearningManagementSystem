using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lms.Web.Pages.Admin.Quiz
{

    public class CreateNewQuestionModel : PageModel
    {
        private IExamService _examService;

        public CreateNewQuestionModel(IExamService examService)
        {
            _examService = examService;
        }

        [BindProperty]
        public MultipleQuestion MultipleQuestion { get; set; }

        //public string[] Answers = new[] { "1", "2", "3","4" };

        public void OnGet(int id)
        {
            MultipleQuestion = new MultipleQuestion();
            MultipleQuestion.CourseId = id;

            var levels = _examService.GetLevels();
            ViewData["Levels"] = new SelectList(levels, "Value", "Text");

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _examService.AddQuestion(MultipleQuestion);

            return Redirect("/Admin/Quiz/IndexExam/" + MultipleQuestion.CourseId);
        }
    }
}

