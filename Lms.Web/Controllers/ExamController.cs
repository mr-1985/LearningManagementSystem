using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Lms.DataLayer.Context;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;

namespace Lms.Web.Controllers
{
    public class ExamController : Controller
    {
        private IExamService _examService;
        private IUserService _userService;

        public ExamController(IExamService examService, IUserService userService)
        {
            _examService = examService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            int userId = _userService.GetUserIdByUserName(User.Identity.Name);
            var exam = _examService.GetExamsList(userId);

            return View(exam);
        }


        [Authorize]
        public IActionResult Exam(int id)
        {
            int userId = _userService.GetUserIdByUserName(User.Identity.Name);

            ViewBag.UserId = userId;

            var exam = _examService.GetExamById(id);
            if (exam == null)
            {
                return NotFound();
            }

            if (_examService.IsUserInExam(id, userId))
            {
                ViewBag.IsExistUserInExam = true;

                if (exam == null)
                {
                    return NotFound();
                }

                //return View(exam);
            }

            if (exam.ExamStartDate > DateTime.Now)
            {
                //ViewBag.AccessDenied = true;
                //return PartialView("_ExamIsNotBegin");
                return NotFound();
            }

            if (!(exam.ExamEndDate >= DateTime.Now))
            {
                //ViewBag.ExamTimeIsExpired = true;

                //if (exam == null)
                //{
                //    return NotFound();
                //}

                //return View(exam);

                //return NotFound();
                return Forbid();
            }

            return View(exam);
        }

        [HttpPost]
        public IActionResult Exam(int QuestionId, int ExamId, string userAnswer)
        {
            int userId = _userService.GetUserIdByUserName(User.Identity.Name);
            var question = _examService.GetQuestionByQuestionId(QuestionId);
            var correctAnswer = question.CorrectAnswer;

            var questionHistory = _examService.GetHistory(ExamId, QuestionId, userId);
            if (questionHistory == null)
            {
                QuestionHistory history = new QuestionHistory();
                if (userAnswer.Trim() == correctAnswer.Trim())
                {
                    history.AnswerIsTrue = true;
                }

                history.AnswerText = correctAnswer;
                history.UserAnswer = userAnswer;
                history.ExamId = ExamId;
                history.UserId = userId;
                history.QuestionId = QuestionId;
                _examService.AddHistory(history);
            }
            else
            {
                questionHistory.UserAnswer = userAnswer;
                if (userAnswer.Trim() == correctAnswer.Trim())
                {
                    questionHistory.AnswerIsTrue = true;
                }
                else
                {
                    questionHistory.AnswerIsTrue = false;
                }
                _examService.UpdateHistory(questionHistory);
            }

            return Json(" برای دسترسی به سوال بعد منتظر بمانید.");
        }

        public IActionResult Questions(int id, int take = 1, int pageId = 1)
        {
            //if (pageId > 1)
            //{
            //    ViewBag.Take = (pageId - 1) * take + 1;
            //}
            //else
            //{
            //    ViewBag.Take = take;
            //}
            //ViewBag.pageId = (pageId - 1) * take + 1;

            var questions = _examService.GetQuestionsForExam(id, take, pageId);
            ViewBag.list = questions.QuestionForExam;
            ViewBag.PageCount = questions.PageCount;
            ViewBag.currentPage = questions.CurrentPage;
            ViewBag.TotalItems = questions.UserCounts;

            return PartialView(questions.QuestionForExam);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Results(int examId)
        {
            int userId = _userService.GetUserIdByUserName(User.Identity.Name);
            var trueAnswers = _examService.GetHistoryforResult(examId, userId);
            var numberOfQuestions = _examService.GetNumberOfQuestions(examId);

            var TotalScore = (int)(((trueAnswers * 1.0) / numberOfQuestions) * 100);

            UserScore score = new UserScore();
            score.ExamId = examId;
            score.UserId = userId;
            score.CorrectionDate = DateTime.Now;
            score.Score = TotalScore;
            _examService.AddScore(score);

            return View("ExamResults", _examService.GetUserScore(examId,userId));
        }

    }

}

