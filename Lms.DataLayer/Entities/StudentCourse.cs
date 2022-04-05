using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class StudentCourse
    {
        [Key]
        public int Id { get; set; }
        public long? StudentId { get; set; }
        public int TeacherCourseId { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }

        public virtual TeacherCourse TeacherCourse { get; set; }
    }
}
