using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.ViewModels;

namespace Lms.Core.Services.Interfaces
{
    public interface IVirtualClasses
    {
        MyVirtualClassViewModel GetVirtualClassesById(int PageId = 1, int take = 10, string filter = "", int teacherCourseId = 0);
    }
}
