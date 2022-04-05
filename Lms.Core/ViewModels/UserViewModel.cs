using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lms.DataLayer.Entities;
using Microsoft.AspNetCore.Http;

namespace Lms.Core.ViewModels
{
    public class UserViewModel
    {
        public class EditUserViewModel
        {
            public int UserId { get; set; }

            [Display(Name = "نام")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string FirstName { get; set; }

            [Display(Name = "نام خانوادگی")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string LastName { get; set; }
            [Display(Name = "ایمیل")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

            [Display(Name = "کلمه عبور")]

            public string Password { get; set; }

            [Display(Name = "موبایل")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string Mobile { get; set; }

            public bool IsActive { get; set; }

            public IFormFile UserAvatar { get; set; }

            public string AvatarName { get; set; }
            public string UserName { get; set; }

            public List<int> UserRoles { get; set; }


        }
        public class EditAgentViewModel
        {
            public int UserId { get; set; }

            [Display(Name = "نام")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string FirstName { get; set; }

            [Display(Name = "نام خانوادگی")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string LastName { get; set; }
            [Display(Name = "ایمیل")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

            [Display(Name = "کلمه عبور")]

            public string Password { get; set; }

            [Display(Name = "موبایل")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string Mobile { get; set; }

            public bool IsActive { get; set; }

            public IFormFile UserAvatar { get; set; }
            public string UserName { get; set; }
            public int ProvinceId { get; set; }

            public int CityId { get; set; }
            public string ContractNo { get; set; }
            public string Description { get; set; }
            [Display(Name = "درصد کارمزد")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]

            public float AgentPercent { get; set; }
            [Display(Name = "نام نمایندگی")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string AgentName { get; set; }
            public string Address { get; set; }
        }

        public class UserForAdminViewModel
        {
            public List<User> Users { get; set; }
            public int CurrentPage { get; set; }
            public int PageCount { get; set; }
            public int UserCounts { get; set; }
        }

        public class AgentForAdminViewModel
        {
            public List<AgentViewModel> Users { get; set; }
            public int CurrentPage { get; set; }
            public int PageCount { get; set; }
            public int UserCounts { get; set; }
        }
        public class UserForAdminListPageViewModel
        {
            public string FirstName { get; set; }
            public string UserAvatar { get; set; }
            public string LastName { get; set; }
            public int UserId { get; set; }
            public string Mobile { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public bool IsActive { get; set; }
            public bool IsDeleted { get; set; }
            public DateTime CreateDate { get; set; }
            public string RoleName { get; set; }
        }

        public class AgentViewModel
        {
            public string FirstName { get; set; }
            public string UserAvatar { get; set; }
            public string LastName { get; set; }
            public int UserId { get; set; }
            public string Mobile { get; set; }
            public string UserName { get; set; }
            public string CityName { get; set; }
            public string ProvinceName { get; set; }
            public bool IsActive { get; set; }
            public string ContractNo { get; set; }
            public string Description { get; set; }
            public float AgentPercent { get; set; }
            public string AgentName { get; set; }
            public DateTime CreateDate { get; set; }
        }

        public class CreateUserViewModel
        {
            [Display(Name = "نام")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string FirstName { get; set; }

            [Display(Name = "نام خانوادگی")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string LastName { get; set; }

            [Display(Name = "ایمیل")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیست")]
            public string Email { get; set; }

            [Display(Name = "کلمه عبور")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string Password { get; set; }

            [Display(Name = "موبایل")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string Mobile { get; set; }
            [Display(Name = "نام کاربری")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string UserName { get; set; }

            public bool IsActive { get; set; }

            public IFormFile UserAvatar { get; set; }

        }
        public class CreateAgentViewModel
        {
            [Display(Name = "نام")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string FirstName { get; set; }

            [Display(Name = "نام خانوادگی")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string LastName { get; set; }

            [Display(Name = "ایمیل")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیست")]
            public string Email { get; set; }

            [Display(Name = "کلمه عبور")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string Password { get; set; }

            [Display(Name = "موبایل")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string Mobile { get; set; }
            [Display(Name = "نام کاربری")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
            public string UserName { get; set; }
            [Display(Name = "نام شهر")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public int CityId { get; set; }
            public bool IsActive { get; set; }
            public string ContractNo { get; set; }
            public string Description { get; set; }
            [Display(Name = "آدرس نمایندگی")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public string Address { get; set; }
            public IFormFile UserAvatar { get; set; }
            [Display(Name = "درصد نمایندگی")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public float AgentPercent { get; set; }
            [Display(Name = "نام نمایندگی")]
            [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
            public string AgentName { get; set; }

        }
    }
}
