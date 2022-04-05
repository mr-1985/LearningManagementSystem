using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Lms.Core.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string UserName { get; set; }

        [Display(Name = "کلمه عبور ")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string Password { get; set; }

        [Display(Name = "مرا به خاطر بسپار ")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Display(Name = "نام ")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string LastName { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        [Compare("Password", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        public string RePassword { get; set; }
    }

    public class RegisterAgentViewModel
    {
        public int UserId { get; set; }
        [Display(Name = "درصد کارمزد")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(50, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public float Percent { get; set; }

        [Display(Name = "شماره قرارداد")]
        [MaxLength(100, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string ContractNo { get; set; }

        [Display(Name = "توضیحات قرارداد")]
        [MaxLength(1000, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string Description { get; set; }

        public bool IsDelete { get; set; }

        [Display(Name = "نام ")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string FirstName { get; set; }
        [Display(Name = "نام خانوادگی را وارد نمایید")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string LastName { get; set; }
        [Display(Name = "ایمیل")]

        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیسنت")]
        public string Email { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string UserName { get; set; }

        [Display(Name = "کد ملی")]
        [MaxLength(50, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string NationalCode { get; set; }

        [Display(Name = "شماره شناسنامه")]
        [MaxLength(50, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string ShomarehShenasnameh { get; set; }
        [Display(Name = "تلفن ثابت")]
        [MaxLength(50, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string Tell { get; set; }

        [Display(Name = "سریال شناسنامه")]
        [MaxLength(50, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string SerialeShenasnameh { get; set; }

        [Display(Name = "تاریخ تولد")]
        [MaxLength(50, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "کد شهر")]
        [MaxLength(10, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public int CityId { get; set; }

        [Display(Name = "آدرس")]
        [MaxLength(50, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string Address { get; set; }

        [Display(Name = "کلمه عبور ")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string Password { get; set; }

        [Display(Name = "موبایل ")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string Mobile { get; set; }

        [Display(Name = "کد فعال سازی را وارد نمایید")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string ActivationCode { get; set; }

        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }

        [Display(Name = "آواتار")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string UserAvatar { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime CreateDate { get; set; }
    }

    public class InformationUserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string UserAvatar { get; set; }
        public string Tell { get; set; }
        public DateTime RegisterDate { get; set; }
        public int Wallet { get; set; }
    }

    public class EditProfileViewModel
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی ")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string LastName { get; set; }

        [Display(Name = "ایمیل ")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        [EmailAddressAttribute(ErrorMessage = "فرمت ایمیل اشتباه می باشد")]
        public string Email { get; set; }

        [Display(Name = "تلفن همراه ")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string Mobile { get; set; }

        public IFormFile UserAvatar { get; set; }
        public string AvatarName { get; set; }

        //[Display(Name = "تلفن ثابت را وارد نمایید")]
        //[Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        //[MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        //public string Tell { get; set; }

        public string UserName { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Display(Name = "کلمه عبور فعلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string OldPassword { get; set; }

        [Display(Name = "کلمه عبور جدید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور جدید")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد.")]
        //[Compare("Password", ErrorMessage = "کلمه عبور مغایرت دارد")]
        public string RePassword { get; set; }
    }

    public class RegisterUserFromSiteViewModel
    {
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string FirstName { get; set; }

        [Display(Name = "نام خانوادگی ")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string LastName { get; set; }

        [Display(Name = "تلفن همراه ")]
        [Required(ErrorMessage = "لطفا {0}  را وارد نمایید.")]
        [MaxLength(200, ErrorMessage = "{0}  نمی تواند بیشتر از {1}  کاراکتر باشد")]
        public string Mobile { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }
    }

    public class ResetPasswordViewModel
    {
        public string ActivationCode { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        [Compare("Password", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        public string RePassword { get; set; }
    }
}
