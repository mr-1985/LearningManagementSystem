#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9c1b3b43d416c4153e9cdbe35d8956585585c52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Courses_Details), @"mvc.1.0.razor-page", @"/Pages/Admin/Courses/Details.cshtml")]
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
#line 2 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml"
using Lms.Core.Convertors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml"
using Lms.DataLayer.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9c1b3b43d416c4153e9cdbe35d8956585585c52", @"/Pages/Admin/Courses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Courses_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml"
  
    ViewData["Title"] = "جزئیات دوره";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12 col-sm-12 col-xs-12"">
    <div class=""x_panel"">
        <div class=""x_title"">
            <h2>
                جزئیات دوره
            </h2>
            <ul class=""nav navbar-right panel_toolbox"">
                <li>
                    <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                </li>

            </ul>
            <div class=""clearfix""></div>
        </div>
        <div class=""x_content"">
            <p><img");
            BeginWriteAttribute("src", " src=\"", 660, "\"", 723, 2);
            WriteAttributeValue("", 666, "/CoursesPic/", 666, 12, true);
#nullable restore
#line 26 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml"
WriteAttributeValue("", 678, Model.InformationCourseViewModel.CourseImage, 678, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></p>\r\n            <p>\r\n                <h2>\r\n                    نام دوره : ");
#nullable restore
#line 29 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml"
                           Write(Model.InformationCourseViewModel.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n            </p>\r\n            <p> کد دوره: ");
#nullable restore
#line 32 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml"
                    Write(Model.InformationCourseViewModel.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>زمان دوره : ");
#nullable restore
#line 33 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml"
                      Write(Model.InformationCourseViewModel.CourseTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <aside class=\"col-md-4 col-sm-12 col-xs-12 pull-right\">\r\n                <div class=\"statistics\">\r\n                    <article class=\"term-info\">\r\n                        <ul>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1257, "\"", 1318, 2);
            WriteAttributeValue("", 1264, "/Admin/Courses/AddTeacherToClass/", 1264, 33, true);
#nullable restore
#line 38 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml"
WriteAttributeValue("", 1297, ViewData["CourseId"], 1297, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-xs\"> مربی دوره</a> </li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1407, "\"", 1468, 2);
            WriteAttributeValue("", 1414, "/Admin/Courses/AddStudentToClass/", 1414, 33, true);
#nullable restore
#line 39 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml"
WriteAttributeValue("", 1447, ViewData["CourseId"], 1447, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-xs\"> فراگیران</a> </li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1556, "\"", 1606, 2);
            WriteAttributeValue("", 1563, "/Admin/Quiz/IndexExam/", 1563, 22, true);
#nullable restore
#line 40 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml"
WriteAttributeValue("", 1585, ViewData["CourseId"], 1585, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-xs\"> ایجاد بانک سوالات</a> </li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1703, "\"", 1754, 2);
            WriteAttributeValue("", 1710, "/Admin/Quiz/CreateExam/", 1710, 23, true);
#nullable restore
#line 41 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Courses\Details.cshtml"
WriteAttributeValue("", 1733, ViewData["CourseId"], 1733, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-xs\"> ایجاد آزمون</a>  </li>\r\n                        </ul>\r\n                    </article>\r\n                </div>\r\n            </aside>\r\n\r\n");
            WriteLiteral("\r\n        </div>\r\n       \r\n    </div>\r\n   \r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lms.Web.Pages.Admin.Courses.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.Courses.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.Courses.DetailsModel>)PageContext?.ViewData;
        public Lms.Web.Pages.Admin.Courses.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
