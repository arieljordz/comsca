#pragma checksum "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\LoanSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7500667658265c4d1227feca03a2e13756668745"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LoanSchedule), @"mvc.1.0.view", @"/Views/Home/LoanSchedule.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LoanSchedule.cshtml", typeof(AspNetCore.Views_Home_LoanSchedule))]
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
#line 1 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\_ViewImports.cshtml"
using COMSCA;

#line default
#line hidden
#line 2 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\_ViewImports.cshtml"
using COMSCA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7500667658265c4d1227feca03a2e13756668745", @"/Views/Home/LoanSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e380d3119181dee6a761425a0db5b1bdbc6f04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LoanSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<COMSCA.Models.tbl_loanSchedule>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_schedule"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\LoanSchedule.cshtml"
  
    ViewData["Title"] = "Loan Schedule";

#line default
#line hidden
            BeginContext(90, 2260, true);
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"" style=""padding-top: 60px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Loans Schedules</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Loans Schedules</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""card card-secondary"">
                <div class=""card-header");
            WriteLiteral(@""">
                    <h3 class=""card-title""><i class=""fas fa-edit pr-2""></i>Loans Schedules</h3>
                </div>

                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-5"">
                            <div class=""dataTables_wrapper table-responsive dt-bootstrap4"">
                                <table id=""tbl_Payees"" class=""table table-bordered table-hover text-center"" style=""width:100%""></table>
                            </div>

                            <div class=""card card-primary card-outline pt-2"">
                                <a class=""d-block w-100"" data-toggle=""collapse"" href=""#AmountDetails"">
                                    <div class=""card-header"">
                                        <h4 class=""card-title w-100"">
                                            Amount Details
                                        </h4>
                                    </div>
                                <");
            WriteLiteral("/a>\r\n                                <div id=\"Amount Details\" class=\"collapse show\" data-parent=\"#accordion\">\r\n                                    <div class=\"card-body\">\r\n                                        ");
            EndContext();
            BeginContext(2350, 1865, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7500667658265c4d1227feca03a2e137566687456767", async() => {
                BeginContext(2399, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(2446, 31, false);
#line 52 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\LoanSchedule.cshtml"
                                       Write(Html.HiddenFor(x => x.MemberID));

#line default
#line hidden
                EndContext();
                BeginContext(2477, 348, true);
                WriteLiteral(@"
                                            <div class=""row"">
                                                <div class=""col-7"">
                                                    <div for=""Date"">Date</div>
                                                    <div class=""form-group"">
                                                        ");
                EndContext();
                BeginContext(2826, 106, false);
#line 57 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\LoanSchedule.cshtml"
                                                   Write(Html.DropDownList("ActiveDateID", ViewData["cmbloandates"] as SelectList, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2932, 58, true);
                WriteLiteral("\r\n                                                        ");
                EndContext();
                BeginContext(2991, 46, false);
#line 58 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\LoanSchedule.cshtml"
                                                   Write(Html.ValidationMessageFor(x => x.ActiveDateID));

#line default
#line hidden
                EndContext();
                BeginContext(3037, 1171, true);
                WriteLiteral(@"
                                                    </div>
                                                </div>
                                                <div class=""col-5"">
                                                    <div class=""form-group"">
                                                        <div for=""Amount"">Amount</div>
                                                        <input type=""text"" placeholder=""0.00"" maxlength=""22"" name=""Amount"" class=""form-control mask-money"" id=""Amount"" required=""required"">
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""row"">
                                                <div class=""col-12"">
                                                    <button type=""submit"" class=""btn btn-success float-right"" id=""btn_save_schedule""><i class=""fas fa-save pr-2""></i>Save</button>
 ");
                WriteLiteral("                                               </div>\r\n                                            </div>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4215, 1260, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>

                        </div>
                        <div class=""col-md-7"">
                            <div class=""card card-secondary"">
                                <div class=""card-header"">
                                    <h3 class=""card-title""><i class=""fas fa-edit pr-2""></i>Calendar</h3>
                                </div>

                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-md-12"">
                                            <div class=""card card-primary"">
                                                <div class=""card-body p-0"">
                                                    <!-- THE CALENDAR -->
                                                    <div id=""calendar""></div>
                                                </div>
         ");
            WriteLiteral("                                   </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"card-footer\">\r\n");
            EndContext();
            BeginContext(5647, 369, true);
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""card-footer"">

                </div>
            </div>
        </div><!--/. container-fluid -->
    </section>
    <!-- /.content -->
</div>
<!-- /.content-wrapper -->
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6035, 8785, true);
                WriteLiteral(@"
    <script>

        $(document).ready(function () {
            var member_id = 0;

            LoadMembers();
            function LoadMembers() {
                $('#tbl_Payees').DataTable({
                    destroy: true,
                    responsive: true,
                    processing: false,
                    search: true,
                    stateSave: true,
                    info: true,
                    searching: true,
                    paging: true,
                    //order: [[1, ""asc""], [2, ""asc""]],
                    //lengthMenu: [[5, 10, 20, -1], [5, 10, 20, ""All""]],
                    ajax: {
                        ""url"": ""../Membership/LoadMembers"",
                        ""type"": ""POST"",
                        ""datatype"": ""JSON""
                    },
                    columns:
                        [
                            { data: ""MemberID"", visible: false, ""orderable"": false },
                            { data: ""FullName"", titl");
                WriteLiteral(@"e: ""Full Name"", sClass: ""dt-body-center"", orderable: false },
                        ]
                });

                $('#tbl_Payees tbody').off().on('click', 'tr', function (e) {
                    e.preventDefault();
                    if (!$(this).hasClass(""dtactive"")) {
                        $(this).parent().find(""tr"").removeClass(""dtactive"");
                        $(this).addClass(""dtactive"");
                        member_id = SelectedValue(""tbl_Payees"", ""MemberID"");
                        $(""[name='MemberID']"").val(member_id);
                    } else {
                        $(this).removeClass(""dtactive"");
                        $(""[name='MemberID']"").val(0);
                    }
                });
            }

            //$(""#btn_save_schedule"").click(function (e) {
            //    e.preventDefault();
            //    if (member_id != 0) {
            //        SaveLoanSchedule();
            //    } else {
            //        Swal.fire(""Warning!""");
                WriteLiteral(@", ""Please select a Member first."", ""warning"");
            //    }
            //});

            ValidateContirbution();
            function ValidateContirbution() {
                $.validator.setDefaults({
                    submitHandler: function () {
                        if (member_id != 0) {
                            SaveLoanSchedule();
                        } else {
                            Swal.fire(""Warning!"", ""Please select a Member first."", ""warning"");
                        }
                    }
                });
                $('#form_schedule').validate({
                    rules: {
                        Amount: {
                            required: true
                        },
                    },
                    messages: {
                        Amount: {
                            required: ""This field is required""
                        },
                    },
                    errorElement: 'span',
                    erro");
                WriteLiteral(@"rPlacement: function (error, element) {
                        error.addClass('invalid-feedback');
                        element.closest('.form-group').append(error);
                    },
                    highlight: function (element, errorClass, validClass) {
                        $(element).addClass('is-invalid');
                    },
                    unhighlight: function (element, errorClass, validClass) {
                        $(element).removeClass('is-invalid');
                    }
                });
            }

            function SaveLoanSchedule() {
                $.ajax({
                    url: ""../Loans/SaveLoanSchedule"",
                    type: 'POST',
                    data: LoanScheduleDtls(),
                    cache: false,
                    contentType: false,
                    processData: false,
                    success: function (res) {
                        if (res.success == true) {
                            Swal.fire({
");
                WriteLiteral(@"                                text: ""Successfully saved."",
                                icon: ""success"",
                                showCancelButton: false,
                                confirmButtonColor: '#28a745',
                                confirmButtonText: ""Ok""
                            }).then((result) => {
                                if (result.isConfirmed) {
                                    $(""#form_schedule"").trigger(""reset"");
                                    $(""[name='MemberID']"").val(0);
                                }
                            });
                        } else {
                            Swal.fire(""Error!"", res.message, ""error"");
                        }
                    }
                });
            }

            function LoanScheduleDtls() {
                var formData = new FormData();
                formData.append('MemberID', $(""[name='MemberID']"").val());
                formData.append('ActiveDateID', $(""");
                WriteLiteral(@"[name='ActiveDateID']"").val());
                formData.append('Amount', $(""[name='Amount']"").val());
                return formData;
            }


            //initialize the calendar
            //Date for the calendar events (dummy data)
            var dateCurr = new Date();

            var Calendar = FullCalendar.Calendar;
            var calendarEl = document.getElementById('calendar');

            // initialize the external events
            GetLoanSchedules(dateCurr);
            function GetLoanSchedules(date) {
                var strDate = date.toUTCString();
                console.log(""_Next Date: "" + strDate);
                var events = [];
                $.ajax({
                    url: '../Loans/GetLoanSchedules',
                    type: 'GET',
                    data: { start: strDate },
                    success: function (res) {
                        //console.log(""success"");
                        for (var i = 0; i < res.data.length; i++) {
   ");
                WriteLiteral(@"                         events.push({
                                title: res.data[i].title,
                                start: res.data[i].start,
                                end: res.data[i].end,
                                backgroundColor: '#f56954', //red
                                borderColor: '#f56954', //red
                                allDay: true,
                            });
                        }
                        LoadCalendar(events);
                        console.log(""Events: "" + events);
                    },
                });

            }

            function LoadCalendar(events) {
                var calendar = new Calendar(calendarEl, {
                    headerToolbar: {
                        //left: 'prev,next today',
                        left: 'prev,next',
                        center: 'title',
                        //right: 'dayGridMonth,timeGridWeek,timeGridDay'
                        right: 'dayGridMonth'
   ");
                WriteLiteral(@"                 },
                    themeSystem: 'bootstrap',
                    //datesSet: function () {
                    //    GetLoanSchedules(GetCurrentDate(""next""));
                    //},
                    events: events,
                    editable: true,

                });
                calendar.render();
            }

            $('body').on('click', '.fc-prev-button', function () {
                //GetLoanSchedules(GetCurrentDate());
            });

            $('body').on('click', '.fc-next-button', function () {
                //GetLoanSchedules(GetCurrentDate());
            });

            function GetCurrentDate() {
                console.log($('.fc-toolbar-title')[0].innerText.split("" "")[0]);
                console.log($('.fc-toolbar-title')[0].innerText.split("" "")[1]);

                var monthName = $('.fc-toolbar-title')[0].innerText.split("" "")[0];
                var Year = $('.fc-toolbar-title')[0].innerText.split("" "")[1];
            ");
                WriteLiteral(@"    var Monthss = GetMonth(monthName);
                var Month = Monthss;

                console.log(""Monthss "" + Monthss);
                //console.log(Year);

                var currDate = new Date(Year + ""-"" + Month + ""-"" + 2);
                console.log(""click strdate "" + currDate.toUTCString());
                console.log(""click date "" + currDate);
                var formDate = new Date(currDate);
                console.log(""form date "" + formDate);
                return formDate;
            }
        });

        ActiveMenu(""#schedule"");
    </script>
");
                EndContext();
            }
            );
            BeginContext(14823, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COMSCA.Models.tbl_loanSchedule> Html { get; private set; }
    }
}
#pragma warning restore 1591
