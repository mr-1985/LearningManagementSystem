#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\IndexEpisode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a3dfddd5d1589796392557834260c221c2ac5ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Courses_IndexEpisode), @"mvc.1.0.razor-page", @"/Pages/Admin/Courses/IndexEpisode.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a3dfddd5d1589796392557834260c221c2ac5ef", @"/Pages/Admin/Courses/IndexEpisode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Courses_IndexEpisode : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateEpisode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\IndexEpisode.cshtml"
  
    ViewData["Title"] = "بخش های دوره";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">لیست قسمت ها</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                لیست دوره های سایت
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""col-md-12"" style=""margin: 10px 0;"">

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a3dfddd5d1589796392557834260c221c2ac5ef4367", async() => {
                WriteLiteral("افزودن بخش جدید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\IndexEpisode.cshtml"
                                                  WriteLiteral(ViewData["CourseId"].ToString());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                </div>

                <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                    <thead>
                        <tr>
                            <th>عنوان بخش</th>
                            <th>زمان جلسه</th>
                            <th>رایگان</th>
                            <th>دستورات</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 39 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\IndexEpisode.cshtml"
                         foreach (var item in Model.CourseEpisodes)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 43 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\IndexEpisode.cshtml"
                               Write(item.EpisodeTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 46 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\IndexEpisode.cshtml"
                               Write(item.EpisodeTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
#nullable restore
#line 49 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\IndexEpisode.cshtml"
                                     if (item.IsFree)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"text-success\">\r\n                                            <i class=\"glyphicon glyphicon-ok\"></i>\r\n                                        </span>\r\n");
#nullable restore
#line 54 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\IndexEpisode.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"text-danger\">\r\n                                            <i class=\"glyphicon glyphicon-remove\"></i>\r\n                                        </span>\r\n");
#nullable restore
#line 60 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\IndexEpisode.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2490, "\"", 2539, 2);
            WriteAttributeValue("", 2497, "/Admin/Courses/EditEpisode/", 2497, 27, true);
#nullable restore
#line 63 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\IndexEpisode.cshtml"
WriteAttributeValue("", 2524, item.EpisodeId, 2524, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\r\n                                        ویرایش\r\n                                    </a>\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 69 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\IndexEpisode.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n            <!-- /.panel-body -->\r\n        </div>\r\n        <!-- /.panel -->\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lms.Web.Pages.Admin.Courses.IndexEpisodeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.Courses.IndexEpisodeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.Courses.IndexEpisodeModel>)PageContext?.ViewData;
        public Lms.Web.Pages.Admin.Courses.IndexEpisodeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
