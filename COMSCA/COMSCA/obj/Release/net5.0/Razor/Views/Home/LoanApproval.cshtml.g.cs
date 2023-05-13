#pragma checksum "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\LoanApproval.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b97360a9760636f9c82417270ad3f2260ca5f43d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LoanApproval), @"mvc.1.0.view", @"/Views/Home/LoanApproval.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LoanApproval.cshtml", typeof(AspNetCore.Views_Home_LoanApproval))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b97360a9760636f9c82417270ad3f2260ca5f43d", @"/Views/Home/LoanApproval.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e380d3119181dee6a761425a0db5b1bdbc6f04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LoanApproval : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<COMSCA.Models.tbl_loanSchedule>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\LoanApproval.cshtml"
  
    ViewData["Title"] = "Loan Approval";

#line default
#line hidden
            BeginContext(90, 1165, true);
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"" style=""padding-top: 60px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Loan Approval</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Loans</li>
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
                <div class=""card-header"">
        ");
            WriteLiteral("            <h3 class=\"card-title\"><i class=\"fas fa-edit pr-2\"></i>List of Loan for Approval</h3>\r\n                </div>\r\n\r\n                ");
            EndContext();
            BeginContext(1256, 37, false);
#line 34 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\LoanApproval.cshtml"
           Write(Html.HiddenFor(x => x.LoanScheduleID));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 1427, true);
            WriteLiteral(@"
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""dataTables_wrapper table-responsive dt-bootstrap4"">
                                <table id=""tbl_Loans"" class=""table table-bordered table-hover text-center"" style=""width:100%""></table>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""card-footer"">

                </div>
            </div>

            <div class=""card card-secondary"">
                <div class=""card-header"">
                    <h3 class=""card-title""><i class=""fa fa-money pr-2""></i>Collection Details</h3>
                </div>

                <div class=""card-body"">

                    <div class=""row"">
                        <div class=""col-3"">
                            <div for=""TotalCollection"" class=""text-primary"">Total Collection</div>
        ");
            WriteLiteral(@"                    <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text text-primary"">₱</span>
                                </div>
                                <input type=""text"" min=""0"" max=""99999999"" class=""form-control text-right text-primary"" id=""TotalCollection"" readonly=""readonly""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2720, "\"", 2752, 1);
#line 64 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\LoanApproval.cshtml"
WriteAttributeValue("", 2728, ViewBag.TotalCollection, 2728, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2753, 634, true);
            WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""col-3"">
                            <div for=""AccountReceivable"" class=""text-warning"">Account Receivable</div>
                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text text-warning"">₱</span>
                                </div>
                                <input type=""text"" min=""0"" max=""99999999"" class=""form-control text-right text-warning"" id=""Account Receivable"" readonly=""readonly""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3387, "\"", 3414, 1);
#line 73 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\LoanApproval.cshtml"
WriteAttributeValue("", 3395, ViewBag.TotalLoans, 3395, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3415, 1194, true);
            WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""card-footer"">

                </div>
            </div>

            <div class=""card card-secondary"">
                <div class=""card-header"">
                    <h3 class=""card-title""><i class=""fas fa-edit pr-2""></i>List of Approved Loans</h3>
                </div>

                <input type=""hidden"" name=""ApprovedLoanID"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <div class=""dataTables_wrapper table-responsive dt-bootstrap4"">
                                <table id=""tbl_ApprovedLoans"" class=""table table-bordered table-hover text-center"" style=""width:100%""></table>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""card-footer");
            WriteLiteral("\">\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div><!--/. container-fluid -->\r\n    </section>\r\n    <!-- /.content -->\r\n</div>\r\n<!-- /.content-wrapper -->\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4628, 10697, true);
                WriteLiteral(@"
    <script>

        $(document).ready(function () {

            LoadAppliedLoans();
            function LoadAppliedLoans() {
                $('#tbl_Loans').DataTable({
                    destroy: true,
                    responsive: true,
                    processing: false,
                    search: true,
                    stateSave: true,
                    info: true,
                    searching: true,
                    paging: true,
                    order: [[1, ""asc""], [2, ""asc""]],
                    lengthMenu: [[5, 10, 20, -1], [5, 10, 20, ""All""]],
                    ajax: {
                        ""url"": ""../Loans/LoadAppliedLoans"",
                        ""type"": ""POST"",
                        ""datatype"": ""JSON""
                    },
                    columns:
                        [
                            { data: ""MemberID"", visible: false, ""orderable"": false },
                            { data: ""FullName"", title: ""Full Name"", sClass: ""dt");
                WriteLiteral(@"-body-center"", orderable: false },
                            { data: ""Amount"", title: ""Amount"", sClass: ""dt-body-right"", orderable: false, render: $.fn.dataTable.render.number(',', '.', 2, '₱ ') },
                            { data: ""DateSchedule"", title: ""Date Scheduled"", sClass: ""dt-body-center"", orderable: false },
                            {
                                data: ""IsApproved"", title: ""Status"", sClass: ""dt-body-center"", render: function (data) {
                                    if (data == null) {
                                        return ""<span class='badge bg-danger'>For Approval</span>""
                                    }
                                }
                            },
                            {
                                data: ""LoanScheduleID"", title: ""Action"", render: function (data) {
                                    return ""<div class='row justify-content-center'>"" +
                                        ""<div class='dropdown ");
                WriteLiteral(@"dropleft'>"" +
                                        ""<button id='btnbars' type='button' class='btn btn-sm btn-success btnbars' data-toggle='dropdown'>"" +
                                        ""<i class='fa fa-bars'></i>"" +
                                        ""</button> <div class='dropdown-menu'>"" +
                                        ""<div class='container fluid'> "" +
                                        ""<a id='btnApproved' class='btn btn-warning btn-sm fa fa-edit col-sm-12' style='margin-bottom: 3px; margin-top: 3px;'>"" +
                                        ""&nbspApproved</a>"" +
                                        ""<br />"" +
                                        ""<a id='btnDisapproved' class='btn btn-danger btn-sm fa fa-edit col-sm-12' style='margin-bottom: 3px; margin-top: 3px; color: white;'>"" +
                                        ""&nbspDisapproved</a>"" +
                                        ""</div></div></div ></div>"";
                                }
       ");
                WriteLiteral(@"                     }
                        ]
                });

                $('#tbl_Loans tbody').off().on('click', 'tr', function (e) {
                    if ($(e.target).is(""[id^=btnApproved],[id^=btnApproved] i"")) {
                        ApprovedDisApproved(true);
                    }
                    else if ($(e.target).is(""[id^=btnDisapproved],[id^=btnDisapproved] i"")) {
                        ApprovedDisApproved(false);
                    }
                    else if (!$(e.target).is(""[id^=btnbars],[id^=btnbars] i"")) {
                        if (!$(this).hasClass(""dtactive"")) {
                            $(this).parent().find(""tr"").removeClass(""dtactive"");
                            $(this).addClass(""dtactive"");
                            $(""[name='LoanScheduleID']"").val(SelectedValue(""tbl_Loans"", ""LoanScheduleID""));
                        } else {
                            $(this).removeClass(""dtactive"");
                            $(""[name='LoanScheduleID");
                WriteLiteral(@"']"").val(0);
                        }
                    }
                });
            }

            function ApprovedDisApproved(isTrue) {
                if ($(""[name='LoanScheduleID']"").val() != 0) {
                    $.ajax({
                        url: ""../Loans/ApprovedDisApproved?LoanScheduleID= "" + $(""[name='LoanScheduleID']"").val() + ""&isTrue="" + isTrue,
                        type: ""POST"",
                        success: function (res) {
                            if (res.success) {
                                if (res.success) {
                                    if (isTrue) {
                                        LoadApprovedLoans();
                                    }
                                    LoadAppliedLoans();
                                }
                            }
                            $(""[name='LoanScheduleID']"").val(0);
                        }
                    });
                }
                else {
            ");
                WriteLiteral(@"        Swal.fire('Information!', 'Please select a record first.', 'info');
                }
            }

            LoadApprovedLoans();
            function LoadApprovedLoans() {
                $('#tbl_ApprovedLoans').DataTable({
                    destroy: true,
                    responsive: true,
                    processing: false,
                    search: true,
                    stateSave: true,
                    info: true,
                    searching: true,
                    paging: true,
                    order: [[1, ""asc""], [2, ""asc""]],
                    lengthMenu: [[5, 10, 20, -1], [5, 10, 20, ""All""]],
                    ajax: {
                        ""url"": ""../Loans/LoadApprovedLoans"",
                        ""type"": ""POST"",
                        ""datatype"": ""JSON""
                    },
                    columns:
                        [
                            { data: ""MemberID"", visible: false, ""orderable"": false },
                ");
                WriteLiteral(@"            { data: ""FullName"", title: ""Full Name"", sClass: ""dt-body-center"", orderable: false },
                            { data: ""Amount"", title: ""Amount"", sClass: ""dt-body-right"", orderable: false, render: $.fn.dataTable.render.number(',', '.', 2, '₱ ') },
                            { data: ""DateReleased"", title: ""Date Released"", sClass: ""dt-body-center"", orderable: false },
                            {
                                data: ""IsReleased"", title: ""Status"", sClass: ""dt-body-center"", render: function (data) {
                                    if (data == true) {
                                        return ""<span class='badge bg-primary'>Released</span>""
                                    }
                                    else {
                                        return ""<span class='badge bg-warning'>For Releasing</span>""
                                    }
                                }
                            },
                            {
       ");
                WriteLiteral(@"                         data: ""ApprovedLoanID"", title: ""Action"", render: function (data) {
                                    return ""<div class='row justify-content-center'>"" +
                                        ""<div class='dropdown dropleft'>"" +
                                        ""<button id='btnbars' type='button' class='btn btn-sm btn-success btnbars' data-toggle='dropdown'>"" +
                                        ""<i class='fa fa-bars'></i>"" +
                                        ""</button> <div class='dropdown-menu'>"" +
                                        ""<div class='container fluid'> "" +
                                        ""<a id='btnReleased' class='btn btn-warning btn-sm fa fa-edit col-sm-12' style='margin-bottom: 3px; margin-top: 3px;'>"" +
                                        ""&nbspRelease Loan</a>"" +
                                        ""<br />"" +
                                        ""<a id='btnForApproval' class='btn btn-danger btn-sm fa fa-edit col-s");
                WriteLiteral(@"m-12' style='margin-bottom: 3px; margin-top: 3px; color: white;'>"" +
                                        ""&nbspFor Approval</a>"" +
                                        ""</div></div></div ></div>"";
                                }
                            }
                        ]
                });

                $('#tbl_ApprovedLoans tbody').off().on('click', 'tr', function (e) {
                    if ($(e.target).is(""[id^=btnReleased],[id^=btnReleased] i"")) {
                        ReleasedLoan(true);
                    }
                    else if ($(e.target).is(""[id^=btnForApproval],[id^=btnForApproval] i"")) {
                        ReleasedLoan(false);
                    }
                    else if (!$(e.target).is(""[id^=btnbars],[id^=btnbars] i"")) {
                        if (!$(this).hasClass(""dtactive"")) {
                            $(this).parent().find(""tr"").removeClass(""dtactive"");
                            $(this).addClass(""dtactive"");
              ");
                WriteLiteral(@"              $(""[name='ApprovedLoanID']"").val(SelectedValue(""tbl_ApprovedLoans"", ""ApprovedLoanID""));
                        } else {
                            $(this).removeClass(""dtactive"");
                            $(""[name='ApprovedLoanID']"").val(0);
                        }
                    }
                });
            }

            function ReleasedLoan(isTrue) {
                if ($(""[name='ApprovedLoanID']"").val() != 0) {
                    $.ajax({
                        url: ""../Loans/ReleasedLoan?LoanScheduleID= "" + $(""[name='ApprovedLoanID']"").val() + ""&isTrue="" + isTrue,
                        type: ""POST"",
                        success: function (res) {
                            if (res.success) {
                                if (!isTrue) {
                                    LoadAppliedLoans();
                                }
                            }
                            else {
                                Swal.fire('Information!'");
                WriteLiteral(@", res.message, 'info');
                            }
                            LoadApprovedLoans();
                            $(""[name='ApprovedLoanID']"").val(0);
                        }
                    });
                }
                else {
                    Swal.fire('Information!', 'Please select a record first.', 'info');
                }
            }



        });

        ActiveMenu(""#loans"");
    </script>
");
                EndContext();
            }
            );
            BeginContext(15328, 2, true);
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
