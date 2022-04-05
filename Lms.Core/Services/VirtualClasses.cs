using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Lms.DataLayer.Context;

namespace Lms.Core.Services
{
    public class VirtualClasses : IVirtualClasses
    {
        private LmsContext _context;

        public VirtualClasses(LmsContext context)
        {
            _context = context;
        }
        public MyVirtualClassViewModel GetVirtualClassesById(int PageId = 1, int take = 10, string filter = "", int teacherCourseId = 0)
        {

            var result = from u in _context.VirtualClasses
                         where (u.CourseId == teacherCourseId)
                         select new VirtualClassListViewModel()
                         {
                             Title = u.Title,
                             EndTime = u.EndTime,
                             OpeningDate = u.OpeningDate,
                             StartTime = u.StartTime,
                             ClassStatus = "",
                             VCId = u.Id
                         };
            if (!string.IsNullOrEmpty(filter))
            {

                result = from u in _context.VirtualClasses
                         where (u.CourseId == teacherCourseId) && (u.Title.Contains(filter))
                         select new VirtualClassListViewModel()
                         {
                             Title = u.Title,
                             EndTime = u.EndTime,
                             OpeningDate = u.OpeningDate,
                             StartTime = u.StartTime,
                             ClassStatus = "",
                             VCId = u.Id
                         };
            }


            int takeDate = take;
            int skip = (PageId - 1) * takeDate;
            MyVirtualClassViewModel list = new MyVirtualClassViewModel();
            list.CurrentPage = PageId;
            list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
            list.VirtualClass = result.OrderByDescending(u => u.VCId).Skip(skip).Take(takeDate).ToList();
            list.ClassCounts = _context.VirtualClasses.Where(c => c.CourseId == teacherCourseId).ToList().Count();
            return list;
        }
    }
}
