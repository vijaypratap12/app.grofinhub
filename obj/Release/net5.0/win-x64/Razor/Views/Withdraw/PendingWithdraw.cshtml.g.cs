#pragma checksum "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d37774234e57732645058ffbc9b385b9a3034e37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Withdraw_PendingWithdraw), @"mvc.1.0.view", @"/Views/Withdraw/PendingWithdraw.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d37774234e57732645058ffbc9b385b9a3034e37", @"/Views/Withdraw/PendingWithdraw.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bbb2031673621bf224697d6f9b4bc70040137b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Withdraw_PendingWithdraw : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
  
    ViewData["Title"] = "PendingWithdraw";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""app-main__inner"">
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
                                <input style=""margin-top: 31px;"" type=""submit"" class=""btn btn-alternate"" value=""Search"" onclick=""SearchData()"" />
                            </div>
");
            WriteLiteral(@"                        </div> 
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
#line 42 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
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
                                            <th>User Details</th>
                                            <th>Amount</th>
                                            <th>Payment Type</th>
                                            <th>Bank Details</th>
                                            <th>Transaction Id</th>
                                            <th>Status</th>
                                            <th>Action</th>
                                            <th>Date</th>

                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 61 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                         foreach (System.Data.DataRow item in Model.dtDetails.Rows)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 64 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
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
            BeginWriteAttribute("src", " src=\"", 3703, "\"", 3786, 1);
#nullable restore
#line 71 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
WriteAttributeValue("", 3709, item["" +
                                                    "ProfilePic"], 3709, 77, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3787, "\"", 3793, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                                </div>
                                                            </div>
                                                            <div class=""widget-content-left"">
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d37774234e57732645058ffbc9b385b9a3034e379085", async() => {
                WriteLiteral("\r\n                                                                    <div class=\"widget-heading\"> ");
#nullable restore
#line 77 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                                                            Write(item["UserID"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                                                ");
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
#line 76 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                                                                                              WriteLiteral(item["UserID"]);

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
            WriteLiteral("\r\n                                                                <div class=\"widget-subheading\">");
#nullable restore
#line 79 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                                                          Write(item["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                                                            </div> 
                                                        </div>
                                                    </div>
                                                </td>
                                                <td>");
#nullable restore
#line 84 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                               Write(item["Amount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 85 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                               Write(item["PayemnetType"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n");
#nullable restore
#line 87 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                     if (@item["PayemnetType"].ToString() == "UPI")
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div class=\"widget-content-left flex2\">\r\n                                                            <div class=\"widget-heading\">");
#nullable restore
#line 90 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                                                   Write(item["UPIId"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                        </div>\r\n");
#nullable restore
#line 92 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div class=\"widget-content-left flex2\">\r\n                                                            <div class=\"widget-heading\">Bank Name:");
#nullable restore
#line 96 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                                                             Write(item["BankName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                            <div class=\"widget-subheading opacity-10\">\r\n                                                                <span class=\"pr-2\"><b>");
#nullable restore
#line 98 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                                                 Write(item["AccountNo"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> ");
#nullable restore
#line 98 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                                                                                   Write(item["Ifsc"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                                <span><b class=\"text-success\">");
#nullable restore
#line 99 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                                                         Write(item["BranchName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> ");
#nullable restore
#line 99 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                                                                                            Write(item["AccountHolderName"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                            </div>\r\n                                                        </div>\r\n");
#nullable restore
#line 102 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                                <td>");
#nullable restore
#line 104 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                               Write(item["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td><div class=\"badge badge-info ml-2\">");
#nullable restore
#line 105 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                                                                  Write(item["Status"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> </td>\r\n                                                <td>\r\n                                                    <button class=\"mb-2 mr-2 btn btn-success active\"");
            BeginWriteAttribute("onclick", " onclick=\"", 6803, "\"", 6868, 5);
            WriteAttributeValue("", 6813, "updatestatus(\'", 6813, 14, true);
#nullable restore
#line 107 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
WriteAttributeValue("", 6827, item["id"], 6827, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6838, "\',\'Approve\',\'", 6838, 13, true);
#nullable restore
#line 107 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
WriteAttributeValue("", 6851, item["UserID"], 6851, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6866, "\')", 6866, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Approve</button>\r\n                                                    <button class=\"mb-2 mr-2 btn btn-danger active\"");
            BeginWriteAttribute("onclick", "  onclick=\"", 6987, "\"", 7052, 5);
            WriteAttributeValue("", 6998, "updatestatus(\'", 6998, 14, true);
#nullable restore
#line 108 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
WriteAttributeValue("", 7012, item["id"], 7012, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7023, "\',\'Reject\',\'", 7023, 12, true);
#nullable restore
#line 108 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
WriteAttributeValue("", 7035, item["UserID"], 7035, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7050, "\')", 7050, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                        Reject\r\n                                                    </button>\r\n                                                </td>\r\n                                                <td>");
#nullable restore
#line 112 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                               Write(item["EntryDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 114 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </table>\r\n");
#nullable restore
#line 116 "E:\Ashish\SportsBattle\Views\Withdraw\PendingWithdraw.cshtml"
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


<div class=""modal"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Details</h5>
                <button type=""button"" onclick=""ModelHide()"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p class=""mb-0""> 
                    <div class=""col-sm-12"">
                        <input type=""hidden"" id=""hdId"" />
                        <input type=""hidden"" id=""hdUserId"" />
                        <div class=""position-relative form-group col-sm-12"">
            ");
            WriteLiteral(@"                <input class=""form-control"" id=""TransferId"" placeholder=""Enter Transfer Id"" type=""text"" />
                        </div>
                        <div class=""position-relative form-group col-sm-12"">
                            <input class=""form-control"" id=""TransferRemark"" placeholder=""Description"" type=""text"" />
                        </div>
                        <div class=""position-relative form-group col-sm-12"">
                            <input class=""form-control"" id=""fuProofId"" type=""file""  />
                        </div> 
                    </div> 
                </p>
            </div>
            <div class=""modal-footer""> 
                <button type=""button"" class=""btn btn-primary"" onclick=""UpdatePayement()"" >Submit</button>
            </div>
        </div>
    </div>
</div>
<script>
    function SearchData() {
        $.ajax({
            url: ""/Withdraw/PendingWithdraw"",
            type: ""POST"",
            data: { FromDate: $(""#FromDate"").val(),");
            WriteLiteral(@" ToDate: $(""#ToDate"").val(), Action: ""PendingWithdraw"" },
            success: function (r) {
                $('#divId').val($(r).find('#divId').html())
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert('Please Check values Entered by you !!!');
            }
        });
    }

    function updatestatus(sid, status,userid)
    { 
        if (confirm(""are you sure want to update status"") == true) {
            if (status == ""Approve"") {
                $(""#hdId"").val(sid)
                $(""#hdUserId"").val(userid)
                $(""#exampleModal"").show(); 
            }
            else {
                $.ajax({
                    url: '/Withdraw/UpdateStatus',
                    method: 'post',
                    data: { UserID: sid, Status: status, sUserId: userid },
                    success: function (r) {
                        $(""#showSpinner"").hide();
                        if (r.Status = '1') {
              ");
            WriteLiteral(@"              alert('Status Change Successfully.');
                            location.reload();
                        }
                        else {
                            alert(""something went wrong"");
                        }
                    }
                })
            }
        }
    }

    function ModelHide() {
        $(""#exampleModal"").hide();
    }

    function UpdatePayement() {

        var Imagefile1 = $(""#fuProofId"").get(0).files;
        var data1 = new FormData();
        data1.append(""ProofId"", Imagefile1[0]);
        data1.append(""TransferRemark"", $(""#TransferRemark"").val());
        data1.append(""TransferId"", $(""#TransferId"").val());
        data1.append(""Status"", ""Approve"");
        data1.append(""UserID"", $(""#hdId"").val()); 
        data1.append(""sUserId"", $(""#hdUserId"").val());
        $.ajax({
            url: '/Withdraw/UpdateStatus',
            method: 'post',
            data: data1 ,
            contentType: false,
            proc");
            WriteLiteral(@"essData: false,
            success: function (r) {
                $(""#showSpinner"").hide();
                if (r.Status = '1') {
                    alert('Status Change Successfully.');
                    location.reload();
                }
                else {
                    alert(""something went wrong"");
                }
            }
        })
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
