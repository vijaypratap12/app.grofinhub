#pragma checksum "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Widhroll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb1fb3d017c7c5f85a95a906d1cce96ca2713aba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Widhroll), @"mvc.1.0.view", @"/Views/Admin/Widhroll.cshtml")]
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
#line 1 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\_ViewImports.cshtml"
using SportsBattle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\_ViewImports.cshtml"
using SportsBattle.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb1fb3d017c7c5f85a95a906d1cce96ca2713aba", @"/Views/Admin/Widhroll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bbb2031673621bf224697d6f9b4bc70040137b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Widhroll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Widhroll.cshtml"
  
    ViewData["Title"] = "Widhroll";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<script type=""text/javascript"" language=""javascript"">
    function numeric(e) {
        var unicode = e.charCode ? e.charCode : e.keyCode;
        if (unicode == 8 || unicode == 9 || (unicode >= 48 && unicode <= 57)) {
            return true;
        }
        else {
            return false;
        }
    }

    function Widhrollcheck() {


        if ($(""#txtPhone1"").val() == """") {
            alert('Enter Phone No.');
            $(""#txtPhone1"").focus;
            return;
        }

        var data = new FormData;

        data.append(""mobile"", $(""#txtPhone1"").val());
        data.append(""bank3_flag"", ""NO"");


        $(""#showSpinner"").show();

        $.ajax({
            url: ""/Admin/QueryRemmiterPost"",
            type: ""POST"",
            contentType: false,
            processData: false,
            data: data,
            success: function (r) {
                if (r.strId == ""1"") {

                }
                else if (r.strId == ""2"") {

   ");
            WriteLiteral(@"                 $(""#showSpinner"").hide();
                    window.location.href = ""../Admin/RegisterRemmiter?Mobile="" + $(""#txtPhone1"").val() + ""&stateresp="" + r.stateresp;
                }
                else if (r.strId == ""0"") {
                    alert(r.msg);
                    $(""#showSpinner"").hide();
                }
                else {
                    alert('Server not Responding !!!');
                    $(""#showSpinner"").hide();
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert('Please Check values Entered by you !!!');
                $(""#showSpinner"").hide();
            }


        });
    }







</script>

<div class=""content-header"">
    <div class=""container-fluid"">
        <div class=""row mb-2"">
            <div class=""col-sm-6"">
                <h5 class=""m-0""> Withdraw </h5>
            </div>
            <div class=""col-sm-6"">
                <ol class=""bread");
            WriteLiteral(@"crumb float-sm-right"">
                    <li class=""breadcrumb-item""><a href=""/Admin/Dashboard"">Dashboard</a></li>

                </ol>
            </div>
        </div>
    </div>
</div>


<section class=""content"">
    <div class=""container-fluid"">

        <div class=""row"">

            <div class=""col-md-12"">

                <div class=""card card-warning"">
                    <div class=""card-header"">
                        <h3 class=""card-title""> Withdraw </h3>
                    </div>

                    <div class=""card-body "">

                        <div class=""row"">



                            <div class=""col-sm-3"">

                                <div class=""form-group"">
                                    <label>Phone No:	 </label>
                                    <input type=""text"" class=""form-control"" placeholder=""Enter Phone No"" maxlength=""10"" id=""txtPhone1"" onkeypress=""return numeric(event);"" onchange=""phonenumberlength();"" />

                ");
            WriteLiteral(@"                </div>
                            </div>
                        </div>
                        <button type=""button"" id=""btnSearch"" class=""btn btn-primary waves-effect waves-light"" onclick=""Widhrollcheck()"">Search</button>




                    </div>

                </div>
            </div>
        </div>
        <div class=""col-md-12"">
            <div class=""card card-warning"">
                <div class=""card-header"">


");
            WriteLiteral(@"                    <div style=""overflow-x:auto;"">

                        <table id=""example3"" class=""my  table table-bordered table-hover"">
                            <thead>
                                <tr>
                                    <th>Sr.No.</th>
                                    <th>Acknowledgement Number</th>
                                    <th>Bank Reference Number</th>
                                    <th>Amount</th>

                                    <th>Message</th>
");
            WriteLiteral("                                    <th>Status</th>\r\n                                </tr>\r\n\r\n                            </thead>\r\n");
            WriteLiteral("                        </table>\r\n\r\n\r\n");
            WriteLiteral("                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
