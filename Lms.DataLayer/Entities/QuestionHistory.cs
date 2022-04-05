using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class QuestionHistory
    {
        [Key]
        public int EQHId { get; set; }

        [Required]
        public int ExamId { get; set; }

        public int? QuestionId { get; set; }

        public int? UserId { get; set; }

        public string UserAnswer { get; set; }

        public string AnswerText { get; set; }
        public bool AnswerIsTrue { get; set; }

        public Exam Exam { get; set; }

        [ForeignKey("QuestionId")]
        public MultipleQuestion MultipleQuestion { get; set; }

        public User User { get; set; }

        //public List<ExamQuestion> ExamQuestions { get; set; }
        //public List<ExamStudent> ExamStudents { get; set; }
    }
}
