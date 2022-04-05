﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class CourseVote
    {
        [Key]
        public int VoteId { get; set; }
        [Required]
        public int CourseId { get; set; }

        public int? UserId { get; set; }
        [Required]
        public bool Vote { get; set; }
        public DateTime VoteDate { get; set; } = DateTime.Now;


        public User User { get; set; }
        public Course Course { get; set; }
    }
}
