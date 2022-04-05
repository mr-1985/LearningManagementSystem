using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class Agent
    {
        [Key]
        public int AgentId { get; set; }

        public int UserId { get; set; }
        public float Percent { get; set; }

        [MaxLength(100)]
        public string ContractNo { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public bool IsDelete { get; set; }
        public bool IsActive { get; set; }

        [MaxLength(100)]
        public string AgentName { get; set; }

        //public virtual List<Order> Orders { get; set; }
    }
}
