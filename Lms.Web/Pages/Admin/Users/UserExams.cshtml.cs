using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Users
{
    public class UserExamsModel : PageModel
    {
        private IExamService _examService;
        private IUserService _userService;

        public UserExamsModel(IExamService examService, IUserService userService)
        {
            _examService = examService;
            _userService = userService;
        }
        

        public List<ExamStudent> ExamStudent { get; set; }
        public void OnGet()
        {
            var userId = _userService.GetUserIdByUserName(User.Identity.Name);
            ExamStudent = _examService.GetUserExams(userId);
        }
    }
}
