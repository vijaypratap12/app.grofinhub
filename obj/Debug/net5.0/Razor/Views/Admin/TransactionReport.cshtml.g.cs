#pragma checksum "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0384a8f813e96396e2e9810bbb9863da55110a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TransactionReport), @"mvc.1.0.view", @"/Views/Admin/TransactionReport.cshtml")]
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
#line 1 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\_ViewImports.cshtml"
using SportsBattle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\_ViewImports.cshtml"
using SportsBattle.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0384a8f813e96396e2e9810bbb9863da55110a8", @"/Views/Admin/TransactionReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bbb2031673621bf224697d6f9b4bc70040137b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_TransactionReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
  
    ViewData["Title"] = "TransactionReport";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
<div class=""col-md-12"">
    <div class=""card card-warning "" >
        <div class=""card-header"">
            <h3 class=""card-title""> Transaction Report</h3>
        </div>
        <div class=""card-body"">
            <div style=""overflow-x:auto;"" class=""p-0"">
                <table id=""example3"" class=""my  table table-bordered table-hover "" style=""width:100%;"">
                    <thead class=""bg-primary"">
                        <tr>
                            <th>Sr.No.</th>
                            <th>Name </th>
                            <th>Mobile No</th>
                            <th>Pipe</th>
                            <th>Pincode</th>
                            <th>Address</th>
                            <th>DOB</th>
                            <th>Txntype </th>
                            <th>TransactionID </th>
                            <th>Amount</th>
                           
                            <th>Acount No</th>
                            <th>UTR</t");
            WriteLiteral("h>\r\n                            <th>Status</th>\r\n                            <th>Remark</th>\r\n\r\n                        </tr>\r\n\r\n                    </thead>\r\n                    <tbody >\r\n");
#nullable restore
#line 41 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                          

                            if (Model!= null)
                            {
                                if (Model.Rows.Count > 0)
                                {
                                    int i = 1;
                                    foreach (DataRow item in Model.Rows)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
#nullable restore
#line 51 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 52 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                           Write(item["Benename"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 53 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                           Write(item["MobileNo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 54 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                           Write(item["Pipe"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 55 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                           Write(item["Pincode"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td width=\"120px\">");
#nullable restore
#line 56 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                                         Write(item["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 57 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                           Write(item["Dob"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                             <td>");
#nullable restore
#line 58 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                            Write(item["Txntype"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 59 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                           Write(item["ReferenceId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 60 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                           Write(item["Amount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                           \r\n                                                            <td>");
#nullable restore
#line 62 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                           Write(item["account_number"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                            <td>");
#nullable restore
#line 63 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                                           Write(item["utr"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n");
#nullable restore
#line 66 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                             if (item["txn_status"].ToString().ToLower() == "true")
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td style=\"color:white ;\"><span style=\"background-color:forestgreen;\"  class=\"rounded\">success</span></td>\r\n");
#nullable restore
#line 69 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td style=\"color:white\"><span style=\"background-color:red; \" class=\"rounded\">Failed</span></td>\r\n");
#nullable restore
#line 73 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>");
#nullable restore
#line 74 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                           Write(item["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n");
            WriteLiteral("\r\n                                                        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\TransactionReport.cshtml"
                                        i++;
                                    }
                                }

                            }

                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </tbody>
                </table>
            </div>
        </div>

    </div>
</div>


<script>
    var js=jQuery.noConflict(true)
    js(document).ready(function(){
  
        js(""#example3"").DataTable();
    })

   



</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataTable> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
