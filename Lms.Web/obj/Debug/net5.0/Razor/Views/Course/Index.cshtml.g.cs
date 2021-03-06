#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae1a403047eb3e583aefe7759587dc5a8da3ccbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
using Lms.DataLayer.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae1a403047eb3e583aefe7759587dc5a8da3ccbc", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Lms.Core.ViewModels.ShowCourseListItemViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "updatedate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BoxCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "Archive";
    List<CourseGroup> groups = ViewBag.Groups as List<CourseGroup>;
    List<int> selected = ViewBag.selectedGroups as List<int>;
    Layout = "~/Views/Shared/_HomeLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/"">???????? ????????</a></li>
            <li class=""breadcrumb-item active""><a href=""/Course"">???????? ????</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page""> ???????????? ?????????? </li>
        </ul>
    </nav>
</div>

<div class=""container"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1a403047eb3e583aefe7759587dc5a8da3ccbc6147", async() => {
                WriteLiteral("\r\n        <input type=\"hidden\" id=\"pageid\" name=\"pageId\"");
                BeginWriteAttribute("value", " value=\"", 840, "\"", 874, 1);
#nullable restore
#line 23 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 848, ViewBag.pageId.ToString(), 848, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <section class=\"term-categories\">\r\n\r\n            <div class=\"top-bar\">\r\n\r\n                <header>\r\n                    <h1> ???????? ?????? <span> ???????????? ?????????? ???? </span> </h1> <span> ");
#nullable restore
#line 29 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                                         Write(Model.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(@" ???????? </span>
                </header>

                <div class=""row"">
                    <div class=""col-md-4 col-sm-12 col-xs-12 pull-right"">
                        <div class=""input"">
                            <input type=""text"" name=""filter"" placeholder=""?????????? ???????? ?????? ..."">
                            <button><i class=""zmdi zmdi-search""></i></button>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-right"">
                        <div class=""switch-field available"">
                            <input id=""available-filter-1"" name=""getType"" value=""all""");
                BeginWriteAttribute("checked", " checked=\"", 1735, "\"", 1745, 0);
                EndWriteAttribute();
                WriteLiteral(@" type=""radio"">
                            <label for=""available-filter-1""> ?????? </label>
                            <input id=""available-filter-2"" name=""getType"" value=""buy"" type=""radio"">
                            <label for=""available-filter-2""> ???????????? </label>
                            <input id=""available-filter-3"" name=""getType"" value=""free"" type=""radio"">
                            <label for=""available-filter-3""> ???????????? </label>
                        </div>
                    </div>
                    <div class=""col-md-4 col-sm-6 col-xs-12 pull-left"">
                        <div class=""select-ddl"">
                            <select name=""orderByType"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1a403047eb3e583aefe7759587dc5a8da3ccbc8982", async() => {
                    WriteLiteral(" ?????????? ???????????? ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae1a403047eb3e583aefe7759587dc5a8da3ccbc10245", async() => {
                    WriteLiteral(" ?????????? ???????? ?????????? ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">
                <aside class=""col-lg-3 col-md-4 col-sm-12 col-xs-12"">

                    <section class=""aside-section filter-by-price"">
                        <header>
                            <h3> ?????????? ???? ???????? ???????? </h3>
                        </header>
                        <div class=""price-range"">
                            <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 3147, "\"", 3155, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"min-value\" name=\"startPrice\">\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3240, "\"", 3248, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""max-value"" name=""endPrice"">
                            <div class=""price-bar"">
                                <div id=""priceFilter""></div>
                            </div>
                            <div class=""max-price"">???? <span id=""max-text"">500000</span> ??????????</div>
                            <div class=""min-price"">???? <span id=""min-text"">20000</span> ??????????</div>
                            <div class=""clearfix""></div>
                        </div>
                    </section>

                    <section class=""aside-section filter-by-category"">
                        <header>
                            <h3> ???????? ???????? ?????????????? </h3>
                        </header>
                        <div class=""inner"">
                            <ul>
");
#nullable restore
#line 85 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                 foreach (var group in groups.Where(g => g.ParentId == null))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>\r\n                                        <input onchange=\"changeGroup()\" type=\"checkbox\" ");
#nullable restore
#line 88 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                                                    Write((selected.Any(s => s == group.GroupId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"selectedGroups\" value=\"");
#nullable restore
#line 88 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                                                                                                                                            Write(group.GroupId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"cat-1\">\r\n                                        <label for=\"cat-1\"> ");
#nullable restore
#line 89 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                       Write(group.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n");
#nullable restore
#line 90 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                         if (groups.Any(g => g.ParentId == group.GroupId))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <ul>\r\n");
#nullable restore
#line 93 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                 foreach (var sub in groups.Where(g => g.ParentId == group.GroupId))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <li>\r\n                                                        <input onchange=\"changeGroup()\" ");
#nullable restore
#line 96 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                                                    Write((selected.Any(s => s == sub.GroupId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" type=\"checkbox\" name=\"selectedGroups\" value=\"");
#nullable restore
#line 96 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                                                                                                                                                          Write(sub.GroupId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" id=\"cat-1\">\r\n                                                        <label for=\"cat-1\"> ");
#nullable restore
#line 97 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                                       Write(sub.GroupTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label>\r\n                                                    </li>\r\n");
#nullable restore
#line 99 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </ul>\r\n");
#nullable restore
#line 101 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </li>\r\n");
#nullable restore
#line 103 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </ul>
                        </div>
                    </section>
                </aside>

                <div class=""col-lg-9 col-md-8 col-sm-12 col-xs-12"">
                    <section class=""terms-items"">
                        <div class=""row"">
");
#nullable restore
#line 112 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ae1a403047eb3e583aefe7759587dc5a8da3ccbc18701", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 114 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 115 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n");
#nullable restore
#line 117 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                          
                            int totalItems = ViewBag.TotalItems;
                            int currentPage = ViewBag.currentPage;
                            int pageSize = 10;
                            int maxPages = 10;
                            int startPage, endPage;
                            var totalPages = ViewBag.PageCount;
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 126 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                         if (totalPages <= maxPages)
                        {
                            // total pages less than max so show all pages
                            startPage = 1;
                            endPage = totalPages;
                        }
                        else
                        {
                            // total pages more than max so calculate start and end pages
                            var maxPagesBeforeCurrentPage = (int)Math.Floor((decimal)maxPages / (decimal)2);
                            var maxPagesAfterCurrentPage = (int)Math.Ceiling((decimal)maxPages / (decimal)2) - 1;

                            if (currentPage <= maxPagesBeforeCurrentPage)
                            {
                                // current page near the start
                                startPage = 1;
                                endPage = maxPages;
                            }
                            else if (currentPage + maxPagesAfterCurrentPage >= totalPages)
                            {
                                // current page near the end
                                startPage = totalPages - maxPages + 1;
                                endPage = totalPages;
                            }
                            else
                            {
                                // current page somewhere in the middle
                                startPage = currentPage - maxPagesBeforeCurrentPage;
                                endPage = currentPage + maxPagesAfterCurrentPage;
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <nav aria-label=\"Page navigation\">\r\n                            <ul class=\"pagination justify-content-center\">\r\n");
#nullable restore
#line 159 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                 if (ViewBag.currentPage > 1)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a class=\"btn btn-default\"");
                BeginWriteAttribute("href", " href=\"", 8401, "\"", 8449, 2);
                WriteAttributeValue("", 8408, "/Course?pageId=", 8408, 15, true);
#nullable restore
#line 161 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 8423, ViewBag.currentPage - 1, 8423, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">????????</a>\r\n");
#nullable restore
#line 163 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                                                                         
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 166 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                 for (int i = startPage; i <= endPage; i++)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a");
                BeginWriteAttribute("href", " href=\"", 8757, "\"", 8781, 2);
                WriteAttributeValue("", 8764, "/Course?pageId=", 8764, 15, true);
#nullable restore
#line 168 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 8779, i, 8779, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 8782, "\"", 8854, 3);
                WriteAttributeValue("", 8790, "btn", 8790, 3, true);
                WriteAttributeValue(" ", 8793, "btn-default", 8794, 12, true);
#nullable restore
#line 168 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
WriteAttributeValue(" ", 8805, (i==ViewBag.currentPage)? "btn btn-info" : "", 8806, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 168 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                                                                                                    Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 169 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 171 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                 if (ViewBag.currentPage < ViewBag.PageCount)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a class=\"btn btn-default\"");
                BeginWriteAttribute("href", " href=\"", 9077, "\"", 9125, 2);
                WriteAttributeValue("", 9084, "/Course?pageId=", 9084, 15, true);
#nullable restore
#line 173 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
WriteAttributeValue("", 9099, ViewBag.currentPage + 1, 9099, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">????????</a>\r\n");
#nullable restore
#line 175 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Course\Index.cshtml"
                                                                                                                          
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\r\n                        </nav>\r\n                    </section>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/HomePage/css/css/noUiSlider/nouislider.min.js""></script>
    <script src=""/HomePage/css/css/js/script.js""></script>

    <script type=""text/javascript"">

        function changePage(pageid) {
            $(""#pageid"").val(pageid);
            $(""#formFilter"").submit();
        }

        $(function () {

            var slider = document.getElementById('priceFilter');
            noUiSlider.create(slider,
                {
                    start: [20000, 100000],
                    step: 5000,
                    connect: true,
                    direction: 'rtl',
                    range: {
                        'min': 20000,
                        'max': 100000
                    }
                });

            var marginMin = document.getElementById('min-text'),
                marginMax = document.getElementById('max-text');

            slider.noUiSlider.on('update',
                function (values, handle) {
                    var xvalue = ");
                WriteLiteral(@"Math.round(values[handle]);
                    if (handle) {
                        marginMax.innerHTML = xvalue;
                    } else {
                        marginMin.innerHTML = xvalue;
                    }
                    //console.log(values[handle]);
                });

            slider.noUiSlider.on('change',
                function (values, handle) {
                    var xvalue = Math.round(values[handle]);
                    if (handle) {
                        // setGetParameter('max_price', xvalue);
                        $('#max-value').val(xvalue);
                    } else {
                        // setGetParameter('min_price', xvalue);
                        $('#min-value').val(xvalue);
                    }
                });


            slider.noUiSlider.on('slide',
                function (values, handle) {

                    //console.log(values[0]);
                    //console.log(values[1]);

                    var xvalue =");
                WriteLiteral(@" Math.round(values[handle]);
                    //updateSliderRange( Math.round(values[0]), Math.round(values[1]) );
                });

            function updateSliderRange(min, max) {
                slider.noUiSlider.updateOptions({
                    range: {
                        'min': min,
                        'max': max
                    }
                });
            }
        });

        function changeGroup() {
            $(""#formFilter"").submit();
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Lms.Core.ViewModels.ShowCourseListItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
