#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Account\ActiveAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "188570f0b69f474a9285464ffc5a20db669cef76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ActiveAccount), @"mvc.1.0.view", @"/Views/Account/ActiveAccount.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"188570f0b69f474a9285464ffc5a20db669cef76", @"/Views/Account/ActiveAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ActiveAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Account\ActiveAccount.cshtml"
  
    ViewData["Title"] = "فعالسازی";
    Layout = "~/Views/Shared/_HomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"banner inner-page\">\r\n    <div class=\"banner-img\" style=\"background-image: url(&quot;imagesºnnerquiz.jpg&quot;);\"><img src=\"images\\banner\\quiz.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 261, "\"", 267, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"display: none;\"></div>\r\n    <div class=\"page-title\">\r\n        <div class=\"container\">\r\n            <h1>فعالسازی حساب کاربری</h1>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 17 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Account\ActiveAccount.cshtml"
     if (ViewBag.IsActive)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\">\r\n            <p>حساب کاربری شما با موفقیت فعال شد</p>\r\n            <p>\r\n                <a href=\"/Login\">ورود به سایت</a>\r\n            </p>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Account\ActiveAccount.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            <p>حساب کاربری با مشخصات ارسال شده یافت نشد</p>\r\n        </div>\r\n");
#nullable restore
#line 32 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Account\ActiveAccount.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
