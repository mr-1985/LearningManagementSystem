#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\CourseVote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae8d02553e0e5fa4f70ddfada02b63e9c36a9ce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_CourseVote), @"mvc.1.0.view", @"/Views/Course/CourseVote.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae8d02553e0e5fa4f70ddfada02b63e9c36a9ce0", @"/Views/Course/CourseVote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_CourseVote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<int, int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\CourseVote.cshtml"
 if (User.Identity.IsAuthenticated && ViewBag.NotAccess == null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <img src=""/HomePage/images/votew.jpg"" />
        <p></p>
        <p>
            <a class=""btn btn-success"" onclick=""vote(true)"">
                <img class=""btnLike"" style="" width: 22px !important;
                                      float: right;
                                      margin: 0 !important;
                                      margin-left: 6px !important;"" src=""/HomePage/images/like.png"" />
                میپسندم (");
#nullable restore
#line 15 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\CourseVote.cshtml"
                    Write(Model.Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")
            </a>
            <a class=""btn btn-danger"" onclick=""vote(false)"">
                <img class=""btnLike"" style="" width: 22px !important;
                                      float: right;
                                      margin: 0 !important;
                                      margin-left: 6px !important;""  src=""/HomePage/images/dislike.png"" />
                نمی پسندم (");
#nullable restore
#line 22 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\CourseVote.cshtml"
                      Write(Model.Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n            </a>\r\n        </p>\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\CourseVote.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<int, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
