#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f659f858a32b01ae347c10dca77417b0a56b2e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_MyOrders_ShowOrder), @"mvc.1.0.razor-page", @"/Pages/Admin/MyOrders/ShowOrder.cshtml")]
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
#line 2 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
using Lms.Core.Services.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f659f858a32b01ae347c10dca77417b0a56b2e3", @"/Pages/Admin/MyOrders/ShowOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_MyOrders_ShowOrder : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Course/UseDiscount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
  
    int sumOrder = Model.Order.OrderSum;
    string discountType = ViewBag.typeDiscount.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/"">صفحه اصلی</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page""> نمایش فاکتور </li>
        </ul>
    </nav>
</div>

<main>
    <div class=""container"">
        <div class=""user-account"">
            <div class=""row"">
                <div class=""col-md-9 col-sm-8 col-xs-12"">
                    <section class=""user-account-content"">
                        <header><h1> فاکتور شما </h1></header>
");
#nullable restore
#line 28 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                         if (ViewBag.finaly == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-success\">\r\n                                فاکتور با موفقیت پرداخت گردید\r\n                            </div>\r\n");
#nullable restore
#line 33 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th>دوره</th>
                                    <th>تعداد</th>
                                    <th>قیمت</th>
                                    <th>جمع</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 44 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                 foreach (var item in Model.Order.OrderDetails)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1805, "\"", 1836, 2);
            WriteAttributeValue("", 1812, "/ShowCourse/", 1812, 12, true);
#nullable restore
#line 48 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
WriteAttributeValue("", 1824, item.Course, 1824, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 48 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                                                                          Write(item.Course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 51 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                       Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 53 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 55 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                        Write((item.Count * item.Price).ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 58 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                 if (!Model.Order.IsFinaly)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td colspan=\"3\" class=\"text-left\">کد تخفیف</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f659f858a32b01ae347c10dca77417b0a56b2e39493", async() => {
                WriteLiteral("\r\n                                                <input type=\"hidden\" name=\"orderid\"");
                BeginWriteAttribute("value", " value=\"", 2849, "\"", 2877, 1);
#nullable restore
#line 65 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
WriteAttributeValue("", 2857, Model.Order.OrderId, 2857, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                                <input type=""text"" name=""code"" class=""form-control"" />
                                                <input type=""submit"" class=""btn btn-primary btn-block"" style=""margin-top: 5px"" value=""اعمال"" />
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                             if (discountType != "")
                                            {
                                                switch (discountType)
                                                {
                                                    case "Success":
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <div class=""alert alert-success"">
                                                                <p class=""text-muted"">کد با موفقیت اعمال شد</p>
                                                            </div>
");
#nullable restore
#line 78 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                                            break;
                                                        }
                                                    case "ExpierDate":
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <div class=""alert alert-danger"">
                                                                <p class=""text-muted"">تاریخ کد به اتمام رسیده است</p>
                                                            </div>
");
#nullable restore
#line 85 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                                            break;
                                                        }
                                                    case "NotFound":
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <div class=""alert alert-warning"">
                                                                <p class=""text-muted"">کد معتبر نیست</p>
                                                            </div>
");
#nullable restore
#line 92 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                                            break;
                                                        }
                                                    case "Finished":
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <div class=""alert alert-danger"">
                                                                <p class=""text-muted"">کد به اتمام رسیده است</p>
                                                            </div>
");
#nullable restore
#line 99 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                                            break;
                                                        }
                                                    case "UserUsed":
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            <div class=""alert alert-info"">
                                                                <p class=""text-muted"">این کد قبلا توسط شما استفاده شده است</p>
                                                            </div>
");
#nullable restore
#line 106 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                                            break;
                                                        }
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 112 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td colspan=\"3\" class=\"text-left\">جمع کل</td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 116 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                   Write(sumOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 120 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                 if (!Model.Order.IsFinaly)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td colspan=\"2\" class=\"text-left\"></td>\r\n                                        <td colspan=\"2\">\r\n");
#nullable restore
#line 125 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                             if (_UserService.BalanceUserWallet(User.Identity.Name) >= sumOrder)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <a class=\"btn btn-success btn-block\"");
            BeginWriteAttribute("href", " href=\"", 7136, "\"", 7183, 2);
            WriteAttributeValue("", 7143, "/Course/FinalyOrder/", 7143, 20, true);
#nullable restore
#line 127 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
WriteAttributeValue("", 7163, Model.Order.OrderId, 7163, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">تایید فاکتور</a>\r\n");
#nullable restore
#line 128 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <a class=""btn btn-success btn-block"" disabled>تایید فاکتور</a>
                                                <div class=""alert alert-danger"">
                                                    موجودی کیف پول شما کافی نمی باشد ، لطفا از طریق این
                                                    <a href=""/Admin/Users/Wallet"" class=""alert-link"">لینک</a>
                                                    اقدام به شارژ حساب کنید
                                                </div>
");
#nullable restore
#line 137 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 141 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\MyOrders\ShowOrder.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </section>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUserService _UserService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lms.Web.Pages.Admin.MyOrders.ShowOrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.MyOrders.ShowOrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.MyOrders.ShowOrderModel>)PageContext?.ViewData;
        public Lms.Web.Pages.Admin.MyOrders.ShowOrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
