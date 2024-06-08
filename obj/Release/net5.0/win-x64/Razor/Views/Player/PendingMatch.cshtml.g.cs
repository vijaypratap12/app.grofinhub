#pragma checksum "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501aeefe727bf3e4d158bb6d2dc6eed4294b33bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_PendingMatch), @"mvc.1.0.view", @"/Views/Player/PendingMatch.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"501aeefe727bf3e4d158bb6d2dc6eed4294b33bf", @"/Views/Player/PendingMatch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bbb2031673621bf224697d6f9b4bc70040137b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Player_PendingMatch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Player", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserFullDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Upload/Images/vs.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TableFullView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mb-2 mr-2 btn btn-primary active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
  
    ViewData["Title"] = "Pending Match";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""app-main__inner"">
    <div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""main-card mb-3 card"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col-sm-4"">
                                <h5 class=""card-title"">From Date</h5>
                                <input type=""text"" id=""FromDate"" class=""form-control"" data-toggle=""datepicker"" />
                            </div>
                            <div class=""col-sm-4"">
                                <h5 class=""card-title"">To Date</h5>
                                <input id=""ToDate"" type=""text"" class=""form-control"" data-toggle=""datepicker"" />
                            </div>
                            <div class=""col-sm-4"">
                                <input style=""margin-top: 31px;"" type=""submit"" class=""btn btn-alternate "" value=""Search"" onclick=""SearchData()"" />
                            </div");
            WriteLiteral(@">
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">

            <div class=""card-body"">
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
#line 45 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                             if (Model != null && Model.dtDetails != null)
                            {
                                int i = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <table style=""width: 100%;"" id=""example"" class=""table table-hover table-striped table-bordered"">
                                    <thead>
                                        <tr>
                                            <th>Sr.</th>
                                            <th>Table</th>
                                            <th>Game</th>
                                            <th>Action</th>
                                            <th>Amount</th>
                                            <th>Match Type</th>
                                            <th>Date & Time</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 62 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                         foreach (System.Data.DataRow item in Model.dtDetails.Rows)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 65 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                               Write(Convert.ToInt32(i));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                                <td>

                                                    <div class=""widget-content p-0"">
                                                        <div class=""widget-content-wrapper"">

                                                            <div class=""widget-content-left mr-3"">
                                                                <div class=""widget-content-left"">
                                                                    <img width=""42"" class=""rounded""");
            BeginWriteAttribute("src", " src=\"", 3566, "\"", 3595, 1);
#nullable restore
#line 73 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
WriteAttributeValue("", 3572, item["FirstPlayerPic"], 3572, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3596, "\"", 3602, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                </div>
                                                            </div>
                                                            <div class=""widget-content-left"">
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "501aeefe727bf3e4d158bb6d2dc6eed4294b33bf10395", async() => {
                WriteLiteral("\r\n                                                                    <div class=\"widget-heading\"> ");
#nullable restore
#line 78 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                                                                            Write(item["FirstPlayerID"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>");
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
#line 77 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                                                                                                              WriteLiteral(item["UserId"]);

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
            WriteLiteral("\r\n                                                                    <div class=\"widget-subheading\">");
#nullable restore
#line 79 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                                                                              Write(item["FirstPlayerName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                            </div>

                                                        </div>
                                                    </div>


                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "501aeefe727bf3e4d158bb6d2dc6eed4294b33bf13890", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                                    <div class=""widget-content p-0"">
                                                        <div class=""widget-content-wrapper"">

                                                            <div class=""widget-content-left mr-3"">
                                                                <div class=""widget-content-left"">
                                                                    <img width=""42"" class=""rounded""");
            BeginWriteAttribute("src", " src=\"", 5051, "\"", 5078, 1);
#nullable restore
#line 93 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
WriteAttributeValue("", 5057, item["SecPlayerPic"], 5057, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 5079, "\"", 5085, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                </div>
                                                            </div>
                                                            <div class=""widget-content-left"">
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "501aeefe727bf3e4d158bb6d2dc6eed4294b33bf16255", async() => {
                WriteLiteral("\r\n                                                                    <div class=\"widget-heading\"> ");
#nullable restore
#line 98 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                                                                            Write(item["SecPlayerID"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div> ");
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
#line 97 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                                                                                                              WriteLiteral(item["SecPlayerID"]);

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
            WriteLiteral("\r\n                                                                    <div class=\"widget-subheading\">");
#nullable restore
#line 99 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                                                                              Write(item["SecPlayerName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
</div>

                                                        </div>
                                                    </div>


                                                </td>
                                                <td>

                                                    <div class=""widget-content p-0"">
                                                        <div class=""widget-content-wrapper"">

                                                            <div class=""widget-content-left mr-3"">
                                                                <div class=""widget-content-left"">
                                                                    <img width=""42"" class=""rounded""");
            BeginWriteAttribute("src", " src=\"", 6474, "\"", 6503, 1);
#nullable restore
#line 114 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
WriteAttributeValue("", 6480, item["FirstPlayerPic"], 6480, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6504, "\"", 6510, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                </div>
                                                            </div>
                                                            <div class=""widget-content-left"">
                                                                <div class=""widget-heading""> ");
#nullable restore
#line 118 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                                                                        Write(item["FirstPlayerID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                                <div class=\"badge badge-pill badge-info ml-2\">");
#nullable restore
#line 119 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                                                                                         Write(item["FristResultStatus"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                            </div>

                                                        </div>
                                                    </div>



                                                    <div class=""widget-content p-0"">
                                                        <div class=""widget-content-wrapper"">

                                                            <div class=""widget-content-left mr-3"">
                                                                <div class=""widget-content-left"">
                                                                    <img width=""42"" class=""rounded""");
            BeginWriteAttribute("src", " src=\"", 7696, "\"", 7723, 1);
#nullable restore
#line 132 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
WriteAttributeValue("", 7702, item["SecPlayerPic"], 7702, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7724, "\"", 7730, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                </div>
                                                            </div>
                                                            <div class=""widget-content-left"">
                                                                <div class=""widget-heading""> ");
#nullable restore
#line 136 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                                                                        Write(item["SecPlayerID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                                <div class=\"badge badge-pill badge-info ml-2\">");
#nullable restore
#line 137 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                                                                                         Write(item["SecResultStatus"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                            </div>

                                                        </div>
                                                    </div>


                                                </td>
                                                <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "501aeefe727bf3e4d158bb6d2dc6eed4294b33bf24275", async() => {
                WriteLiteral("View Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-type", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 145 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                                                                                               WriteLiteral(item["ChallengeId"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n                                                <td>");
#nullable restore
#line 146 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                               Write(item["EntryFee"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 147 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                               Write(item["GameType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 148 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                               Write(item["ChallengeCreationTime"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                            </tr>   \r\n");
#nullable restore
#line 151 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"
                                            i = i + 1;
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </table>\r\n");
#nullable restore
#line 154 "E:\Ashish\SportsBattle\Views\Player\PendingMatch.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>


            </div>

        </div>
    </div>
</div>
<script>
    function SearchData() {
        $.ajax({
            url: ""/Player/PendingMatch"",
            type: ""POST"",
            data: { FromDate: $(""#FromDate"").val(), ToDate: $(""#ToDate"").val(), Action:""PendingMatch"" },
            success: function (r) {
                $('#divId').val($(r).find('#divId').html())
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert('Please Check values Entered by you !!!');

            }
        });
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
