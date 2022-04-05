using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class QuestionLevel
    {
        [Key]
        public int LevelId { get; set; }

        [Required]
        [MaxLength(150)]
        public string LevelTitle { get; set; }

        public List<MultipleQuestion> MultipleQuestions { get; set; }
    }
}
