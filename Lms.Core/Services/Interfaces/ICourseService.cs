using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.ViewModels;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lms.Core.Services.Interfaces
{
    public interface ICourseService
    {
        //public int AddCourse(Course course,IFormFile imageCourse);
        //int CreateVirtualClasses(VirtualClass virtualClass);
        void DeleteCourse(int courseId);
        void UpdateCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        void UpdateCourse(Course course);
        List<Course> GetAllCourses();
        Course GetCourseById(int courseId);
        EditCourseViewModel GetCourseByIdForEdit(int courseId);
        Tuple<List<CourseForAdminListPageViewModel>, CourseForAdminViewModel> GetCourses(int PageId = 1, int take = 5, string filter = "");
        List<SelectListItem> GetTeachers();
        //Tuple<List<CourseForUserListPageViewModel>, MyCourseViewModel> GetCoursesUser(int userId, int PageId = 1, int take =5, string filter = "" );
        MyCourseViewModel GetCoursesUsers(int userId, int PageId = 1, int take = 5, string filter = "");
        void EditCourseFromAdmin(EditCourseViewModel editCourse);
        InformationCourseViewModel GetCourseInformation(int CourseId);
        GetTeacherViewModel getTeacherList(int CourseId);
        //List<GetTeacherViewModel> getTeacherListNotSelectedInClass(int CourseId);
        int AddTeacherToClass(int teacherId, int courseId);
        //int AddStudentToClass(int studentId, int teacherCourseId);
        List<GetStudentListViewModel> GetStudents(int courseId);
        List<GetStudentListViewModel> GetStudentsInClass(int courseId);
        int AddStudentToClass(int userId, int courseId);
        void DeleteStudentFromClass(int userId, int courseId);
        bool IsExistUserInClass(int userId, int courseId);
        List<GetStudentListViewModel> getStudentListForAddToClass(int teacherCourseId);
        List<GetStudentListViewModel> getStudentListNotSelectedForAddToClass(int courseId);
        List<SelectListItem> GetGroupForManageCourse();
        List<SelectListItem> GetSubGroupForManageCourse(int groupId);
        List<CourseGroup> GetAllGroups();
        //Tuple<List<ShowCourseListItemViewModel>, int> GetCourse(int pageId = 1, string filter = "", string getType = "all",
        //    string orderByType = "date", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null, int take = 0);

        List<ShowCourseListItemViewModel> GetCourseForHomePage();
        CourseInArchiveViewModel GetCourseForArchive(int pageId = 1, string filter = "", string getType = "all",
            string orderByType = "date", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null, int take = 0);
        void AddGroup(CourseGroup group);
        CourseGroup GetById(int groupId);
        void UpdateGroup(CourseGroup group);
        Course GetCourseForShow(int courseId);
        bool CheckExistFile(string fileName);
        int AddEpisode(CourseEpisode episode, IFormFile episodeFile);
        List<CourseEpisode> GetListEpisodeCorse(int courseId);
        CourseEpisode GetEpisodeById(int episodeId);
        void EditEpisode(CourseEpisode episode, IFormFile episodeFile);
        List<SelectListItem> GetLevels();
        List<SelectListItem> GetStatues();
        void AddComment(CourseComment comment);
        Tuple<List<CourseComment>, int> GetCourseComment(int courseId, int pageId = 1);
        List<ShowCourseListItemViewModel> GetPopularCourse();

        int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        bool IsFree(int courseId);
        Tuple<int, int> GetCourseVotes(int courseId);
        void AddsVote(int userId, int courseId, bool vote);
    }
}
