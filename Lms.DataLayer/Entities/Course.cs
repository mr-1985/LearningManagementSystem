using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int GroupId { get; set; }

        public int? SubGroup { get; set; }

        [Required]
        public int TeacherId { get; set; }

        [Required]
        public int StatusId { get; set; }

        [Required]
        public int LevelId { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public string AboutCourse { get; set; }

        [Display(Name = "قیمت دوره")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int CoursePrice { get; set; }

        [MaxLength(600)]
        public string Tags { get; set; }

        public string CourseImage { get; set; }

        [MaxLength(100)]
        public string DemoFileName { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }
        

        public virtual List<VirtualClass> VirtualClasses { get; set; }

        //[ForeignKey("GroupId")]
        public CourseGroup CourseGroup { get; set; }

        [ForeignKey("SubGroup")]
        public CourseGroup Group { get; set; }

        public CourseStatus CourseStatus { get; set; }

        public CourseLevel CourseLevel { get; set; }

        public List<CourseEpisode> CourseEpisodes { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

        public List<UserCourse> UserCourses { get; set; }

        [ForeignKey("TeacherId")] 
        public User User { get; set; }
        public List<CourseComment> CourseComments { get; set; }
        public List<CourseVote> CourseVotes { get; set; }


        //public List<MultipleQuestion> MultipleQuestions { get; set; }

        //public List<Exam> Exams { get; set; }

    }
}
