#pragma checksum "D:\MY PROJECTS\GIT-COMSCA\comsca\COMSCA\COMSCA\Views\Home\_ViewLoanDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e828d592122c8360ae4a1a4734cb74747e4ba76d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ViewLoanDetails), @"mvc.1.0.view", @"/Views/Home/_ViewLoanDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_ViewLoanDetails.cshtml", typeof(AspNetCore.Views_Home__ViewLoanDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e828d592122c8360ae4a1a4734cb74747e4ba76d", @"/Views/Home/_ViewLoanDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1e380d3119181dee6a761425a0db5b1bdbc6f04", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ViewLoanDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 673, true);
            WriteLiteral(@"<!-- Modal -->
<div id=""modal_view_loandetails"" class=""modal fade"" role=""dialog"" data-backdrop=""static"">
    <div class=""modal-dialog pt-5 modal-md"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title""><i class=""fa fa-user pr-2""></i>Loan Details</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">×</button>
            </div>
            <div>
                <div class=""row p-3 div-iframe-height"">
                    <iframe id=""rpt_loanDetails"" class=""iframe-height-width""></iframe>
                </div>

            </div>
        </div>

    </div>
</div>
");
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
