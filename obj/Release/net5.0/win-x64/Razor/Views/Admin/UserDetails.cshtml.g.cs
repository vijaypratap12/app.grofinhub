#pragma checksum "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79dad93fad78fd47b73bb3bd30fe5e67bb1a3707"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserDetails), @"mvc.1.0.view", @"/Views/Admin/UserDetails.cshtml")]
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
#line 1 "E:\Ashish\SportsBattle\Views\_ViewImports.cshtml"
using SportsBattle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Ashish\SportsBattle\Views\_ViewImports.cshtml"
using SportsBattle.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79dad93fad78fd47b73bb3bd30fe5e67bb1a3707", @"/Views/Admin/UserDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bbb2031673621bf224697d6f9b4bc70040137b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_UserDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportsBattle.Models.clsPlayer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Player", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserFullDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
  
    ViewData["Title"] = "NONZeroPlayers";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""app-main__inner"">
    <style>
        .button {
            background-color: #0d724c; /* Green */
            border: none;
            color: white;
            padding: 15px 32px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
        }

    </style>
    <script type=""text/javascript"">
        $(function () {
            $('#FromDate').datepicker({
                changeMonth: true,
                changeYear: true,
                format: ""dd/mm/yyyy"",
                language: ""tr""
            });
        });
    </script>
    <div>


               <div class=""row"">
                   <div class=""col-md-12"">
                       <div class=""main-card mb-3 card"">
                           <div class=""card-body"">
                               <div class=""row"">
                                   <div class=""col-sm-4");
            WriteLiteral(@""">
                                       <h5 class=""card-title"">From Date</h5>
                                       <input  type=""text"" id=""FromDate"" class=""form-control"" data-toggle=""datepicker"" />
                                   </div>
                                   <div class=""col-sm-4"">
                                       <h5 class=""card-title"">To Date</h5>
                                       <input id=""ToDate"" type=""text"" class=""form-control"" data-toggle=""datepicker"" />
                                   </div>
                                   <div class=""col-sm-4"">
                                <input style=""margin-top: 18px;"" type=""submit"" class=""btn btn-alternate button "" value=""Search"" onclick=""SearchData()"" />
                                   </div>
                                   </div>

                               </div>
                       </div>
                   </div>
               </div>
    <div class=""row"">

                <div class=""car");
            WriteLiteral(@"d-body"">
                    <div class=""card mb-3"">
                        <div class=""card-header-tab card-header"">

                            <div class=""card-header-title font-size-lg text-capitalize font-weight-normal"">
                                <i class=""header-icon lnr-laptop-phone mr-3 text-muted opacity-6""> </i>
                              Players
                            </div>
                        </div>
                        <div id=""divId"">

                            <div class=""card-body"">
");
#nullable restore
#line 72 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                 if (Model != null && Model.dtDetails != null)
                                {
                                    int i = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <table style=""width: 100%;"" id=""example"" class=""table table-hover table-striped table-bordered"">
                                    <thead>
                                        <tr>
                                            <th>Sr.</th>
                                            <th>Member Unique Id</th>
                                            <th>User Name</th>
                                            <th>Date Of Birth</th>
                                            <th>Gender</th>
                                            <th>Mobile</th>
                                            <th>Address</th>
                                            <th>DL No.</th>
                                            <th>Ownership</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 91 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                         foreach (System.Data.DataRow item in Model.dtDetails.Rows)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 94 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                               Write(Convert.ToInt32(i));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                                <td>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79dad93fad78fd47b73bb3bd30fe5e67bb1a37078718", async() => {
                WriteLiteral("\r\n                                                        <div class=\"widget-heading\"> ");
#nullable restore
#line 112 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                                                                Write(item["Member_Unique_ID"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-UserId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                                                                                                  WriteLiteral(item["Member_Unique_ID"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>");
#nullable restore
#line 115 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                               Write(item["Member_Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 116 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                               Write(item["DATE"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 117 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                               Write(item["Gender"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 118 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                               Write(item["Mobile_No"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 119 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                               Write(item["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 120 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                               Write(item["DrivingLicence"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 121 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                               Write(item["OwnerShips"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                            </tr>\r\n");
#nullable restore
#line 127 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"
                                            i = i + 1;
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </table>\r\n");
#nullable restore
#line 130 "E:\Ashish\SportsBattle\Views\Admin\UserDetails.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n<script>\r\n\r\n    function updatestatus(sid, status)\r\n    {\r\n        \r\n");
            WriteLiteral("    } \r\n    function SearchData() { \r\n");
            WriteLiteral("    }\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportsBattle.Models.clsPlayer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
