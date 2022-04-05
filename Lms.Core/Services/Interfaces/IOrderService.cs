using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.ViewModels;
using Lms.Core.ViewModels.Order;
using Lms.DataLayer.Entities;

namespace Lms.Core.Services.Interfaces
{
   public interface IOrderService
    {
        int CalCulatePriceForReceipt(int price, int bankId, int installmentCount);
        //long InsertOrder(Order order);
        Agent GetAgentByUserId(int userId);
        Bank GetBankById(int bankId);
        //long InsertUserOrder(CreateUserOrderViewModel userOrderViewModel);
        //long InsertOrderdetail(OrderDetail orderDetail);
        //void InsertOrderdetail(List<OrderDetailViewModel> orderDetailViewModels);
        //OrderDetailPrintViewModel GetOrderDetailPrint(int orderId);
        //OrdersListViewModel GetOrdersList(int PageId = 1, int take = 10, string filter = "", int userId = 0);
        //OrdersListViewModel GetOrdersListAdmin(int PageId = 1, int take = 10, string filter = "", int userId = 0);
        bool IsUserInCourse(string userName, int courseId);
        int AddOrder(string userName, int courseId);
        void UpdatePriceOrder(int orderId);
        Order GetOrderForUserPanel(string userName, int orderId);
        bool FinalyOrder(string userName, int orderId);
        List<Order> GetUserOrders(string userName);
        bool IsExistCode(string code);
        void AddDiscount(Discount discount);
        Discount GetDiscountById(int discountId);
        void UpdateDiscount(Discount discount);
        List<Discount> GetAllDiscounts();
        DiscountUseType UseDiscount(int orderId, string code);
        Order GetOrderById(int orderId);
        void UpdateOrder(Order order);

    }
}
