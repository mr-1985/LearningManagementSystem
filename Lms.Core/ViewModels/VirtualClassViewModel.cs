using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Core.ViewModels
{
    public class VirtualClassListViewModel
    {
        public int VCId { get; set; }
        public string Title { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ClassStatus { get; set; }
    }

    public class MyVirtualClassViewModel
    {
        public List<VirtualClassListViewModel> VirtualClass { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int ClassCounts { get; set; }
    }
}
