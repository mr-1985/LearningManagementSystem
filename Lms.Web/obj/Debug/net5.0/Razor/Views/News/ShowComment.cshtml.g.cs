#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c1096db622389ce06aa44c569a064b7211f6f64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_ShowComment), @"mvc.1.0.view", @"/Views/News/ShowComment.cshtml")]
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
#line 1 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
using Lms.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c1096db622389ce06aa44c569a064b7211f6f64", @"/Views/News/ShowComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_News_ShowComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Lms.DataLayer.Entities.News.PageComment>, int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
 foreach (var item in Model.Item1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- row -->\r\n    <div class=\"comment-row\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 225, "\"", 264, 2);
            WriteAttributeValue("", 231, "/UserAvatar/", 231, 12, true);
#nullable restore
#line 12 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
WriteAttributeValue("", 243, item.User.UserAvatar, 243, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"left-col\">\r\n            <h3> ");
#nullable restore
#line 14 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
            Write(item.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n            <span>");
#nullable restore
#line 15 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
             Write(item.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <p>\r\n                ");
#nullable restore
#line 17 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
           Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n    <!-- /row -->\r\n");
#nullable restore
#line 22 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav aria-label=\"Page navigation\">\r\n    <ul class=\"pagination justify-content-center\">\r\n\r\n");
#nullable restore
#line 27 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
         for (int i = 1; i <= Model.Item2; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("onclick", " onclick=\"", 720, "\"", 745, 3);
            WriteAttributeValue("", 730, "pageComment(", 730, 12, true);
#nullable restore
#line 29 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
WriteAttributeValue("", 742, i, 742, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 744, ")", 744, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 30 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowComment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n</nav>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Lms.DataLayer.Entities.News.PageComment>, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
