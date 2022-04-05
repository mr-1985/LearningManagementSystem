using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }

        [Required]
        [MaxLength(250)]
        public string ExamTitle { get; set; }

        public int CourseId { get; set; }

        public int? TeacherId { get; set; }

        [Required]
        public DateTime ExamStartDate { get; set; }

        [Required]
        public DateTime ExamEndDate { get; set; }

        [Required]
        public int ExamTime { get; set; }

        [Required]
        public int ExamType { get; set; }

        public bool IsDelete { get; set; }

        public List<QuestionHistory> QuestionHistories { get; set; }
        public Course Course { get; set; }

        [ForeignKey("TeacherId")]
        public User User { get; set; }

        public UserScore UserScore { get; set; }
        public List<ExamQuestion> ExamQuestions { get; set; }
        public List<ExamStudent> ExamStudents { get; set; }
    }
}
