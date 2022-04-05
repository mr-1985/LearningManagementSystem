using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.Core.Convertors;

namespace Lms.Core.ViewModels
{
    public class CreateUserOrderViewModel
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string LastName { get; set; }

        public string UserName { get; set; }

        [Display(Name = "کد ملی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        [IsValidIranianNationalCode(ErrorMessage = "کد ملی وارد شده معتبر نمی باشد")]
        [RegularExpression("([0-9]+)", ErrorMessage = "لطفا تنها عدد وارد نمایید")]
        public string NationalCode { get; set; }

        [Display(Name = "شماره شناسنامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "لطفا تنها عدد وارد نمایید")]
        public string ShomarehShenasnameh { get; set; }

        [Display(Name = "تلفن ثابت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(11, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "لطفا تنها عدد وارد نمایید")]
        public string Tell { get; set; }

        [Display(Name = "سریال شناسنامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string SerialeShenasnameh { get; set; }

        public DateTime BirthDate { get; set; }

        [Display(Name = "کد شهر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int CityId { get; set; }

        [Display(Name = "آدرس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string Address { get; set; }

        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(11, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "لطفا تنها عدد وارد نمایید")]
        public string Mobile { get; set; }

        public int? EducationId { get; set; }
        public int? LocationStatusId { get; set; }
        public int? Sex { get; set; }

        [Display(Name = "محل صدور شناسنامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string MahaleSodooreShenasnameh { get; set; }

        [Display(Name = "کد پستی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(10, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "لطفا تنها عدد وارد نمایید")]
        public string CodePosti { get; set; }

        [Display(Name = "نام پدر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string FatherName { get; set; }

        public int? MaritalStatus { get; set; }

        [Display(Name = "سابقه کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [RegularExpression("([0-9]+)", ErrorMessage = "لطفا تنها عدد وارد نمایید")]
        public int? SabegheKar { get; set; }

        [Display(Name = "کد بیمه ")]
        [RegularExpression("([0-9]+)", ErrorMessage = "لطفا تنها عدد وارد نمایید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string CodeBimeh { get; set; }

        [Display(Name = "درآمد ماهیانه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int? SalaryPerMonth { get; set; }

        [Display(Name = "درآمد ماهیانه همسر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [RegularExpression("([0-9]+)", ErrorMessage = "لطفا تنها عدد وارد نمایید")]
        public int? WomanSalary { get; set; }

        [Display(Name = "شغل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string Job { get; set; }

        [Display(Name = "آدرس محل کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string JobAddress { get; set; }

        [Display(Name = "تلفن محل کار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(11, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "لطفا تنها عدد وارد نمایید")]
        //[StringLengthRange(Minimum = 10,Maximum =10, ErrorMessage = "کد ملی معتبر نمی باشد")]
        public string JobTell { get; set; }

        [Display(Name = "منطقه شهرداري محل سکونت:")]
        public string RegionalMunicipality { get; set; }

    }

    public class OrderCalPriceViewModel
    {
        public double SixPercentOperation { get; set; }
        public double TowelvePercentOperation { get; set; }
        public double EighteenPercentOperation { get; set; }
        public double TowntyFourPercentOperation { get; set; }
    }
    public class OrdersListViewModel
    {
        public List<OrdersListAdminViewModel> Orders { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int OrderCounts { get; set; }
    }
    public class OrderMainViewModel
    {
        public long OrderId { get; set; }
        public int BankId { get; set; }
        public int InstallmentCount { get; set; }
        public int Price { get; set; }
        public int AgentId { get; set; }
        public long UserId { get; set; }
        public double? AgentPercent { get; set; }
        public string TransactionNo { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CheckDistance { get; set; }
        public double? BankPercent { get; set; }
    }

    public class OrderDetailViewModel
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public long OrderId { get; set; }
        public int Count { get; set; }
    }

    public class OrderDetailPrintViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string ShomarehShenasnameh { get; set; }
        public string Tell { get; set; }
        public string SerialeShenasnameh { get; set; }
        public string BirthDate { get; set; }
        public string OrderDate { get; set; }
        public string CityName { get; set; }
        public string ProvinceName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string EducationTitle { get; set; }
        public string LocationTitle { get; set; }
        public string Sex { get; set; }
        public string MahaleSodooreShenasnameh { get; set; }
        public string CodePosti { get; set; }
        public string FatherName { get; set; }
        public string MaritalStatus { get; set; }
        public int SabegheKar { get; set; }
        public string CodeBimeh { get; set; }
        public int SalaryPerMonth { get; set; }
        public int WomanSalary { get; set; }
        public string Job { get; set; }
        public string JobAddress { get; set; }
        public string JobTell { get; set; }
        public string RegionalMunicipality { get; set; }
        public int Price { get; set; }
        public string PricePrintSeprate { get; set; }
        public int CheckDistance { get; set; }
        public int InstallmentCount { get; set; }
        public string AghsatPrice { get; set; }
        public string SarresidDate { get; set; }
        public List<OrderDetailViewModel> products { get; set; }
    }
    public class OrdersListAdminViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string CityName { get; set; }
        public string ProvinceName { get; set; }
        public string Mobile { get; set; }
        public string AgentName { get; set; }
        public string AgentFirstName { get; set; }
        public long OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string AgentLastName { get; set; }
        public int Price { get; set; }
        public int InstallmentCount { get; set; }
    }
}
