using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.Convertors;
using Lms.Core.Security;
using Lms.Core.Services.Interfaces;
using Lms.Core.ViewModels;
using Lms.Core.ViewModels.Order;
using Lms.DataLayer.Context;
using Lms.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lms.Core.Services
{
    public class OrderService : IOrderService
    {
        private LmsContext _context;
        private IUserService _userService;
        private IPermissionService _permissionService;

        public OrderService(LmsContext context, IUserService userService, IPermissionService permissionService)
        {
            _context = context;
            _userService = userService;
            _permissionService = permissionService;
        }
        public int CalCulatePriceForReceipt(int price, int bankId, int installmentCount)
        {
            var finalPrice = 0;
            var bank = GetBankById(bankId);
            if (installmentCount == 6)
            {
                finalPrice = Convert.ToInt32(((bank.SixPercentOperation / 100) * 6 * price) + price);
            }
            if (installmentCount == 12)
            {
                finalPrice = Convert.ToInt32(((bank.TowelvePercentOperation / 100) * 12 * price) + price);
            }
            if (installmentCount == 18)
            {
                finalPrice = Convert.ToInt32(((bank.EighteenPercentOperation / 100) * 18 * price) + price);
            }
            if (installmentCount == 24)
            {
                finalPrice = Convert.ToInt32(((bank.TowntyFourPercentOperation / 100) * 24 * price) + price);
            }
            return finalPrice;
        }

        public Agent GetAgentByUserId(int userId)
        {
            return _context.Agents.SingleOrDefault(u => u.UserId == userId);

        }

        public Bank GetBankById(int bankId)
        {
            return _context.Banks.SingleOrDefault(u => u.BankId == bankId);
        }

        //public OrderDetailPrintViewModel GetOrderDetailPrint(int orderId)
        //{

        //    var lstproductdetail = _context.OrderDetails.Where(u => u.OrderId == orderId)
        //        .Select(u => new OrderDetailViewModel()
        //        {

        //            Count = Convert.ToInt32(u.Count),
        //            ProductPrice = Convert.ToInt32(u.ProductPrice),
        //            ProductName = u.ProductName

        //        }).ToList();

        //    var query = from o in _context.Orders
        //                join u in _context.Users
        //                    on o.UserId equals u.UserId
        //                join c in _context.Cities
        //                    on u.CityId equals c.CityId
        //                join p in _context.Provinces
        //                   on c.ProvinceId equals p.ProvinceId
        //                join e in _context.Educations
        //                    on u.EducationId equals e.Id
        //                join l in _context.LocationStatuses
        //                    on u.LocationStatusId equals l.Id
        //                where o.OrderId == orderId
        //                select (new OrderDetailPrintViewModel()
        //                {
        //                    Mobile = u.Mobile,
        //                    Address = u.Address,
        //                    BirthDate = DateConvertor.ToShamsi(u.BirthDate).ToString(),
        //                    OrderDate = DateConvertor.ToShamsi(o.CreateDate).ToString(),
        //                    CheckDistance = Convert.ToInt32(o.CheckDistance),
        //                    CityName = c.CityName,
        //                    CodeBimeh = u.CodeBimeh,
        //                    CodePosti = u.CodePosti,
        //                    EducationTitle = e.Title,
        //                    FatherName = u.FatherName,
        //                    FirstName = u.FirstName,
        //                    ShomarehShenasnameh = u.ShomarehShenasnameh,
        //                    Sex = Convert.ToInt32(u.Sex) == 0 ? "زن" : "مرد",
        //                    MaritalStatus = Convert.ToInt32(u.MaritalStatus) == 0 ? "مجرد" : "متاهل",
        //                    NationalCode = u.NationalCode,
        //                    Tell = u.Tell,
        //                    MahaleSodooreShenasnameh = u.MahaleSodooreShenasnameh,
        //                    SabegheKar = Convert.ToInt32(u.SabegheKar),
        //                    SalaryPerMonth = Convert.ToInt32(u.SalaryPerMonth),
        //                    Job = u.Job,
        //                    InstallmentCount = o.InstallmentCount,
        //                    JobAddress = u.JobAddress,
        //                    JobTell = u.JobTell,
        //                    LastName = u.LastName,
        //                    LocationTitle = l.Title,
        //                    Price = o.Price,
        //                    ProvinceName = p.ProvinceName,
        //                    RegionalMunicipality = u.RegionalMunicipality,
        //                    SerialeShenasnameh = u.SerialeShenasnameh,
        //                    WomanSalary = Convert.ToInt32(u.WomanSalary),
        //                    products = lstproductdetail
        //                     ,
        //                    PricePrintSeprate = String.Format("{0:n0}", o.Price),
        //                    AghsatPrice = String.Format("{0:n0}", (o.Price / o.InstallmentCount)),
        //                    SarresidDate = DateConvertor.ToShamsi(o.CreateDate.AddDays(30)).ToString()


        //                });
        //    var t = query.FirstOrDefault();
        //    return query.FirstOrDefault();


        //}

        //public OrdersListViewModel GetOrdersList(int PageId = 1, int take = 10, string filter = "", int userId = 0)
        //{

        //    var result = from o in _context.Orders
        //                 join u in _context.Users
        //                     on o.UserId equals u.UserId
        //                 join c in _context.Cities
        //                     on u.CityId equals c.CityId
        //                 join p in _context.Provinces
        //                     on c.ProvinceId equals p.ProvinceId
        //                 join a in _context.Agents
        //                     on o.AgentId equals a.AgentId
        //                 where a.UserId == userId
        //                 select (new OrdersListAdminViewModel()
        //                 {
        //                     Mobile = u.Mobile,
        //                     FirstName = u.FirstName,
        //                     LastName = u.LastName,
        //                     OrderDate = o.CreateDate,
        //                     Price = o.Price,
        //                     CityName = c.CityName,
        //                     ProvinceName = p.ProvinceName,
        //                     AgentFirstName = "",
        //                     AgentLastName = "",
        //                     AgentName = a.AgentName,
        //                     InstallmentCount = o.InstallmentCount,
        //                     NationalCode = u.NationalCode,
        //                     OrderId = o.OrderId


        //                 });
        //    if (!string.IsNullOrEmpty(filter))
        //    {
        //        result = from o in _context.Orders
        //                 join u in _context.Users
        //                     on o.UserId equals u.UserId
        //                 join c in _context.Cities
        //                     on u.CityId equals c.CityId
        //                 join p in _context.Provinces
        //                     on c.ProvinceId equals p.ProvinceId
        //                 join a in _context.Agents
        //                     on o.AgentId equals a.AgentId
        //                 where (p.ProvinceName.Contains(filter) ||
        //                       c.CityName.Contains(filter) ||
        //                       u.FirstName.Contains(filter) ||
        //                       u.LastName.Contains(filter) ||
        //                       u.NationalCode.Contains(filter) ||
        //                       u.Mobile.Contains(filter) ||
        //                       o.Price.ToString().Contains(filter) ||
        //                       a.AgentName.Contains(filter)) &&
        //                       (a.UserId == userId)
        //                 select (new OrdersListAdminViewModel()
        //                 {
        //                     Mobile = u.Mobile,
        //                     FirstName = u.FirstName,
        //                     LastName = u.LastName,
        //                     OrderDate = o.CreateDate,
        //                     Price = o.Price,
        //                     CityName = c.CityName,
        //                     ProvinceName = p.ProvinceName,
        //                     AgentFirstName = "",
        //                     AgentLastName = "",
        //                     AgentName = a.AgentName,
        //                     InstallmentCount = o.InstallmentCount,
        //                     NationalCode = u.NationalCode,
        //                     OrderId = o.OrderId


        //                 });
        //    }



        //    int takeDate = take;
        //    int skip = (PageId - 1) * takeDate;
        //    OrdersListViewModel list = new OrdersListViewModel();
        //    list.CurrentPage = PageId;
        //    list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
        //    //    list.Orders = result.OrderByDescending(u => u.OrderDate).Skip(skip).Take(takeDate).ToList();
        //    list.Orders = result.OrderByDescending(o => o.OrderDate).Skip(skip).Take(takeDate).ToList();
        //    list.OrderCounts = result.Count();
        //    return list;
        //}
        //public OrdersListViewModel GetOrdersListAdmin(int PageId = 1, int take = 10, string filter = "", int userId = 0)
        //{

        //    var result = from o in _context.Orders
        //                 join u in _context.Users
        //                     on o.UserId equals u.UserId
        //                 join c in _context.Cities
        //                     on u.CityId equals c.CityId
        //                 join p in _context.Provinces
        //                     on c.ProvinceId equals p.ProvinceId
        //                 join a in _context.Agents
        //                     on o.AgentId equals a.AgentId

        //                 select (new OrdersListAdminViewModel()
        //                 {
        //                     Mobile = u.Mobile,
        //                     FirstName = u.FirstName,
        //                     LastName = u.LastName,
        //                     OrderDate = o.CreateDate,
        //                     Price = o.Price,
        //                     CityName = c.CityName,
        //                     ProvinceName = p.ProvinceName,
        //                     AgentFirstName = "",
        //                     AgentLastName = "",
        //                     AgentName = a.AgentName,
        //                     InstallmentCount = o.InstallmentCount,
        //                     NationalCode = u.NationalCode,
        //                     OrderId = o.OrderId


        //                 });
        //    if (!string.IsNullOrEmpty(filter))
        //    {
        //        result = from o in _context.Orders
        //                 join u in _context.Users
        //                     on o.UserId equals u.UserId
        //                 join c in _context.Cities
        //                     on u.CityId equals c.CityId
        //                 join p in _context.Provinces
        //                     on c.ProvinceId equals p.ProvinceId
        //                 join a in _context.Agents
        //                     on o.AgentId equals a.AgentId
        //                 where (p.ProvinceName.Contains(filter) ||
        //                       c.CityName.Contains(filter) ||
        //                       u.FirstName.Contains(filter) ||
        //                       u.LastName.Contains(filter) ||
        //                       u.NationalCode.Contains(filter) ||
        //                       u.Mobile.Contains(filter) ||
        //                       o.Price.ToString().Contains(filter) ||
        //                       a.AgentName.Contains(filter))
        //                 select (new OrdersListAdminViewModel()
        //                 {
        //                     Mobile = u.Mobile,
        //                     FirstName = u.FirstName,
        //                     LastName = u.LastName,
        //                     OrderDate = o.CreateDate,
        //                     Price = o.Price,
        //                     CityName = c.CityName,
        //                     ProvinceName = p.ProvinceName,
        //                     AgentFirstName = "",
        //                     AgentLastName = "",
        //                     AgentName = a.AgentName,
        //                     InstallmentCount = o.InstallmentCount,
        //                     NationalCode = u.NationalCode,
        //                     OrderId = o.OrderId


        //                 });
        //    }



        //    int takeDate = take;
        //    int skip = (PageId - 1) * takeDate;
        //    OrdersListViewModel list = new OrdersListViewModel();
        //    list.CurrentPage = PageId;
        //    list.PageCount = (int)Math.Ceiling(result.Count() / (double)takeDate);
        //    //    list.Orders = result.OrderByDescending(u => u.OrderDate).Skip(skip).Take(takeDate).ToList();
        //    list.Orders = result.OrderByDescending(o => o.OrderDate).Skip(skip).Take(takeDate).ToList();
        //    list.OrderCounts = result.Count();
        //    return list;
        //}

        public bool IsUserInCourse(string userName, int courseId)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            return _context.UserCourses.Any(c => c.UserId == userId && c.CourseId == courseId && c.IsDelete == false);
        }

        public int AddOrder(string userName, int courseId)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            Order order = _context.Orders
                .FirstOrDefault(o => o.UserId == userId && !o.IsFinaly);

            var course = _context.Courses.Find(courseId);

            if (order == null)
            {
                order = new Order()
                {
                    UserId = userId,
                    IsFinaly = false,
                    CreateDate = DateTime.Now,
                    OrderSum = course.CoursePrice,
                    OrderDetails = new List<OrderDetail>()
                    {
                        new OrderDetail()
                        {
                            CourseId = courseId,
                            Count = 1,
                            Price = course.CoursePrice
                        }
                    }
                };
                _context.Orders.Add(order);
                _context.SaveChanges();
            }
            else
            {
                OrderDetail detail = _context.OrderDetails
                    .FirstOrDefault(d => d.OrderId == order.OrderId && d.CourseId == courseId);
                if (detail != null)
                {
                    detail.Count += 1;
                    _context.OrderDetails.Update(detail);
                }
                else
                {
                    detail = new OrderDetail()
                    {
                        OrderId = order.OrderId,
                        Count = 1,
                        CourseId = courseId,
                        Price = course.CoursePrice,
                    };
                    _context.OrderDetails.Add(detail);
                }

                _context.SaveChanges();
                UpdatePriceOrder(order.OrderId);
            }
            return order.OrderId;
        }

        public void UpdatePriceOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            order.OrderSum = _context.OrderDetails.Where(d => d.OrderId == orderId).Sum(d => d.Price*d.Count);
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public Order GetOrderForUserPanel(string userName, int orderId)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            return
                _context.Orders.Include(o => o.OrderDetails).
                    ThenInclude(od => od.Course)
                .FirstOrDefault(o => o.UserId == userId && o.OrderId == orderId);
        }

        public bool FinalyOrder(string userName, int orderId)
        {
            int userId = _userService.GetUserIdByUserName(userName);
            var order = _context.Orders.Include(o => o.OrderDetails).ThenInclude(od => od.Course)
                .FirstOrDefault(o => o.OrderId == orderId && o.UserId == userId);

            if (order == null || order.IsFinaly)
            {
                return false;
            }

            if (_userService.BalanceUserWallet(userName) >= order.OrderSum)
            {
                order.IsFinaly = true;
                _userService.AddWallet(new Wallet()
                {
                    Amount = order.OrderSum,
                    CreateDate = DateTime.Now,
                    IsPay = true,
                    Description = "فاکتور شما #" + order.OrderId,
                    UserId = userId,
                    TypeId = 2
                });
                _context.Orders.Update(order);

                foreach (var detail in order.OrderDetails)
                {
                    _context.UserCourses.Add(new UserCourse()
                    {
                        CourseId =(int) detail.CourseId,
                        UserId = userId
                    });
                }

                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public List<Order> GetUserOrders(string userName)
        {
            int userId = _userService.GetUserIdByUserName(userName);

            return _context.Orders.Where(o => o.UserId == userId).ToList();
        }

        public bool IsExistCode(string code)
        {
            return _context.Discounts.Any(d => d.DiscountCode == code);
        }

        public void AddDiscount(Discount discount)
        {
            _context.Discounts.Add(discount);
            _context.SaveChanges();
        }

        public Discount GetDiscountById(int discountId)
        {
            return _context.Discounts.Find(discountId);
        }

        public void UpdateDiscount(Discount discount)
        {
            _context.Discounts.Update(discount);
            _context.SaveChanges();
        }

        public List<Discount> GetAllDiscounts()
        {
            return _context.Discounts.ToList();
        }

        public DiscountUseType UseDiscount(int orderId, string code)
        {
            var discount = _context.Discounts.SingleOrDefault(d => d.DiscountCode == code);

            if (discount == null)
                return DiscountUseType.NotFound;

            if (discount.StartDate != null &&!(discount.StartDate < DateTime.Now))
                return DiscountUseType.ExpierDate;

            if (discount.EndDate != null && !(discount.EndDate >= DateTime.Now))
                return DiscountUseType.ExpierDate;

            if (discount.UsableCount != null && discount.UsableCount < 1)
                return DiscountUseType.Finished;

            var order = GetOrderById(orderId);

            if (_context.UserDiscountCodes.Any(d => d.UserId == order.UserId && d.DiscountId == discount.DiscountId))
                return DiscountUseType.UserUsed;

            int percent = (order.OrderSum * discount.DiscountPercent) / 100;
            order.OrderSum = order.OrderSum - percent;

            UpdateOrder(order);

            if (discount.UsableCount != null)
            {
                discount.UsableCount -= 1;
            }

            _context.Discounts.Update(discount);
            _context.UserDiscountCodes.Add(new UserDiscountCode()
            {
                UserId = order.UserId,
                DiscountId = discount.DiscountId
            });
            _context.SaveChanges();



            return DiscountUseType.Success;
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        //public long InsertOrder(Order order)
        //{
        //    _context.Orders.Add(order);
        //    _context.SaveChanges();
        //    return order.OrderId;
        //}

        //public long InsertOrderdetail(OrderDetail orderDetail)
        //{
        //    _context.OrderDetails.Add(orderDetail);
        //    _context.SaveChanges();
        //    return orderDetail.Id;
        //}

        //public void InsertOrderdetail(List<OrderDetailViewModel> orderDetailViewModels)
        //{

        //    foreach (var item in orderDetailViewModels)
        //    {
        //        OrderDetail orderDetail = new OrderDetail();
        //        orderDetail.OrderId = item.OrderId;
        //        orderDetail.ProductName = item.ProductName;
        //        orderDetail.ProductPrice = item.ProductPrice;
        //        orderDetail.Count = item.Count;
        //        _context.OrderDetails.Add(orderDetail);
        //    }

        //    _context.SaveChanges();

        //}

        public long InsertUserOrder(CreateUserOrderViewModel userOrderViewModel)
        {

            User user = new User()
            {
                ActivationCode = "",
                Address = userOrderViewModel.Address,
                BirthDate = userOrderViewModel.BirthDate,
                CityId = userOrderViewModel.CityId,
                CodeBimeh = userOrderViewModel.CodeBimeh,
                CodePosti = userOrderViewModel.CodePosti,
                CreateDate = DateTime.Now,
                EducationId = userOrderViewModel.EducationId,
                Email = "",
                FatherName = userOrderViewModel.FatherName,
                FirstName = userOrderViewModel.FirstName,
                IsActive = true,
                IsDelete = false,
                Job = userOrderViewModel.Job,
                JobAddress = userOrderViewModel.JobAddress,
                JobTell = userOrderViewModel.JobTell,
                LastName = userOrderViewModel.LastName,
                LocationStatusId = userOrderViewModel.LocationStatusId,
                MahaleSodooreShenasnameh = userOrderViewModel.MahaleSodooreShenasnameh,
                MaritalStatus = userOrderViewModel.MaritalStatus,
                Mobile = userOrderViewModel.Mobile,
                NationalCode = userOrderViewModel.NationalCode,
                Password = PasswordHelper.EncodePasswordMd5(userOrderViewModel.Mobile),
                SabegheKar = userOrderViewModel.SabegheKar,
                SalaryPerMonth = userOrderViewModel.SalaryPerMonth,
                SerialeShenasnameh = userOrderViewModel.SerialeShenasnameh,
                Sex = userOrderViewModel.Sex,
                ShomarehShenasnameh = userOrderViewModel.ShomarehShenasnameh,
                Tell = userOrderViewModel.Tell,
                UserAvatar = "default.png",
                UserName = userOrderViewModel.Mobile,
                RegionalMunicipality = userOrderViewModel.RegionalMunicipality


            };
            if (_userService.IsExistUserName(userOrderViewModel.Mobile))
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                return user.UserId;
            }
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }
    }
}
