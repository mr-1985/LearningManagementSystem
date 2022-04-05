using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Convertors;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.Users
{
    public class CreateUserModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _permissionService;

        public CreateUserModel(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }

        [BindProperty]
        public UserViewModel.CreateUserViewModel CreateUserViewModel { get; set; }
        public void OnGet()
        {
            ViewData["Roles"] = _permissionService.GetRoles();
        }

        public IActionResult OnPost(List<int> selectedRoles)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Roles"] = _permissionService.GetRoles();
                return Page();
            }

            if (_userService.IsExistUserName(FixedText.SkipLetter(CreateUserViewModel.UserName)))
            {
                ModelState.AddModelError("CreateUserViewModel.UserName", "نام کاربری وارد شده تکراری می باشد");
                ViewData["Roles"] = _permissionService.GetFilterRoles(3);
                return Page();
            }

            if (_userService.IsExistMobile(CreateUserViewModel.Mobile))
            {
                ModelState.AddModelError("CreateUserViewModel.Mobile", "شماره موبایل وارد شده تکراری می باشد");
                ViewData["Roles"] = _permissionService.GetFilterRoles(3);
                return Page();
            }

            int userId = _userService.AddUserFromAdmin(CreateUserViewModel);
            _permissionService.AddRolesToUser(selectedRoles, userId);

            return RedirectToPage("Index");
        }
    }
}
