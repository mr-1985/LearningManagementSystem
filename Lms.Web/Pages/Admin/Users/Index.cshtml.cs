using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Users
{
    public class IndexModel : PageModel
    {
        private IUserService _userService;

        public IndexModel(IUserService userService)
        {
            _userService = userService;
        }

        public List<UserViewModel.UserForAdminListPageViewModel> UserForAdminListPageViewModel { get; set; }
        public UserViewModel.UserForAdminViewModel UserForAdminViewModel { get; set; }
        public void OnGet(int PageId = 1, int take = 1, string filter = "")
        {
            if (PageId > 1)
            {
                ViewData["Take"] = (PageId - 1) * take + 1;
            }
            else
            {
                ViewData["Take"] = take;
            }

            ViewData["Filter"] = filter;

            ViewData["PageID"] = (PageId - 1) * take + 1;
            UserForAdminListPageViewModel = _userService.GetUsers(PageId, take, filter).Item1;
            UserForAdminViewModel = _userService.GetUsers(PageId, take, filter).Item2;
        }
    }
}
