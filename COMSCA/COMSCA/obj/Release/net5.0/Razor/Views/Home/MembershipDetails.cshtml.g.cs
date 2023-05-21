#pragma checksum "D:\MY PROJECTS\GIT-COMSCA\comsca\COMSCA\COMSCA\Views\Home\MembershipDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fb6c9a44ee9bd9092824968620d9a691386b1af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MembershipDetails), @"mvc.1.0.view", @"/Views/Home/MembershipDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/MembershipDetails.cshtml", typeof(AspNetCore.Views_Home_MembershipDetails))]
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
#line 1 "D:\MY PROJECTS\GIT-COMSCA\comsca\COMSCA\COMSCA\Views\_ViewImports.cshtml"
using COMSCA;

#line default
#line hidden
#line 2 "D:\MY PROJECTS\GIT-COMSCA\comsca\COMSCA\COMSCA\Views\_ViewImports.cshtml"
using COMSCA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fb6c9a44ee9bd9092824968620d9a691386b1af", @"/Views/Home/MembershipDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e380d3119181dee6a761425a0db5b1bdbc6f04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MembershipDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<COMSCA.Models.tbl_member>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\MY PROJECTS\GIT-COMSCA\comsca\COMSCA\COMSCA\Views\Home\MembershipDetails.cshtml"
  
    ViewData["Title"] = "Membership";

#line default
#line hidden
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 29, false);
#line 6 "D:\MY PROJECTS\GIT-COMSCA\comsca\COMSCA\COMSCA\Views\Home\MembershipDetails.cshtml"
Write(Html.Partial("_AddNewMember"));

#line default
#line hidden
            EndContext();
            BeginContext(111, 1438, true);
            WriteLiteral(@"

<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"" style=""padding-top: 60px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Membership</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Membership</li>
                    </ol>
                </div><!-- /.col -->
            </div><!-- /.row -->
        </div><!-- /.container-fluid -->
    </div>
    <!-- /.content-header -->
    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">

            <div class=""card bg-primary"">
                <div class=""card-header"">
      ");
            WriteLiteral(@"              <h3 class=""card-title""><i class=""fas fa-edit pr-2""></i>Slip Details</h3>
                </div>

            <div class=""card card-secondary"">
                <div class=""card-header"">
                    <h3 class=""card-title""><i class=""fa fa-user pr-2""></i>Membership Details</h3>
                </div>

                <div class=""card-body"">
                    <div class=""row pl-2"">
");
            EndContext();
            BeginContext(1734, 838, true);
            WriteLiteral(@"                        <button type=""button"" class=""btn btn-success"" id=""btn_add_new_member""><i class=""fa fa-plus mr-2""></i>Add New Member</button>
                    </div>

                    <div class=""row pb-3 pt-3"">
                        <div class=""col-md-12"">
                            <div class=""dataTables_wrapper table-responsive dt-bootstrap4"">
                                <table id=""tbl_Members"" class=""table table-bordered table-hover text-center"" style=""width:100%""></table>
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
                BeginContext(2591, 10854, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            var member_id = 0;

            ValidateMember();
            function ValidateMember() {
                $.validator.setDefaults({
                    submitHandler: function () {
                        SaveMember();
                    }
                });
                $('#form_member').validate({
                    rules: {
                        FirstName: {
                            required: true
                        },
                        LastName: {
                            required: true
                        },
                        Address: {
                            required: true
                        },
                    },
                    messages: {
                        FirstName: {
                            required: ""This field is required""
                        },
                        LastName: {
                            required: ""This field is requi");
                WriteLiteral(@"red""
                        },
                        Address: {
                            required: ""This field is required""
                        }
                    },
                    errorElement: 'span',
                    errorPlacement: function (error, element) {
                        error.addClass('invalid-feedback');
                        element.closest('.form-group').append(error);
                    },
                    highlight: function (element, errorClass, validClass) {
                        $(element).addClass('is-invalid');
                        console.log(element);
                    },
                    unhighlight: function (element, errorClass, validClass) {
                        $(element).removeClass('is-invalid');
                        console.log(element);
                    }
                });
            }

            LoadMembers();
            function LoadMembers() {
                $('#tbl_Members').DataTable({
    ");
                WriteLiteral(@"                destroy: true,
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
                        //""success"": function (data) {
                        //    alert(JSON.stringify(data.data));
                        //}
                    },
                    columns:
                        [
                            { data: ""FullName"", title: ""Full Name"", sClass: ""dt-body-center"", orderable: false },
                            { data: ""Address"", title: ""Address"", sClass: ""dt-body-c");
                WriteLiteral(@"enter"", orderable: false },
                            { data: ""Gender"", title: ""Gender"", sClass: ""dt-body-center"", orderable: false },
                            { data: ""DateRegistered"", title: ""Date Registered"", sClass: ""dt-body-left"", orderable: false },
                            {
                                data: ""MemberID"", title: ""Action"", render: function (data) {
                                    return ""<div class='row justify-content-center'>"" +
                                        ""<div class='dropdown dropleft'>"" +
                                        ""<button id='btnbars' type='button' class='btn btn-sm btn-success btnbars' data-toggle='dropdown'>"" +
                                        ""<i class='fa fa-bars'></i>"" +
                                        ""</button> <div class='dropdown-menu'>"" +
                                        ""<div class='container fluid'> "" +
                                        ""<a id='btnUpdate' class='btn btn-warning btn-sm fa fa-");
                WriteLiteral(@"edit col-sm-12' style='margin-bottom: 3px; margin-top: 3px;'>"" +
                                        ""&nbspUpdate</a>"" +
                                        ""<br />"" +
                                        ""<a id='btnDelete' class='btn btn-danger btn-sm fa fa-edit col-sm-12' style='margin-bottom: 3px; margin-top: 3px; color: white;'>"" +
                                        ""&nbspDelete</a>"" +
                                        ""</div></div></div ></div>"";
                                }
                            }
                        ]
                });

                $('#tbl_Members tbody').off().on('click', 'tr', function (e) {
                    e.preventDefault();
                    if ($(e.target).is(""[id^=btnUpdate],[id^=btnUpdate] i"")) {
                        UpdateMember();
                    }
                    else if ($(e.target).is(""[id^=btnDelete],[id^=btnDelete] i"")) {
                        RemoveMember();
                    }
          ");
                WriteLiteral(@"          else if (!$(e.target).is(""[id^=btnbars],[id^=btnbars] i"")) {
                        if (!$(this).hasClass(""dtactive"")) {
                            $(this).parent().find(""tr"").removeClass(""dtactive"");
                            $(this).addClass(""dtactive"");
                            member_id = SelectedValue(""tbl_Members"", ""MemberID"");
                            $(""[name='MemberID']"").val(member_id);
                        } else {
                            $(this).removeClass(""dtactive"");
                            $(""[name='MemberID']"").val(0);
                            $(""#form_member"").trigger(""reset"");
                        }
                    }
                });
            }

            function UpdateMember() {
                if ($(""[name='MemberID']"").val() != 0) {
                    $.ajax({
                        url: ""../Membership/UpdateMember?MemberID= "" + $(""[name='MemberID']"").val(),
                        type: ""GET"",
                      ");
                WriteLiteral(@"  cache: false,
                        contentType: false,
                        processData: false,
                        success: function (res) {
                            if (res.data != null) {
                                $(""#modal_add_member"").modal(""show"");
                                $(""[name='MemberID']"").val(res.data.MemberID);
                                $(""[name='FirstName']"").val(res.data.FirstName);
                                $(""[name='LastName']"").val(res.data.LastName);
                                $(""[name='Address']"").val(res.data.Address);
                                $(""[name='GenderID']"").val(res.data.GenderID);
                            }
                        }
                    });
                }
                else {
                    Swal.fire('Information!', 'Please select a record first.', 'info');
                }
            }

            function RemoveMember() {
                if ($(""[name='MemberID']"").val() != ");
                WriteLiteral(@"0) {
                    Swal.fire({
                        text: ""Are you sure you want to delete this record?"",
                        icon: 'warning',
                        showCancelButton: true,
                        confirmButtonColor: '#28a745',
                        cancelButtonColor: '#dc3545',
                        confirmButtonText: 'Yes, delete it!'
                    }).then((result) => {
                        if (result.isConfirmed) {
                            $.ajax({
                                url: '../Membership/RemoveMember?&MemberID=' + $(""[name='MemberID']"").val(),
                                type: 'POST',
                                success: function (res) {
                                    if (res.success == true) {
                                        Swal.fire('Success!', 'Record has been deleted.', 'success');
                                        LoadMembers();
                                        $(""[name='MemberID']"").val(0);");
                WriteLiteral(@"
                                    } else {
                                        Swal.fire('Error!', res.msg, 'error');
                                    }
                                }
                            });
                        }
                    });
                }
                else {
                    Swal.fire('Information!', 'Please select a record first.', 'info');
                }
            }

            $(""#btn_add_new_member"").click(function (e) {
                e.preventDefault();
                NewMembership();
            });

            function NewMembership() {
                $(""#form_member"").trigger(""reset"");
                $(""#modal_add_member"").modal(""show"");
            }

            function SaveMember() {
                $.ajax({
                    url: ""../Membership/SaveMember"",
                    type: 'POST',
                    data: MemberDetails(),
                    cache: false,
                    conte");
                WriteLiteral(@"ntType: false,
                    processData: false,
                    success: function (res) {
                        if (res.success == true) {
                            Swal.fire({
                                text: ""Successfully saved."",
                                icon: ""success"",
                                showCancelButton: false,
                                confirmButtonColor: '#28a745',
                                confirmButtonText: ""Ok""
                            }).then((result) => {
                                if (result.isConfirmed) {
                                    $(""#form_member"").trigger(""reset"");
                                    LoadMembers();
                                    $(""[name='MemberID']"").val(0);
                                }
                            });
                        } else {
                            Swal.fire(""Error!"", res.message, ""error"");
                        }
                    }
         ");
                WriteLiteral(@"       });
            }

            function MemberDetails() {
                var formData = new FormData();
                formData.append('MemberID', $(""[name='MemberID']"").val());
                formData.append('FirstName', $(""[name='FirstName']"").val());
                formData.append('LastName', $(""[name='LastName']"").val());
                formData.append('GenderID', $(""[name='GenderID']"").val());
                formData.append('Address', $(""[name='Address']"").val());
                return formData;
            }

        });

        ActiveMenu(""#membership"");
    </script>
");
                EndContext();
            }
            );
            BeginContext(13448, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COMSCA.Models.tbl_member> Html { get; private set; }
    }
}
#pragma warning restore 1591
