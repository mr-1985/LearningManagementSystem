#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9142472a55a1378dba29f1394a1a9a4fb2ffbcc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Quiz_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Quiz/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9142472a55a1378dba29f1394a1a9a4fb2ffbcc8", @"/Pages/Admin/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Quiz_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""quiz-view"">
    <div class=""container"">
        <div class=""quiz-title"">
            <h2>General Quiz</h2>
            <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.</p>
        </div>
        <div class=""row"">
            <div class=""col-sm-4 col-md-3"">
                <div id=""countdown""></div>
                <div class=""qustion-list"">
                    <div class=""qustion-slide fill"">
                        <div class=""qustion-number"">Question 1</div>
                        <span>2</span>
                    </div>
                    <div class=""qustion-slide active"">
                        <div class=""qustion-number"">Question 2</div>
                        <span>2</span>
                    </div>
                    <div class=""qustion-slide"">
                        <div class=""qustion-number"">Question 3</div>
                        <span>2</span>
                    </div>
                    <div class=""qustion-slide"">
    ");
            WriteLiteral(@"                    <div class=""qustion-number"">Question 4</div>
                        <span>2</span>
                    </div>
                    <div class=""qustion-slide"">
                        <div class=""qustion-number"">Question 5</div>
                        <span>2</span>
                    </div>
                    <div class=""qustion-slide"">
                        <div class=""qustion-number"">Question 6</div>
                        <span>2</span>
                    </div>
                    <div class=""qustion-slide"">
                        <div class=""qustion-number"">Question 7</div>
                        <span>2</span>
                    </div>
                    <div class=""qustion-slide"">
                        <div class=""qustion-number"">Question 8</div>
                        <span>2</span>
                    </div>
                    <div class=""qustion-slide"">
                        <div class=""qustion-number"">Question 9</div>
                       ");
            WriteLiteral(@" <span>2</span>
                    </div>
                    <div class=""qustion-slide"">
                        <div class=""qustion-number"">Question 10</div>
                        <span>2</span>
                    </div>
                </div>
            </div>
            <div class=""col-sm-8 col-md-9"">
                <div class=""qustion-main"">
                    <div class=""qustion-box"">
                        <div class=""qustion"">Lorem Ipsum is simply dummy text of the printing and typesetting industry</div>
                        <div class=""ans"">

                            <div class=""ans-slide"">
                                <label class=""label_radio"" for=""radio-01"">
                                    <input name=""sample-radio"" id=""radio-01"" value=""1"" type=""radio"">Alternate1
                                </label>
                            </div>
                            <div class=""ans-slide"">
                                <label class=""label_radio"" for=""radi");
            WriteLiteral(@"o-02"">
                                    <input name=""sample-radio"" id=""radio-02"" value=""1"" type=""radio"">Alternate2
                                </label>
                            </div>
                            <div class=""ans-slide"">
                                <label class=""label_radio"" for=""radio-03"">
                                    <input type=""radio"" name=""sample-radio"" id=""radio-03"" value=""1"">Alternate3
                                </label>
                            </div>
                            <div class=""ans-slide"">
                                <label class=""label_radio"" for=""radio-04"">
                                    <input name=""sample-radio"" id=""radio-04"" value=""1"" type=""radio"">Alternate4
                                </label>
                            </div>
                        </div>
                        <div class=""save-btn"">
                            <a href=""#"" class=""btn2"">Save Answer</a>
                        </div>
      ");
            WriteLiteral(@"                  <div class=""btn-slide"">
                            <a href=""#"" class=""btn""><i class=""fa fa-angle-right""></i></a>
                            <a href=""#"" class=""btn""><i class=""fa fa-angle-left""></i></a>
                        </div>
                    </div>
                    <div class=""submit-quiz"">
                        <a href=""quiz-result.htm"" class=""btn"">submit quiz</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""/AdminContent/js\jquery-1.12.4.min.js""></script>
    <script type=""text/javascript"" src=""/AdminContent/js\bootstrap.js""></script>
    <script type=""text/javascript"" src=""/AdminContent/js\owl.carousel.js""></script>
    <script type=""text/javascript"" src=""/AdminContent/js\jquery.form-validator.min.js""></script>
    <script type=""text/javascript"" src=""/AdminContent/js\placeholder.js""></script>
    <script type=""text/javascript"" src=""/AdminContent/js\jquery.countdown.js""></script>
    <script type=""text/javascript"" src=""/AdminContent/js\countdown-script.js""></script>
    <script type=""text/javascript"" src=""/AdminContent/js\coustem.js""></script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lms.Web.Pages.Admin.Quiz.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.Quiz.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.Quiz.IndexModel>)PageContext?.ViewData;
        public Lms.Web.Pages.Admin.Quiz.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
