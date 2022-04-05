using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Core.ViewModels
{
    public class BankViewModel
    {
        public int BankId { get; set; }
        public float PercentSixMonth { get; set; }
        public float PercentTowelveMonth { get; set; }
        public float PercentEighteenMonth { get; set; }
        public float PercenttowntyFourMonth { get; set; }
        public string BankName { get; set; }
    }
}
