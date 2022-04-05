using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class UserStatus
    {
        [Key]
        public int ExamStatusId { get; set; }

        [Required]
        [MaxLength(150)]
        public string ExamStatusTitle { get; set; }

    }
}
