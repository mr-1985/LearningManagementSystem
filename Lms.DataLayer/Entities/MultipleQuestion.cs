using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class MultipleQuestion
    {
        [Key]
        public int QuestionId { get; set; }

        [Required]
        public string QuestionText { get; set; }

        public int? TeacherId { get; set; }

        public int CourseId { get; set; }

        [Required]
        public int LevelId { get; set; }

        [Required]
        public int TypeId { get; set; }

        [Required]
        [MaxLength(250)]
        public string Alternate1 { get; set; }

        [Required]
        [MaxLength(250)]
        public string Alternate2 { get; set; }

        [Required]
        [MaxLength(250)]
        public string Alternate3 { get; set; }

        [Required]
        [MaxLength(250)]
        public string Alternate4 { get; set; }

        [MaxLength(250)]
        public string QuestionFile { get; set; }

        [MaxLength(250)]
        public string Alternate1File { get; set; }

        [MaxLength(250)]
        public string Alternate2File { get; set; }

        [MaxLength(250)]
        public string Alternate3File { get; set; }

        [MaxLength(250)]
        public string Alternate4File { get; set; }

        [Required]
        public string CorrectAnswer { get; set; }


        #region Relations
        public Course Course { get; set; }

        [ForeignKey("TeacherId")]
        public User User { get; set; }

        public List<QuestionHistory> QuestionHistories { get; set; }

        [ForeignKey("LevelId")]
        public QuestionLevel QuestionLevel { get; set; }

        [ForeignKey("TypeId")]
        public QuestionType QuestionType { get; set; }

        public List<ExamQuestion> ExamQuestions { get; set; }

        #endregion
    }
}
