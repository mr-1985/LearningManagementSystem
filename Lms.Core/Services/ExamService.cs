using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Lms.DataLayer.Context;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lms.Core.Services
{
    public class ExamService : IExamService
    {
        private LmsContext _context;

        public ExamService(LmsContext context)
        {
            _context = context;
        }

        public List<AddQuestionViewModel> GetQuestionByCourseId(int courseId)
        {
            return _context.MultipleQuestions
                .Where(q => q.CourseId == courseId)
                .Include(q => q.QuestionType)
                .Include(q => q.QuestionLevel)
                .Select(q => new AddQuestionViewModel()
                {
                    QuestionId = q.QuestionId,
                    QuestionText = q.QuestionText,
                    TypeTitle = q.QuestionType.TypeTitle,
                    LevelTitle = q.QuestionLevel.LevelTitle,
                    QuestionFile = q.QuestionFile
                })
                .ToList();
        }

        public List<AddQuestionViewModel> GetAllQuestions(int examId, int courseId)
        {
            List<int> listOfQuestions = GetQuestionsInExam(examId).Select(q => q.QuestionId).ToList();

            return _context.MultipleQuestions.Where(q => q.CourseId == courseId && !listOfQuestions.Contains(q.QuestionId))
                .Include(q => q.QuestionType)
                .Include(q => q.QuestionLevel)
                .Select(q => new AddQuestionViewModel()
                {
                    QuestionId = q.QuestionId,
                    QuestionText = q.QuestionText,
                    TypeTitle = q.QuestionType.TypeTitle,
                    LevelTitle = q.QuestionLevel.LevelTitle,
                    QuestionFile = q.QuestionFile
                }).ToList();

        }

        public List<AddQuestionViewModel> GetQuestionsInExam(int examId)
        {
            return _context.ExamQuestions.Where(q => q.ExamId == examId && q.IsDelete == false)
                .Include(q => q.MultipleQuestion).ThenInclude(q => q.QuestionType)
                .Include(q => q.MultipleQuestion).ThenInclude(q => q.QuestionLevel)
                .Select(q => new AddQuestionViewModel()
                {
                    QuestionId = q.MultipleQuestion.QuestionId,
                    QuestionText = q.MultipleQuestion.QuestionText,
                    TypeTitle = q.MultipleQuestion.QuestionType.TypeTitle,
                    LevelTitle = q.MultipleQuestion.QuestionLevel.LevelTitle,
                    QuestionFile = q.MultipleQuestion.QuestionFile
                }).ToList();
        }

        public List<SelectListItem> GetLevels()
        {
            return _context.QuestionLevels.Select(l => new SelectListItem()
            {
                Value = l.LevelId.ToString(),
                Text = l.LevelTitle
            }).ToList();
        }

        public int AddQuestion(MultipleQuestion multipleQuestion)
        {
            multipleQuestion.TypeId = 1;
            _context.MultipleQuestions.Add(multipleQuestion);
            _context.SaveChanges();
            return multipleQuestion.QuestionId;
        }

        public int AddExam(Exam exam, int courseId)
        {
            var course = _context.Courses.Find(courseId);

            _context.Exams.Add(exam);
            _context.SaveChanges();
            return exam.ExamId;
        }

        public List<GetStudentListViewModel> GetStudents(int examId, int courseId)
        {
            List<int> listOfStudents = GetStudentsInExam(examId).Select(u => u.UserId).ToList();


            return _context.UserCourses.
                Where(u => u.CourseId == courseId && u.IsDelete == false && !listOfStudents.Contains((int)(u.UserId))).
                Select(u => new GetStudentListViewModel()
                {
                    UserId = (int)u.UserId,
                    UserName = u.User.UserName,
                    FirstName = u.User.FirstName,
                    Email = u.User.Email,
                    LastName = u.User.LastName,
                    Mobile = u.User.Mobile,
                    UserAvatar = u.User.UserAvatar
                }).ToList();
        }

        public List<GetStudentListViewModel> GetStudentsInExam(int examId)
        {
            return _context.ExamStudents.Where(u => u.ExamId == examId && u.IsDelete == false)
                .Select(u => new GetStudentListViewModel()
                {
                    UserId = (int)u.UserId,
                    UserName = u.User.UserName,
                    FirstName = u.User.FirstName,
                    Email = u.User.Email,
                    LastName = u.User.LastName,
                    Mobile = u.User.Mobile,
                    UserAvatar = u.User.UserAvatar
                }).ToList();
        }

        public int AddStudentToExam(int userId, int examId)
        {
            if (!_context.ExamStudents
                .Any(u => u.UserId == userId && u.ExamId == examId && u.IsDelete == false))
            {
                ExamStudent examStudent = new ExamStudent();
                examStudent.UserId = userId;
                examStudent.ExamId = examId;
                examStudent.IsDelete = false;
                _context.ExamStudents.Add(examStudent);
                _context.SaveChanges();
                return examStudent.ES_Id;
            }

            return 0;
        }

        public void DeleteStudentFromExam(int userId, int examId)
        {
            var userInExam = _context.ExamStudents
                .Single(u => u.UserId == userId && u.ExamId == examId && u.IsDelete == false);
            userInExam.IsDelete = true;
            _context.Update(userInExam);
            _context.SaveChanges();
        }

        public int AddQuestionToExam(int questionId, int examId)
        {
            if (!_context.ExamQuestions
                .Any(u => u.QuestionId == questionId && u.ExamId == examId && u.IsDelete == false))
            {
                ExamQuestion examQuestion = new ExamQuestion();
                examQuestion.QuestionId = questionId;
                examQuestion.ExamId = examId;
                examQuestion.IsDelete = false;
                _context.ExamQuestions.Add(examQuestion);
                _context.SaveChanges();
                return examQuestion.EQ_Id;
            }

            return 0;
        }

        public void DeleteQuestionFromExam(int questionId, int examId)
        {
            var question = _context.ExamQuestions
                .Single(u => u.QuestionId == questionId && u.ExamId == examId && u.IsDelete == false);
            question.IsDelete = true;
            _context.Update(question);
            _context.SaveChanges();
        }

        public Exam GetExamById(int examId)
        {
            return _context.Exams.Find(examId);
        }

        public Exam GetExam(int examId)
        {
            return _context.Exams
                .Include(e => e.ExamQuestions).ThenInclude(eq => eq.MultipleQuestion)
                .Include(e => e.ExamStudents).ThenInclude(es => es.User)
                .FirstOrDefault(e => e.ExamId == examId);
        }

        public List<QuizAnswersViewModel> GetAllQuestions()
        {
            return _context.MultipleQuestions.Select(a => new QuizAnswersViewModel()
            {
                QuestionId = a.QuestionId,
                correctAnswer = a.CorrectAnswer
            }).ToList();
        }

        public List<UserScore> GetExamsList(int userId)
        {
            return _context.UserScores.
                Where(u => u.UserId == userId).
                Include(e => e.User).ThenInclude(e => e.ExamStudents).
                Include(c => c.Exam).ThenInclude(e => e.Course)
                .ToList();
        }

        public ExamQuestionsViewModel GetQuestionsForExam(int examId, int take = 1, int pageId = 1)
        {
            var result = _context.ExamQuestions.
                    Where(e => e.ExamId == examId && e.IsDelete == false).
                    Include(m => m.MultipleQuestion)
                    .Select(q => new QuestionForExamViewModel()
                    {
                        QuestionText = q.MultipleQuestion.QuestionText,
                        QuestionId = q.MultipleQuestion.QuestionId,
                        Alternate1 = q.MultipleQuestion.Alternate1,
                        Alternate2 = q.MultipleQuestion.Alternate2,
                        Alternate3 = q.MultipleQuestion.Alternate3,
                        Answer = q.MultipleQuestion.CorrectAnswer
                    }).ToList();

            int takeDate = take;
            int skip = (pageId - 1) * takeDate;

            ExamQuestionsViewModel list=new ExamQuestionsViewModel();
            list.CurrentPage = pageId;
            list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
            list.UserCounts = result.Count();
            list.QuestionForExam = result.Skip(skip).Take(takeDate).ToList();

            return list;
        }

        //public Tuple<List<QuestionForExamViewModel>, int> GetQuestionsForExam(int examId, int pageId = 1)
        //{
        //    int take = 1;
        //    int skip = (pageId - 1) * take;

        //    var query = _context.ExamQuestions.
        //        Where(e => e.ExamId == examId && e.IsDelete == false).
        //        Include(m => m.MultipleQuestion)
        //        .Select(q => new QuestionForExamViewModel()
        //        {
        //            QuestionText = q.MultipleQuestion.QuestionText,
        //            QuestionId = q.MultipleQuestion.QuestionId,
        //            Alternate1 = q.MultipleQuestion.Alternate1,
        //            Alternate2 = q.MultipleQuestion.Alternate2,
        //            Alternate3 = q.MultipleQuestion.Alternate3,
        //            Answer = q.MultipleQuestion.CorrectAnswer

        //        }).ToList();

        //    var pageCount = query.Count() / take;

        //    //if ((pageCount % 2) != 0)
        //    //{
        //    //    pageCount += 1;
        //    //}

        //    return Tuple.Create(query.Skip(skip).Take(take).ToList(), pageCount);
        //}

        //public int AddScore(int userId, int examId)
        //{
        //    if (!_context.UserScores
        //        .Any(u => u.UserId == userId && u.ExamId == examId))
        //    {
        //        UserScore totalScore = new UserScore();
        //        totalScore.UserId = userId;
        //        totalScore.ExamId = examId;
        //        totalScore.CorrectionDate = DateTime.Now;
        //        _context.UserScores.Add(totalScore);
        //        _context.SaveChanges();
        //        return totalScore.UserId;
        //    }

        //    return 0;
        //}

        public int AddHistory(QuestionHistory history)
        {
            _context.QuestionHistories.Add(history);
            _context.SaveChanges();
            return history.EQHId;
        }

        public Tuple<List<ExamForListShowViewModel>, ExamForListAdminViewModel> GetExams(int pageId = 1, int take = 5, string filter = "")
        {
            IQueryable<Exam> result = _context.Exams;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.ExamTitle.Contains(filter) && c.Course.Title.Contains(filter));
            }

            int takeDate = take;
            int skip = (pageId - 1) * takeDate;

            ExamForListAdminViewModel list = new ExamForListAdminViewModel();
            list.CurrentPage = pageId;
            list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
            list.Exams = result.OrderByDescending(c => c.ExamId).Skip(skip).Take(takeDate).ToList();
            list.ExamCounts = _context.Exams.Count();

            var query = result.Include(e => e.Course).
                Select(c => new ExamForListShowViewModel()
                {
                    ExamId = c.ExamId,
                    ExamTitle = c.ExamTitle,
                    ExamTime = c.ExamTime,
                    ExamStartDate = c.ExamStartDate,
                    ExamEndDate = c.ExamEndDate,
                    CourseTitle = c.Course.Title
                }).Skip(skip).Take(takeDate).ToList();
            return Tuple.Create(query, list);
        }

        public MultipleQuestion GetQuestionByQuestionId(int questionId)
        {
            return _context.MultipleQuestions.Find(questionId);
        }

        public QuestionHistory GetHistory(int examId, int questionId, int userId)
        {
            return _context.QuestionHistories.FirstOrDefault(h =>
                h.ExamId == examId && h.QuestionId == questionId && h.UserId == userId);
        }

        public void UpdateHistory(QuestionHistory history)
        {
            _context.QuestionHistories.Update(history);
            _context.SaveChanges();
        }

        public int GetHistoryforResult(int examId, int userId)
        {
            return _context.QuestionHistories.Count(h => h.ExamId == examId && h.UserId == userId && h.AnswerIsTrue == true);
        }

        public int GetNumberOfQuestions(int examId)
        {
            return _context.ExamQuestions.Count(h => h.ExamId == examId && h.IsDelete == false);
        }

        public bool IsUserInExam(int examId, int userId)
        {
            return _context.QuestionHistories.Any(qh => qh.ExamId == examId && qh.UserId == userId);
        }

        public UserScore GetUserScore(int examId, int userId)
        {
            return _context.UserScores.
                Include(s => s.Exam).ThenInclude(c => c.Course).
                FirstOrDefault(us => us.ExamId == examId && us.UserId == userId);
        }

        public List<ExamStudent> GetUserExams(int userId)
        {
            return _context.ExamStudents.
                Include(e => e.Exam).ThenInclude(e => e.Course).
                Where(e => e.UserId == userId && e.IsDelete == false)
                .ToList();
        }

        public List<UserScore> GetUserExamResults(int userId)
        {
            return _context.UserScores.
                Include(e => e.Exam).ThenInclude(c => c.Course).
                Where(s => s.UserId == userId).ToList();
        }

        public int AddScore(UserScore score)
        {
            _context.UserScores.Add(score);
            _context.SaveChanges();
            return score.ScoreId;
        }

        public Exam GetExamForShow(int examId)
        {
            return _context.Exams.
                Include(e => e.Course).
                Include(e => e.User).
                Include(e => e.ExamQuestions).
                ThenInclude(e => e.MultipleQuestion).ThenInclude(e => e.QuestionType)
                .Include(e => e.ExamQuestions).ThenInclude(e => e.MultipleQuestion).ThenInclude(e => e.QuestionLevel).FirstOrDefault(e => e.ExamId == examId);
        }
    }
}
