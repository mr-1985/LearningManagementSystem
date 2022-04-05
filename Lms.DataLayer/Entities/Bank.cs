using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.DataLayer.Entities
{
    public class Bank
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BankId { get; set; }

        [Required]
        [MaxLength(200)]
        public string BankName { get; set; }

        public double BasePricePercent { get; set; }
        public double? SixPercent { get; set; }
        public double? TowelvePercent { get; set; }
        public double? EighteenPercent { get; set; }
        public double? TowntyFourPercent { get; set; }
        public double? SixPercentOperation { get; set; }
        public double? TowelvePercentOperation { get; set; }
        public double? EighteenPercentOperation { get; set; }
        public double? TowntyFourPercentOperation { get; set; }

        //public virtual List<Order> Orders { get; set; }
    }
}
