using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class VirtualClassFile
    {
        [Key]
        public int Id { get; set; }

        public int VcId { get; set; }

        [MaxLength(250)]
        public string FileName { get; set; }

        public double? FileSize { get; set; }
        public int? FileType { get; set; }

        public virtual VirtualClass Vc { get; set; }
    }
}
