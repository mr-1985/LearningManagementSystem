using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lms.Core.Services.Interfaces;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lms.Web.Pages.Admin.MyOrders
{
    public class ShowOrderModel : PageModel
    {
        private IOrderService _orderService;

        public ShowOrderModel(IOrderService orderService)
        {
            _orderService = orderService;
        }

        
        public Order Order { get; set; }
        public void OnGet(int id, bool finaly = false, string type = "")
        {
            Order = _orderService.GetOrderForUserPanel(User.Identity.Name, id);

            //if (order == null)
            //{
            //    return NotFound();
            //}

            ViewData["typeDiscount"] = type;
            ViewData["finaly"] = finaly;
        }
    }
}
