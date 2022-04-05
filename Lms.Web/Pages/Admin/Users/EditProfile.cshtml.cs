using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Users
{
    public class EditProfileModel : PageModel
    {
        private IUserService _userService;

        public EditProfileModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public EditProfileViewModel EditProfileViewModel { get; set; }
        public void OnGet()
        {
            EditProfileViewModel = _userService.GetDataForEditProfileUser(User.Identity.Name);
        }

        public IActionResult OnPost(EditProfileViewModel editProfile)
        {
            if (!ModelState.IsValid)
                return Page();

            _userService.EditProfile(User.Identity.Name, editProfile);

            //Log Out User
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("/Login?EditProfile=true");
        }
    }
}
