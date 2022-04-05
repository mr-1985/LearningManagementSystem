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
    public class ProfileModel : PageModel
    {
        private IUserService _userService;

        public ProfileModel(IUserService userService)
        {
            _userService = userService;
        }

        public InformationUserPanelViewModel Information { get; set; }
        public void OnGet()
        {
            Information = _userService.GetUserPanelInformation(User.Identity.Name);
        }
    }
}
