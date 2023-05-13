#pragma checksum "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\Ledger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d90f556af107ca659ed2a9426aa64f7d6bb9b911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ledger), @"mvc.1.0.view", @"/Views/Home/Ledger.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Ledger.cshtml", typeof(AspNetCore.Views_Home_Ledger))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90f556af107ca659ed2a9426aa64f7d6bb9b911", @"/Views/Home/Ledger.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e380d3119181dee6a761425a0db5b1bdbc6f04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Ledger : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\MY PROJECTS\COMSCA\COMSCA\COMSCA\Views\Home\Ledger.cshtml"
  
    ViewData["Title"] = "Ledger";

#line default
#line hidden
            BeginContext(42, 1794, true);
            WriteLiteral(@"
<!-- Content Wrapper. Contains page content -->
<div class=""content-wrapper"" style=""padding-top: 60px;"">
    <!-- Content Header (Page header) -->
    <div class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1 class=""m-0"">Ledger</h1>
                </div><!-- /.col -->
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Ledger</li>
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
            WriteLiteral(@"      <h3 class=""card-title""><i class=""fa fa-money pr-2""></i>Ledger</h3>
                </div>

                <div class=""card-body"">
                    <div class=""row pb-3 pt-3"">
                        <div class=""col-md-12"">
                            <div class=""dataTables_wrapper table-responsive dt-bootstrap4"">
                                <table id=""tbl_Ledger"" class=""table table-bordered table-hover text-center"" style=""width:100%""></table>
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
");
            EndContext();
            BeginContext(1980, 28, true);
            WriteLiteral("<!-- /.content-wrapper -->\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2027, 3386, true);
                WriteLiteral(@"
    <script>

        $(document).ready(function () {
            var member_id = 0;

            LoadLedger();
            function LoadLedger() {
                $.ajax({
                    url: ""../Collection/LoadLedger"",
                    type: 'GET',
                    datatype: ""JSON"",
                    success: function (res) {
                        //console.log(res.data);
                        var dataSet = res.data;
                        var columns = []
                        $.each(dataSet[0], function (key, value) {
                            var my_item = {};
                            my_item.data = key;
                            my_item.title = key;
                            columns.push(my_item);
                        });
                        LoadLedgerTable(columns, dataSet);
                    },
                });
            }

            function LoadLedgerTable(columns, dataSet) {
                console.log(columns);
            ");
                WriteLiteral(@"    //console.log(columns.length);
                var len = columns.length - 1;
                //console.log(len);
                var index = []
                for (var i = 0; i < columns.length; i++) {
                    if (i != 0 && i != len) {
                        index.push(i);
                    }
                }
                //console.log(index);

                $('#tbl_Ledger').DataTable({
                    //scrollY: ""300px"",
                    scrollX: true,
                    scrollCollapse: true,
                    paging: true,
                    info: true,
                    searching: true,
                    fixedColumns: {
                        left: 1,
                        right: 1
                    },
                    data: dataSet,
                    columnDefs: [{
                        'targets': index,
                        'searchable': false,
                        'orderable': false,
                        'className'");
                WriteLiteral(@": 'dt-body-center',
                        'render': function (data, type, full, meta) {
                            if (data) {
                                return '<div class=""icheck-success d-inline""><input type=""checkbox"" id=""Week1"" disabled=""true"" checked=""checked""><label for=""Week1""></label></div>'
                            } else {
                                return '<div class=""icheck-success d-inline""><input type=""checkbox"" id=""Week1"" disabled=""true""><label for=""Week1""></label></div>'
                            }
                        }
                    }],
                    columns: columns,
                });

                $('#tbl_Ledger tbody').off().on('click', 'tr', function (e) {
                    if (!$(this).hasClass(""dtactive"")) {
                        $(this).parent().find(""tr"").removeClass(""dtactive"");
                        $(this).addClass(""dtactive"");
                        member_id = SelectedValue(""tbl_Ledger"", ""MemberID"");
                ");
                WriteLiteral(@"        $(""[name='MemberID']"").val(member_id);
                    } else {
                        $(this).removeClass(""dtactive"");
                        $(""[name='MemberID']"").val(0);
                    }
                });
            }

        });

        ActiveMenu(""#ledger"");

 </script>
");
                EndContext();
            }
            );
            BeginContext(5416, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591