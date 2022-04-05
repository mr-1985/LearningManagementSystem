using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Http;

namespace Lms.Core.ViewModels
{
    public class CreateCourseViewModel
    {
        [Display(Name = "نام دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string Title { get; set; }

        [Display(Name = "کد دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string Code { get; set; }

        [Display(Name = "زمان دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int CourseTime { get; set; }

        [Display(Name = "درباره دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(1000, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string AboutCourse { get; set; }

        public bool IsActive { get; set; }

        public IFormFile CourseImage { get; set; }

    }
    public class EditCourseViewModel
    {
        [Display(Name = "نام دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string Title { get; set; }

        [Display(Name = "کد دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string Code { get; set; }

        public int CourseId { get; set; }

        [Display(Name = "زمان دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int CourseTime { get; set; }

        [Display(Name = "درباره دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(1000, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string AboutCourse { get; set; }

        public bool IsActive { get; set; }
        public string CourseImage { get; set; }
        public IFormFile CourseFile { get; set; }
    }

    public class CourseForAdminViewModel
    {
        public List<Course> Courses { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int UserCounts { get; set; }
    }

    public class MyCourseViewModel
    {
        public List<CourseForUserListPageViewModel> CourseForUserListPage { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int UserCounts { get; set; }
    }

    public class CourseForAdminListPageViewModel
    {
        public string Code { get; set; }
        public string CourseImage { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public int CourseTime { get; set; }
        public int CourseId { get; set; }
        public string groupTitle { get; set; }
        public bool IsActive { get; set; }
    }

    public class CourseForUserListPageViewModel
    {
        public string Code { get; set; }
        public string TeacherName { get; set; }
        public string CourseImage { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public int CourseTime { get; set; }
        public int CourseId { get; set; }
        public bool IsActive { get; set; }
    }

    public class GetTeacherViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string UserAvatar { get; set; }
        public int UserId { get; set; }
    }

    public class GetStudentListViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string UserAvatar { get; set; }
        public int UserId { get; set; }
    }

    public class InformationCourseViewModel
    {
        public string Code { get; set; }
        public string CourseImage { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public int CourseTime { get; set; }
        public int CourseId { get; set; }
        public string AboutCourse { get; set; }
    }

    public class ShowCourseListItemViewModel
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public int Price { get; set; }
        public int CourseTime { get; set; }
        public string Teacher { get; set; }
        public List<CourseEpisode> CourseEpisodes { get; set; }
    }

    public class CourseInArchiveViewModel
    {
        public List<ShowCourseListItemViewModel> ShowCourseList { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int CourseCounts { get; set; }
    }
}
