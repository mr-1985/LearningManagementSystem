using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.ViewModels;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lms.Core.Services.Interfaces
{
    public interface IExamService
    {
        List<AddQuestionViewModel> GetQuestionByCourseId(int courseId);
        List<AddQuestionViewModel> GetAllQuestions(int examId, int courseId);
        List<AddQuestionViewModel> GetQuestionsInExam(int examId);
        List<SelectListItem> GetLevels();
        int AddQuestion(MultipleQuestion multipleQuestion);
        int AddExam(Exam exam, int courseId);
        List<GetStudentListViewModel> GetStudents(int examId, int courseId);
        List<GetStudentListViewModel> GetStudentsInExam(int examId);
        int AddStudentToExam(int userId, int examId);
        void DeleteStudentFromExam(int userId, int examId);
        public int AddQuestionToExam(int questionId, int examId);
        void DeleteQuestionFromExam(int questionId, int examId);
        Exam GetExamById(int examId);
        Exam GetExamForShow(int examId);
        Exam GetExam(int examId);
        List<QuizAnswersViewModel> GetAllQuestions();
        List<UserScore> GetExamsList(int userId);
        //Tuple<List<QuestionForExamViewModel>, int> GetQuestionsForExam(int examId, int pageId = 1);
        ExamQuestionsViewModel GetQuestionsForExam(int examId,int take=1, int pageId = 1);
        //int AddScore(int userId, int examId);
        int AddScore(UserScore score);
        int AddHistory(QuestionHistory history);
        Tuple<List<ExamForListShowViewModel>, ExamForListAdminViewModel> GetExams(int pageId = 1, int take = 5, string filter = "");
        MultipleQuestion GetQuestionByQuestionId(int questionId);
        QuestionHistory GetHistory(int examId, int questionId, int userId);
        void UpdateHistory(QuestionHistory history);
        int GetHistoryforResult(int examId, int userId);
        int GetNumberOfQuestions(int examId);
        bool IsUserInExam(int examId, int userId);
        UserScore GetUserScore(int examId, int userId);
        List<ExamStudent> GetUserExams(int userId);
        List<UserScore> GetUserExamResults(int userId);
    }
}
