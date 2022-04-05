using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class UserScore
    {
        [Key]
        public int ScoreId { get; set; }

        
        public int? ExamId { get; set; }

        
        public int UserId { get; set; }

        public int Score { get; set; }

        [MaxLength(500)]
        public string TeacherComment { get; set; }
        public DateTime CorrectionDate { get; set; }

        public User User { get; set; }
        public Exam Exam { get; set; }
    }
}
