#pragma checksum "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\FileMaintenance\Fees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f42aa0e62c305dd68d5c8aa02bba6c615d152e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileMaintenance_Fees), @"mvc.1.0.view", @"/Views/FileMaintenance/Fees.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FileMaintenance/Fees.cshtml", typeof(AspNetCore.Views_FileMaintenance_Fees))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f42aa0e62c305dd68d5c8aa02bba6c615d152e2b", @"/Views/FileMaintenance/Fees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e380d3119181dee6a761425a0db5b1bdbc6f04", @"/Views/_ViewImports.cshtml")]
    public class Views_FileMaintenance_Fees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_fees"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\FileMaintenance\Fees.cshtml"
  
    ViewData["Title"] = "Fees";

#line default
#line hidden
            BeginContext(40, 1243, true);
            WriteLiteral(@"

<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"" style=""padding-top: 60px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Fees</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Fees</li>
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
            WriteLiteral("    <h3 class=\"card-title\"><i class=\"fa fa-user pr-2\"></i>Fee Details</h3>\r\n                </div>\r\n                <input type=\"hidden\" name=\"FeeDtlsID\" />\r\n                <div class=\"card-body\">\r\n                    ");
            EndContext();
            BeginContext(1283, 1733, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f42aa0e62c305dd68d5c8aa02bba6c615d152e2b5578", async() => {
                BeginContext(1328, 243, true);
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-3\">\r\n                                <div>Select Fee</div>\r\n                                <div class=\"form-group\">\r\n                                    ");
                EndContext();
                BeginContext(1572, 94, false);
#line 39 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\FileMaintenance\Fees.cshtml"
                               Write(Html.DropDownList("FeeID", ViewData["cmbfees"] as SelectList, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1666, 1343, true);
                WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-3"">
                                <div for=""Amount"">Amount</div>
                                <div class=""input-group"">
                                    <div class=""input-group-prepend"">
                                        <span class=""input-group-text"">₱</span>
                                    </div>
                                    <input type=""number"" min=""0"" max=""99999999"" name=""Amount"" class=""form-control text-right"" id=""Amount"">
                                </div>
                            </div>
                            <div class=""col-2 pt-4 mt-2"">
                                <div class=""icheck-success d-inline"">
                                    <input type=""checkbox"" name=""IsActive"" id=""IsActive"" value=""true"">
                                    <label for=""IsActive"">Set as Active</label>
                                </div>
       ");
                WriteLiteral(@"                     </div>
                            <div class=""col-3 pt-4"">
                                <button type=""submit"" class=""btn btn-success""><i class=""fa fa-save pr-2""></i>Save</button>
                            </div>
                        </div>
                      
                    ");
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
            BeginContext(3016, 655, true);
            WriteLiteral(@"
                    <div class=""row pb-3 pt-3"">
                        <div class=""col-md-12"">
                            <div class=""dataTables_wrapper table-responsive dt-bootstrap4"">
                                <table id=""tbl_Fees"" class=""table table-bordered table-hover text-center"" style=""width:100%""></table>
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
                BeginContext(3690, 10309, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            ValidateFee();
            function ValidateFee() {
                $.validator.setDefaults({
                    submitHandler: function () {
                        SaveFee();
                    }
                });
                $('#form_fees').validate({
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
                    errorPlacement: function (error, element) {
                        error.addClass('invalid-feedback');
                        element.closest('.form-group').append(error);
                    },
                    highlight: function (element, errorClass, validClass)");
                WriteLiteral(@" {
                        $(element).addClass('is-invalid');
                        console.log(element);
                    },
                    unhighlight: function (element, errorClass, validClass) {
                        $(element).removeClass('is-invalid');
                        console.log(element);
                    }
                });
            }

            LoadFees();
            function LoadFees() {
                $('#tbl_Fees').DataTable({
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
                        ""url"": ""../FileMaintenance/LoadFees"",
                       ");
                WriteLiteral(@" ""type"": ""POST"",
                        ""datatype"": ""JSON""
                    },
                    columns:
                        [
                            { data: ""FeeID"", visible: false, ""orderable"": false },
                            { data: ""Description"", title: ""Fee Description"", sClass: ""dt-body-center"", orderable: false },
                            { data: ""Amount"", title: ""Amount"", sClass: ""dt-body-right"", orderable: false, render: $.fn.dataTable.render.number(',', '.', 2, '₱ ') },
                            {
                                data: ""IsActive"", title: ""Status"", sClass: ""dt-body-center"", render: function (data) {
                                    if (data == true) {
                                        return ""<span class='badge bg-primary'>Active</span>""
                                    }
                                    else {
                                        return ""<span class='badge bg-danger'>Inactive</span>""
                         ");
                WriteLiteral(@"           }
                                }
                            },
                            {
                                data: ""FeeDtlsID"", title: ""Action"", render: function (data) {
                                    return ""<div class='row justify-content-center'>"" +
                                        ""<div class='dropdown dropleft'>"" +
                                        ""<button id='btnbars' type='button' class='btn btn-sm btn-success btnbars' data-toggle='dropdown'>"" +
                                        ""<i class='fa fa-bars'></i>"" +
                                        ""</button> <div class='dropdown-menu'>"" +
                                        ""<div class='container fluid'> "" +
                                        ""<a id='btnUpdate' class='btn btn-warning btn-sm fa fa-edit col-sm-12' style='margin-bottom: 3px; margin-top: 3px;'>"" +
                                        ""&nbspUpdate</a>"" +
                                        ""<br />"" +
   ");
                WriteLiteral(@"                                     ""<a id='btnDelete' class='btn btn-danger btn-sm fa fa-trash col-sm-12' style='margin-bottom: 3px; margin-top: 3px; color: white;'>"" +
                                        ""&nbspDelete</a>"" +
                                        ""</div></div></div ></div>"";
                                }
                            }
                        ]
                });

                $('#tbl_Fees tbody').off().on('click', 'tr', function (e) {
                    if ($(e.target).is(""[id^=btnUpdate],[id^=btnUpdate] i"")) {
                        UpdateFee();
                    }
                    else if ($(e.target).is(""[id^=btnDelete],[id^=btnDelete] i"")) {
                        RemoveFee();
                    }
                    else if (!$(e.target).is(""[id^=btnbars],[id^=btnbars] i"")) {
                        if (!$(this).hasClass(""dtactive"")) {
                            $(this).parent().find(""tr"").removeClass(""dtactive"");
               ");
                WriteLiteral(@"             $(this).addClass(""dtactive"");
                            $(""[name='FeeDtlsID']"").val(SelectedValue(""tbl_Fees"", ""FeeDtlsID""));
                        } else {
                            $(this).removeClass(""dtactive"");
                            $(""[name='FeeDtlsID']"").val(0);
                            $(""#form_fees"").trigger(""reset"");
                        }
                    }
                });


                function UpdateFee() {
                    if ($(""[name='FeeDtlsID']"").val() != 0) {
                        $.ajax({
                            url: ""../FileMaintenance/UpdateFee?FeeDtlsID= "" + $(""[name='FeeDtlsID']"").val(),
                            type: ""GET"",
                            cache: false,
                            contentType: false,
                            processData: false,
                            success: function (res) {
                                if (res.data != null) {
                                    $(""[name=");
                WriteLiteral(@"'FeeDtlsID']"").val(res.data.FeeDtlsID);
                                    $(""[name='FeeID']"").val(res.data.FeeID);
                                    $(""[name='Amount']"").val(res.data.Amount);
                                    $(""[name='IsActive']"").prop('checked', res.data.IsActive);
                                }
                            }
                        });
                    }
                    else {
                        Swal.fire('Information!', 'Please select a record first.', 'info');
                    }
                }

                function RemoveFee() {
                    if ($(""[name='FeeDtlsID']"").val() != 0) {
                        Swal.fire({
                            text: ""Are you sure you want to delete this record?"",
                            icon: 'warning',
                            showCancelButton: true,
                            confirmButtonColor: '#28a745',
                            cancelButtonColor: '#dc3545',
     ");
                WriteLiteral(@"                       confirmButtonText: 'Yes, delete it!'
                        }).then((result) => {
                            if (result.isConfirmed) {
                                $.ajax({
                                    url: '../FileMaintenance/RemoveFee?&FeeDtlsID=' + $(""[name='FeeDtlsID']"").val(),
                                    type: 'POST',
                                    success: function (res) {
                                        if (res.success == true) {
                                            Swal.fire('Success!', 'Record has been deleted.', 'success');
                                            LoadFees();
                                            $(""[name='FeeDtlsID']"").val(0);
                                        } else {
                                            Swal.fire('Error!', res.msg, 'error');
                                        }
                                    }
                                });
                         ");
                WriteLiteral(@"   }
                        });
                    }
                    else {
                        Swal.fire('Information!', 'Please select a record first.', 'info');
                    }
                }

            }

            function SaveFee() {
                $.ajax({
                    url: ""../FileMaintenance/SaveFee"",
                    type: 'POST',
                    data: FeeDetails(),
                    cache: false,
                    contentType: false,
                    processData: false,
                    success: function (res) {
                        if (res.success == true) {
                            Swal.fire({
                                text: ""Successfully saved."",
                                icon: ""success"",
                                showCancelButton: false,
                                confirmButtonColor: '#28a745',
                                confirmButtonText: ""Ok""
                            }).then((result)");
                WriteLiteral(@" => {
                                if (result.isConfirmed) {
                                    $(""#form_fees"").trigger(""reset"");
                                    LoadFees();
                                }
                            });
                            $(""[name='FeeDtlsID']"").val(0);
                        } else {
                            Swal.fire(""Error!"", res.message, ""error"");
                        }
                    }
                });
            }

            function FeeDetails() {
                var formData = new FormData();
                formData.append('FeeDtlsID', $(""[name='FeeDtlsID']"").val());
                formData.append('FeeID', $(""[name='FeeID']"").val());
                formData.append('Amount', $(""[name='Amount']"").val());
                formData.append('IsActive', $('input[name=""IsActive""]:checked').val());
                console.log($('input[name=""IsActive""]:checked').val());
                return formData;
            }
                WriteLiteral("\n\r\n\r\n\r\n\r\n        });\r\n\r\n        ActiveMenu(\"#fees\");\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591