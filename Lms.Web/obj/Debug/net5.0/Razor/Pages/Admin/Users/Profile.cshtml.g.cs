#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Users\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1527fe3899b403fda52a8b109d796c2d31aac8e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Users_Profile), @"mvc.1.0.razor-page", @"/Pages/Admin/Users/Profile.cshtml")]
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
#nullable restore
#line 2 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Users\Profile.cshtml"
using Lms.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1527fe3899b403fda52a8b109d796c2d31aac8e4", @"/Pages/Admin/Users/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Users_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Users\Profile.cshtml"
  
    ViewData["Title"] = "داشبورد";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <div class=""container"">
        <div class=""user-account"">
            <div class=""row"">
                <div class=""col-md-9 col-sm-8 col-xs-12"">
                    <section class=""user-account-content"">
                        <header><h1> داشبورد </h1></header>
                        <div class=""inner"">
                            <div class=""account-information"">
                                <h3> اطلاعات کاربری </h3>
                                <ul>
                                    <li> <i class=""zmdi zmdi-assignment-account""></i> نام کاربری :  ");
#nullable restore
#line 19 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Users\Profile.cshtml"
                                                                                                Write(Model.Information.FirstName+" "+@Model.Information.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                                    <li> <i class=\"zmdi zmdi-email\"></i> ایمیل : ");
#nullable restore
#line 20 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Users\Profile.cshtml"
                                                                            Write(Model.Information.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                                    <li> <i class=\"zmdi zmdi-calendar-check\"></i> تاریخ عضویت : ");
#nullable restore
#line 21 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Users\Profile.cshtml"
                                                                                           Write(Model.Information.RegisterDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                                    <li> <i class=\"zmdi zmdi-account\"></i> موجودی حساب : ");
#nullable restore
#line 22 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Users\Profile.cshtml"
                                                                                    Write(Model.Information.Wallet.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان </li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </section>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lms.Web.Pages.Admin.Users.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.Users.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.Users.ProfileModel>)PageContext?.ViewData;
        public Lms.Web.Pages.Admin.Users.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
