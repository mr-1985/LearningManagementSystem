#pragma checksum "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70059711606dcf2a018c2c0afc01e5dec4c88449"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Quiz_AddStudentToExam), @"mvc.1.0.razor-page", @"/Pages/Admin/Quiz/AddStudentToExam.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70059711606dcf2a018c2c0afc01e5dec4c88449", @"/Pages/Admin/Quiz/AddStudentToExam.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Quiz_AddStudentToExam : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-md-12 col-sm-12 col-xs-12"">

    <div class=""x_panel"">
        <div class=""x_title"">
            <h2>
                فراگیران کلاس
            </h2>
            <ul class=""nav navbar-right panel_toolbox"">
                <li>
                    <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                </li>
            </ul>
            <div class=""clearfix""></div>
        </div>
        <div class=""x_content"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
");
            WriteLiteral(@"
                <div id=""datatable-checkbox_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap no-footer"">

                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <input type=""button"" id=""delete"" class=""btn btn-danger"" value=""حذف از آزمون"">
");
#nullable restore
#line 34 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                              
                                int rowCount = 1;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <table id=""deleteStudent"" class=""display"" style=""width:100%"" >

                            <thead>
                                    <tr role=""row"">
                                        <th><input type=""checkbox"" id=""checkAll"" /></th>
                                        <th>ردیف</th>
                                        <th>تصویر فراگیر</th>
                                        <th>نام فراگیر </th>
                                        <th>نام خانوادگی</th>
                                        <th>شماره موبایل</th>
                                        <th>نام کاربری</th>
                                    </tr>
                                </thead>

                                <tbody>
");
#nullable restore
#line 53 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                     foreach (var student in Model.GetStudentListInExam)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr role=\"row\" class=\"odd\">\r\n                                            <td>\r\n                                                <input type=\"checkbox\" class=\"checkBox\"");
            BeginWriteAttribute("value", " value=\"", 2568, "\"", 2591, 1);
#nullable restore
#line 57 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
WriteAttributeValue("", 2576, student.UserId, 2576, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 60 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                           Write(rowCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                <img class=\"img-circle\" height=\"50\"");
            BeginWriteAttribute("src", " src=\"", 2941, "\"", 2978, 2);
            WriteAttributeValue("", 2947, "/UserAvatar/", 2947, 12, true);
#nullable restore
#line 63 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
WriteAttributeValue("", 2959, student.UserAvatar, 2959, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 66 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                           Write(student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 69 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                           Write(student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 72 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                           Write(student.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 75 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                           Write(student.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n");
            WriteLiteral("                                        </tr>\r\n");
#nullable restore
#line 81 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                        rowCount++;
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""col-md-12 col-sm-12 col-xs-12"">
    <div class=""x_panel"">
        <div class=""x_title"">
            <h2>
                انتخاب فراگیران
            </h2>
            <ul class=""nav navbar-right panel_toolbox"">
                <li>
                    <a class=""collapse-link""><i class=""fa fa-chevron-up""></i></a>
                </li>
            </ul>
            <div class=""clearfix""></div>
        </div>

        <div class=""x_content"">
            <div class=""col-md-12 col-sm-12 col-xs-12"">
");
#nullable restore
#line 109 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                 if (Model.GetStudentListViewModel.Count == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-danger \">\r\n                        رکوردی یافت نشد\r\n                    </div>\r\n");
#nullable restore
#line 114 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <div id=""datatable-checkbox_wrapper"" class=""dataTables_wrapper form-inline dt-bootstrap no-footer"">

                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <input type=""button"" id=""addToClass"" class=""btn btn-success"" value=""افزودن به آزمون"">
");
#nullable restore
#line 121 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                              
                                int rowCountStudent = 1;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <table id=""addStudent"" class=""display"" style=""width:100%"">

                            <thead>
                                <tr role=""row"">
                                    <th><input type=""checkbox"" id=""checkAllStudents"" /></th>
                                    <th>ردیف</th>
                                    <th>تصویر فراگیر</th>
                                    <th>نام فراگیر </th>
                                    <th>نام خانوادگی</th>
                                    <th>شماره موبایل</th>
                                    <th>نام کاربری</th>
                                </tr>
                            </thead>

                            <tbody>

");
#nullable restore
#line 142 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                 foreach (var teacherModel in Model.GetStudentListViewModel)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr role=\"row\" class=\"odd\">\r\n                                        <td>\r\n                                            <input type=\"checkbox\" class=\"checkBoxStudent\"");
            BeginWriteAttribute("value", " value=\"", 6821, "\"", 6849, 1);
#nullable restore
#line 146 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
WriteAttributeValue("", 6829, teacherModel.UserId, 6829, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 149 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                       Write(rowCountStudent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            <img class=\"img-circle\" height=\"50\"");
            BeginWriteAttribute("src", " src=\"", 7182, "\"", 7224, 2);
            WriteAttributeValue("", 7188, "/UserAvatar/", 7188, 12, true);
#nullable restore
#line 152 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
WriteAttributeValue("", 7200, teacherModel.UserAvatar, 7200, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 155 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                       Write(teacherModel.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 158 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                       Write(teacherModel.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 161 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                       Write(teacherModel.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 164 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                       Write(teacherModel.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 167 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                    rowCountStudent++;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<hr class=""col-md-12"" />
<div class=""item form-group"">
    <div class=""col-md-12 col-sm-12 col-xs-12 col-md-offset-5"">
        <a");
            BeginWriteAttribute("href", " href=\"", 8404, "\"", 8455, 2);
            WriteAttributeValue("", 8411, "/Admin/Quiz/AddQuestions/", 8411, 25, true);
#nullable restore
#line 182 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
WriteAttributeValue("", 8436, ViewData["ExamId"], 8436, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">\r\n            مرحله قبلی\r\n        </a>\r\n\r\n        <a href=\"/Admin/Quiz/Index\" class=\"btn btn-success\">\r\n            ثبت آزمون\r\n        </a>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.5.1.js""></script>
    <script src=""https://cdn.datatables.net/1.11.5/js/jquery.dataTables.min.js""></script>

    <script>

            $(document).ready(function() {

                $(""#checkAllStudents"").click(function() {
                    $("".checkBoxStudent"").prop('checked',
                        $(this).prop('checked'));
                });

                $(""#addToClass"").click(function() {
                    var selectedIDs = new Array();
                    $('input:checkbox.checkBoxStudent').each(function() {
                        if ($(this).prop('checked')) {
                            selectedIDs.push($(this).val());
                        }
                    });

                    $.ajax({
                        type: ""POST"",
                        url: ""/Home/AddStudentToExam"",
                        data: { ""userId"": selectedIDs, ""examId"": ");
#nullable restore
#line 217 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                                            Write(ViewData["examId"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" },\r\n\r\n                        success: function(response) {\r\n                            window.location.href = \"/Admin/Quiz/AddStudentToExam/");
#nullable restore
#line 220 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                                                            Write(ViewData["examId"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                        },
                        failure: function(response) {
                            alert(response.responseText);
                        },
                        error: function(response) {
                            alert(response.responseText);
                        }

                    });

                });

            });

           $(document).ready(function() {

                $(""#checkAll"").click(function() {
                    $("".checkBox"").prop('checked',
                        $(this).prop('checked'));
                });

                $(""#delete"").click(function() {
                    var selectedIDs = new Array();
                    $('input:checkbox.checkBox').each(function() {
                        if ($(this).prop('checked')) {
                            selectedIDs.push($(this).val());
                        }
                    });

                    $.ajax({
                        type: ""POST"",
        ");
                WriteLiteral("                url: \"/Home/DeleteStudentFromExam\",\r\n                        data: { \"userId\": selectedIDs, \"examId\": ");
#nullable restore
#line 253 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                                            Write(ViewData["examId"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(" },\r\n\r\n                        success: function(response) {\r\n                            window.location.href =\"/Admin/Quiz/AddStudentToExam/");
#nullable restore
#line 256 "C:\Users\M.R\source\repos\Core\Example04\LearningManagementSystem\Lms.Web\Pages\Admin\Quiz\AddStudentToExam.cshtml"
                                                                           Write(ViewData["examId"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@""";
                        },
                        failure: function(response) {
                            alert(response.responseText);
                        },
                        error: function(response) {
                            alert(response.responseText);
                        }

                    });
                });
           });

            $(document).ready(function () {
                $('#addStudent').DataTable();
            });

            $(document).ready(function () {
                $('#deleteStudent').DataTable();
            });

    </script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lms.Web.Pages.Admin.Quiz.AddStudentToExamModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.Quiz.AddStudentToExamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Lms.Web.Pages.Admin.Quiz.AddStudentToExamModel>)PageContext?.ViewData;
        public Lms.Web.Pages.Admin.Quiz.AddStudentToExamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
