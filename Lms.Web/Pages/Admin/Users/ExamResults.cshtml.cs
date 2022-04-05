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
    public class ExamResultsModel : PageModel
    {
        private IExamService _examService;
        private IUserService _userService;

        public ExamResultsModel(IExamService examService, IUserService userService)
        {
            _examService = examService;
            _userService = userService;
        }

        public List<UserScore> UserScore { get; set; }
        public void OnGet()
        {
            var userId = _userService.GetUserIdByUserName(User.Identity.Name);
            UserScore = _examService.GetUserExamResults(userId);
        }
    }
}
