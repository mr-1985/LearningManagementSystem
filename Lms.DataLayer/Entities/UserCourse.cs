using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class UserCourse
    {
        [Key]
        public int UC_Id { get; set; }

        public int? UserId { get; set; }
        public int CourseId { get; set; }
        public bool IsDelete { get; set; }


        public Course Course { get; set; }
        public User User { get; set; }
    }
}
