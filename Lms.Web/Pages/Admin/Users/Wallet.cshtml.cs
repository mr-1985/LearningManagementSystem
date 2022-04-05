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
    public class WalletModel : PageModel
    {
        private IUserService _userService;

        public WalletModel(IUserService userService)
        {
            _userService = userService;
        }

        //public List<WalletViewModel> WalletViewModel { get; set; }

        [BindProperty]
        public ChargeWalletViewModel ChargeWalletViewModel { get; set; }

        public void OnGet()
        {
            ViewData["WalletViewModel"] = _userService.GetWalletUser(User.Identity.Name);
        }

        public IActionResult OnPost(int Amount)
        {
            if (!ModelState.IsValid)
            {
                ViewData["WalletViewModel"] = _userService.GetWalletUser(User.Identity.Name);
                return Page();
            }


            int walletId = _userService.ChargeWallet(User.Identity.Name, Amount, "شارژ حساب");

            #region Online Payment

            var payment = new ZarinpalSandbox.Payment(Amount);

            var res = payment.PaymentRequest("شارژ کیف پول", "https://localhost:44399/OnlinePayment/" + walletId, "m.roueintan518@gmail.com", "09309029454");

            if (res.Result.Status == 100)
            {
                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }

            #endregion

            return null;
        }
    }
}
