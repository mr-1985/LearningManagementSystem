using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.DataLayer.Entities;

namespace Lms.Core.ViewModels
{
    public class AddQuestionViewModel
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string LevelTitle { get; set; }
        public string TypeTitle { get; set; }
        public string QuestionFile { get; set; }
    }

    public class CreateExamViewMdel
    {
       
        public int ExamId { get; set; }
        public int UserId { get; set; }

        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Alternate1 { get; set; }
        public string Alternate2 { get; set; }
        public string Alternate3 { get; set; }
        public string Alternate4 { get; set; }

        public int ExamTime { get; set; }
        //public List<MultipleQuestion> MultipleQuestions { get; set; }
    }

    public class QuizAnswersViewModel
    {
        public int QuestionId { get; set; }
        public string correctAnswer { get; set; }
        public bool isCorrect { get; set; }
    }

    public class ExamListViewModel
    {
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ExamTitle { get; set; }
        public int Score { get; set; }
    }


    public class QuestionForExamViewModel
    {
        public int CourseId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string Alternate1 { get; set; }
        public string Alternate2 { get; set; }
        public string Alternate3 { get; set; }
        public string Answer { get; set; }
        public int CorrectAnswer { get; set; }
    }

    public class ExamQuestionsViewModel
    {
        public List<QuestionForExamViewModel> QuestionForExam { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int UserCounts { get; set; }
    }

    public class ExamForListShowViewModel
    {
        public int ExamId { get; set; }
        public string ExamTitle { get; set; }
        public string CourseTitle { get; set; }
        public DateTime ExamStartDate { get; set; }
        public DateTime ExamEndDate { get; set; }
        public int ExamTime { get; set; }
    }

    public class ExamForListAdminViewModel
    {
        public List<Exam> Exams { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int ExamCounts { get; set; }
    }

    public class QuizAnswerViewModel
    {
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public int ExamId { get; set; }
        public string Answer { get; set; }
        public bool AnswerIsTrue { get; set; }
    }
}
