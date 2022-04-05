using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.MyOrders
{
    public class FinalyOrderModel : PageModel
    {
        private IOrderService _orderService;

        public FinalyOrderModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult OnGet(int id)
        {
            if (_orderService.FinalyOrder(User.Identity.Name, id))
            {
                return Redirect("/Admin/MyOrders/ShowOrder/" + id + "?finaly=true");
            }

            return BadRequest();
        }
    }
}
