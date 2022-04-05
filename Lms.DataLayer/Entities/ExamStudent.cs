using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class ExamStudent
    {
        [Key]
        public int ES_Id { get; set; }

       
        public int? UserId { get; set; }

        [Required]
        public int ExamId { get; set; }
        public bool IsDelete { get; set; }

        [ForeignKey("ExamId")]
        public Exam Exam { get; set; }


        public User User { get; set; }
    }
}
