using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class ExamQuestion
    {
        [Key]
        public int EQ_Id { get; set; }

        
        public int? QuestionId { get; set; }

        //[Required]
        //public int EQHId { get; set; }

        [Required]
        public int ExamId { get; set; }

        public bool IsDelete { get; set; }


        [ForeignKey("QuestionId")]
        public MultipleQuestion MultipleQuestion { get; set; }

        //[ForeignKey("EQHId")]
        //public QuestionHistory QuestionHistory { get; set; }

        [ForeignKey("ExamId")]
        public Exam Exam { get; set; }
    }
}
