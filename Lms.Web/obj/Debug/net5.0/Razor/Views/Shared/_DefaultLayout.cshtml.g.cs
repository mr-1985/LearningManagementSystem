#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Shared\_DefaultLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39a700553e04e2dca180450a9c6adc872b6e686b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DefaultLayout), @"mvc.1.0.view", @"/Views/Shared/_DefaultLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39a700553e04e2dca180450a9c6adc872b6e686b", @"/Views/Shared/_DefaultLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DefaultLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Quiz/js/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Quiz/js/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\" dir=\"rtl\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39a700553e04e2dca180450a9c6adc872b6e686b4230", async() => {
                WriteLiteral("\r\n    <!-- Meta information -->\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0\"><!-- Mobile Specific Metas -->\r\n    <!-- Title -->\r\n    <title>");
#nullable restore
#line 8 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Shared\_DefaultLayout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n\r\n    <!-- favicon icon -->\r\n    <link rel=\"shortcut icon\" href=\"/Quiz/images\\Favicon.ico\">\r\n\r\n\r\n\r\n    <!-- CSS Stylesheet -->\r\n    <link href=\"/Quiz/css\\bootstrap.css\" rel=\"stylesheet\">\r\n");
                WriteLiteral(@"    <link href=""/Quiz/css\bootstrap-rtl.min.css"" rel=""stylesheet"">
    <link href=""/Quiz/css\docs.css"" rel=""stylesheet""><!--  template structure css -->
    <link href=""/Quiz/css\owl.carousel.css"" rel=""stylesheet""><!-- carousel Slider -->
    <link href=""/Quiz/css\font-awesome.css"" rel=""stylesheet""><!-- font awesome -->
    <link href=""/Quiz/css\loader.css"" rel=""stylesheet""><!--  loader css -->
    <link href=""https://fonts.googleapis.com/css?family=Arima+Madurai:100,200,300,400,500,700,800,900%7CPT+Roboto:100,100i,300,300i,400,400i,500,500i,700,700i,900,900i"" rel=""stylesheet"">
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
      <script src=""https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js""></script>
    <![endif]-->

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39a700553e04e2dca180450a9c6adc872b6e686b6894", async() => {
                WriteLiteral(@"
    <div class=""wapper"">
        <div id=""loader-wrapper"">
            <div id=""loader""></div>
            <div class=""loader-section section-left""></div>
            <div class=""loader-section section-right""></div>
        </div>
        <div class=""quck-nav"">
            <div class=""container"">
                <div class=""contact-no""><a href=""#""><i class=""fa fa-map-marker""></i>Brooklyn, NY 10036, United States</a></div>
                <div class=""contact-no""><a href=""#""><i class=""fa fa-phone""></i>+299 97 39 82</a></div>
                <div class=""contact-no""><a href=""#""><i class=""fa fa-globe""></i>academy.com</a></div>
                <div class=""quck-right"">
                    <div class=""right-link""><a href=""#""><i class=""fa fa-handshake-o""></i>Help Center</a></div>
                    <div class=""right-link""><a href=""#""><i class=""fa fa-headphones""></i>???????????? ????????????</a></div>
                    <div class=""right-link language-select"">
");
                WriteLiteral(@"                        <ul class=""language-list"">
                            <li><a href=""#"">Guyana</a></li>
                            <li><a href=""#"">Haiti</a></li>
                            <li><a href=""#"">Honduras</a></li>
                            <li><a href=""#"">Andorra</a></li>
                            <li><a href=""#"">Armenia</a></li>
                            <li><a href=""#"">Bahrain</a></li>
                        </ul>
                    </div>
");
#nullable restore
#line 58 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Shared\_DefaultLayout.cshtml"
                     if (User.Identity.IsAuthenticated)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"right-link\"><a href=\"https://localhost:44399/Admin/Users/Profile\"><i class=\"fa  fa-user\"></i>");
#nullable restore
#line 61 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Shared\_DefaultLayout.cshtml"
                                                                                                                            Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ?? ?????? ??????????</a></div>\r\n                        <div class=\"right-link\"><a href=\"/LogOut\"><i class=\"fa  fa-user\"></i>????????</a></div>\r\n");
#nullable restore
#line 63 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Shared\_DefaultLayout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"right-link\"><a href=\"/Register\"><i class=\"fa  fa-user\"></i> ?????? ??????</a></div>\r\n                        <div class=\"right-link\"><a href=\"/Login\"><i class=\"fa  fa-user\"></i>???????? </a></div>\r\n");
#nullable restore
#line 68 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Shared\_DefaultLayout.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <header id=\"header\">\r\n            ");
#nullable restore
#line 74 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Shared\_DefaultLayout.cshtml"
       Write(await Component.InvokeAsync("CourseGroupComponent"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </header>\r\n        <section class=\"banner\">\r\n            ");
#nullable restore
#line 77 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Shared\_DefaultLayout.cshtml"
       Write(RenderSection("Banner", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </section>\r\n        ");
#nullable restore
#line 79 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Shared\_DefaultLayout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 80 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Shared\_DefaultLayout.cshtml"
   Write(RenderSection("Preparation", false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <footer id=""footer"">
            <div class=""footer-top"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-sm-6 col-md-3"">
                            <h5>Popular Courses</h5>
                            <div class=""course-slide"">
                                <div class=""img""><img src=""/Quiz/images\blog\post-img1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 4477, "\"", 4483, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                                <p><a href=""courses-list.htm"">when an unknown printer took </a></p>
                                <div class=""price"">$55</div>
                            </div>
                            <div class=""course-slide"">
                                <div class=""img""><img src=""/Quiz/images\blog\post-img2.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 4839, "\"", 4845, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                                <p><a href=""courses-list-sideBar.htm"">when an unknown printer took </a></p>
                                <div class=""price"">$505</div>
                            </div>
                            <div class=""course-slide"">
                                <div class=""img""><img src=""/Quiz/images\blog\post-img3.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 5210, "\"", 5216, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>
                                <p><a href=""courses-list.htm"">when an unknown printer took </a></p>
                                <div class=""price"">$178</div>
                            </div>
                        </div>
                        <div class=""col-sm-6"">
                            <div class=""row"">
                                <div class=""col-md-offset-1 col-sm-6 col-md-5 col-xs-6"">
                                    <h5>Company</h5>
                                    <ul class=""footer-link"">
                                        <li><a href=""about-us.htm"">About Us</a></li>
                                        <li><a href=""contact-us.htm"">Contact</a></li>
                                        <li><a href=""blog.htm"">Blog</a></li>
                                        <li><a href=""event.htm"">Event</a></li>
                                        <li><a href=""gallery.htm"">Gallery</a></li>
                                        <li><a href=""instructor-pro");
                WriteLiteral(@"file.htm"">Instructor Profile</a></li>
                                    </ul>
                                </div>
                                <div class=""col-md-offset-1 col-sm-6 col-md-5 col-xs-6"">
                                    <h5>Links</h5>
                                    <ul class=""footer-link"">
                                        <li><a href=""courses-list.htm"">Courses List</a></li>
                                        <li><a href=""price-plan.htm"">Pricing Table</a></li>
                                        <li><a href=""instructors.htm"">Instructors</a></li>
                                        <li><a href=""forums.htm"">Forums</a></li>
                                        <li><a href=""faq.htm"">Faq</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-6 col-md-3"">
                            <h5>Contact Us</h5>
    ");
                WriteLiteral(@"                        <div class=""contact-view"">
                                <div class=""contact-slide"">
                                    <p><i class=""fa fa-location-arrow""></i>76 Woodland Ave. Sherman Drive  <br>Fort Walton Beach,Harlingen</p>
                                </div>
                                <div class=""contact-slide"">
                                    <p><i class=""fa fa-phone""></i>+299 97 39 82</p>
                                </div>
                                <div class=""contact-slide"">
                                    <p><i class=""fa fa-fax""></i>(08) 8971 7450</p>
                                </div>
                                <div class=""contact-slide"">
                                    <p><i class=""fa fa-envelope""></i><a href=""mailTo:academy@info.com"">academy@info.com</a></p>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
    ");
                WriteLiteral(@"        </div>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-sm-8"">
                        <div class=""copy-right"">
                            <p>Copyright ?? <span class=""year"">2016</span> Academy.</p>
                            <ul class=""footer-link"">
                                <li><a href=""#"">Terms and Conditions</a></li>
                                <li><a href=""#"">Privacy</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-sm-4 "">
                        <div class=""social-media"">
                            <ul>
                                <li><a href=""#""><i class=""fa fa-facebook""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-twitter""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-skype""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-yo");
                WriteLiteral(@"utube""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-linkedin""></i></a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </footer>
    </div>
    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39a700553e04e2dca180450a9c6adc872b6e686b18183", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("    <script type=\"text/javascript\" src=\"/Quiz/js\\bootstrap.js\"></script>\r\n    <script type=\"text/javascript\" src=\"/Quiz/js\\owl.carousel.js\"></script>\r\n    <script type=\"text/javascript\" src=\"/Quiz/js\\jquery.form-validator.min.js\"></script>\r\n");
                WriteLiteral("    <script type=\"text/javascript\" src=\"/Quiz/js\\placeholder.js\"></script>\r\n    <script type=\"text/javascript\" src=\"/Quiz/js\\coustem.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39a700553e04e2dca180450a9c6adc872b6e686b19777", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39a700553e04e2dca180450a9c6adc872b6e686b20877", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 189 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Views\Shared\_DefaultLayout.cshtml"
Write(RenderSection("Scripts", false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
