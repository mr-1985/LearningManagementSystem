using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class VirtualClass
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public long CreatorUserId { get; set; }

        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        public DateTime OpeningDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ExtraTime { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public bool? IsPrerequisite { get; set; }


        #region Relations

        public virtual Course Course { get; set; }
        public virtual List<VirtualClassFile> VirtualClassFiles { get; set; }

        #endregion
    }
}
