#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "664888fd38e9ad0d6dce94a13a880f5d4ba12551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_ShowNews), @"mvc.1.0.view", @"/Views/News/ShowNews.cshtml")]
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
#line 1 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
using Lms.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"664888fd38e9ad0d6dce94a13a880f5d4ba12551", @"/Views/News/ShowNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_News_ShowNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lms.DataLayer.Entities.News.Page>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "News", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-mode", new global::Microsoft.AspNetCore.Html.HtmlString("replace"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-update", new global::Microsoft.AspNetCore.Html.HtmlString("#listComment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("Success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
  
    ViewData["Title"] = "ShowNews";
    Layout = "~/Views/Shared/_HomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/""> صفحه اصلی </a></li>
            <li class=""breadcrumb-item active""><a href=""/Archive""> مقالات </a></li>
            <li class=""breadcrumb-item active"" aria-current=""page""> ");
#nullable restore
#line 13 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                                                               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n        </ul>\r\n    </nav>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <section class=\"term-content\">\r\n        <header><h1> ");
#nullable restore
#line 20 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1></header>\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-md-8 col-sm-12 col-xs-12 pull-left\">\r\n                <section class=\"term-description\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 825, "\"", 856, 2);
            WriteAttributeValue("", 831, "/NewsPic/", 831, 9, true);
#nullable restore
#line 25 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
WriteAttributeValue("", 840, Model.ImageName, 840, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    ");
#nullable restore
#line 27 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
               Write(Html.Raw(Model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </section>\r\n\r\n                <section class=\"user-comments\">\r\n                    <header><h3> نظرات کاربران </h3></header>\r\n                    <div class=\"inner\">\r\n");
#nullable restore
#line 34 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "664888fd38e9ad0d6dce94a13a880f5d4ba125518286", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"comment.PageID\"");
                BeginWriteAttribute("value", " value=\"", 1638, "\"", 1659, 1);
#nullable restore
#line 42 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
WriteAttributeValue("", 1646, Model.PageID, 1646, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                <div class=""row"">
                                    <div class=""col-md-12 col-sm-12 col-xs-12"">
                                        <div class=""form-group"">
                                            <textarea class=""form-control"" id=""comment_Comment"" name=""comment.Comment"" placeholder=""متن نظر""></textarea>
                                        </div>

                                    </div>
                                    <div class=""col-xs-12"">
                                        <button type=""submit"" class=""btn btn-success""> ثبت دیدگاه </button>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"alert alert-danger\">\r\n                                جهت درج نظر باید وارد سایت شوید\r\n                            </div>\r\n");
#nullable restore
#line 61 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""comment-list"" id=""listComment"">

                        </div>
                    </div>
                </section>
            </div>

            <aside class=""col-md-4 col-sm-12 col-xs-12 pull-right"">
                <article class=""term-info"">
                    <ul>
                        <article class=""teacher-info"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 3087, "\"", 3127, 2);
            WriteAttributeValue("", 3093, "/UserAvatar/", 3093, 12, true);
#nullable restore
#line 74 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
WriteAttributeValue("", 3105, Model.User.UserAvatar, 3105, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </article>\r\n                        <li>\r\n                            <i class=\"zmdi zmdi-calendar\"></i> ");
#nullable restore
#line 77 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                                                          Write(Model.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"zmdi zmdi-eye\" ");
            WriteLiteral("></i> ");
#nullable restore
#line 80 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                                                                                   Write(Model.Visit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"zmdi zmdi-comments\" style=\"position: inherit\"></i>");
#nullable restore
#line 83 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                                                                                   Write(Model.PageComments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"zmdi zmdi-account\">\r\n                                <a ");
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 88 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                                Write(Model.User.FirstName + " " + Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </a>
                            </i>
                        </li>
                    </ul>
                </article>

                <div class=""share-layer"">
                    <span> به اشتراک گذاری </span>
                    <a");
            BeginWriteAttribute("href", " href=\"", 4182, "\"", 4189, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4253, "\"", 4260, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-google-old\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4326, "\"", 4333, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-twitter\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4396, "\"", 4403, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-linkedin\"></i></a>\r\n                </div>\r\n\r\n");
#nullable restore
#line 103 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                 if (Model.Tags != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"tags-layer\">\r\n");
#nullable restore
#line 106 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                         foreach (string tag in Model.Tags.Split('-', StringSplitOptions.RemoveEmptyEntries))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 4746, "\"", 4773, 2);
            WriteAttributeValue("", 4753, "/Archive?filter=", 4753, 16, true);
#nullable restore
#line 108 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
WriteAttributeValue("", 4769, tag, 4769, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 108 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                                                       Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 109 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 111 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </aside>\r\n        </div>\r\n    </section>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script src=\"/js/jquery.unobtrusive-ajax.min.js\"></script>\r\n    <script>\r\n        function Success() {\r\n            $(\"#comment_Comment\").val(\"\");\r\n        }\r\n\r\n        $(function() {\r\n            $(\"#listComment\").load(\"/News/ShowComment/\" + ");
#nullable restore
#line 127 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                                                     Write(Model.PageID);

#line default
#line hidden
#nullable disable
                WriteLiteral(");\r\n        });\r\n\r\n        function pageComment(pageid) {\r\n            $(\"#listComment\").load(\"/News/ShowComment/\" + ");
#nullable restore
#line 131 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\News\ShowNews.cshtml"
                                                     Write(Model.PageID);

#line default
#line hidden
#nullable disable
                WriteLiteral("+\"?pageId=\"+pageid);\r\n        }\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lms.DataLayer.Entities.News.Page> Html { get; private set; }
    }
}
#pragma warning restore 1591
