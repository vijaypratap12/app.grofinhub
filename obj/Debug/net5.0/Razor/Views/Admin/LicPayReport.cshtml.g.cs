#pragma checksum "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec434c8e37cdd605ee44792e315e90a77fba4719"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_LicPayReport), @"mvc.1.0.view", @"/Views/Admin/LicPayReport.cshtml")]
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
#line 7 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec434c8e37cdd605ee44792e315e90a77fba4719", @"/Views/Admin/LicPayReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bbb2031673621bf224697d6f9b4bc70040137b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_LicPayReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
  
    ViewData["Title"] = "LicPayReport";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""col-md-12"">
    <div class=""card card-warning "" >
        <div class=""card-header"">
            <h3 class=""card-title""> Lic Bill Pay Report</h3>
        </div>
        <div class=""card-body"">
            <div style=""overflow-x:auto;"">
                <table id=""example3"" class=""my  table table-bordered table-hover pt-4"" style=""width:100%;"" >
                    <thead class=""bg-primary"">
                        <tr>
                            <th>Sr.No.</th>
                            <th>Bill Number </th>
                            <th>Mode</th>
                            <th>Amount</th>
                           
                            <th>Email </th>
                            <th>Ad2 </th>
                            <th>Ad3 </th>
                            <th>ReferenceID </th>

                            <th>Latitude</th>
                            <th>Longitude</th>
                            <th>Bill number</th>
                            <th>Bill");
            WriteLiteral(@" Amount</th>
                            <th>Bill Date</th>
                            <th>Accept Payment</th>
                            <th>Cell Number</th>
                            <th>Akcknowledge No:</th>
                            <th>Entry Date</th>
                            <th>Type</th>

                        </tr>

                    </thead>
                    <tbody>
");
#nullable restore
#line 45 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                          

                            if (Model != null)
                            {
                                if (Model.Rows.Count > 0)
                                {
                                    int i = 1;
                                    foreach (DataRow item in Model.Rows)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 55 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 56 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["Canumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 57 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["mode"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 58 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["amount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                            <td>");
#nullable restore
#line 60 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["ad1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 61 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["ad2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 62 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["ad3"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 63 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["referenceId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 64 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["latitude"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 65 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["longitude"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 66 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["billnumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 67 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["billamount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 68 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["billdate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 69 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["acceptpayment"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 70 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["cellnumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 71 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["ackno"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            \r\n                                            <td>");
#nullable restore
#line 73 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["entrydate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 74 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
                                           Write(item["type"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                          \r\n\r\n\r\n\r\n\r\n");
            WriteLiteral("                         \r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 86 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\LicPayReport.cshtml"
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





</script>
");
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
