using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class TeacherCourse
    {
        public int Id { get; set; }
        public long? TeacherId { get; set; }
        public int? CourseId { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual List<StudentCourse> StudentCourses { get; set; }
    }
}
