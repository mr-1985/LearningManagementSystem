﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class CourseComment
    {
        [Key]
        public int CommentId { get; set; }
        public int CourseId { get; set; }
        public int? UserId { get; set; }

        [MaxLength(700)]
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
        public bool IsAdminRead { get; set; }


        public Course Course { get; set; }
        public User User { get; set; }
    }
}
