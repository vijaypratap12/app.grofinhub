#pragma checksum "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7db57b761252e8321d90a01ee5ed7d6a4d50410"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Recharge), @"mvc.1.0.view", @"/Views/Admin/Recharge.cshtml")]
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
#nullable restore
#line 8 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7db57b761252e8321d90a01ee5ed7d6a4d50410", @"/Views/Admin/Recharge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bbb2031673621bf224697d6f9b4bc70040137b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Recharge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataTable>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" ViewBag.rechargeplan");
#nullable restore
#line 1 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
                       
    ViewData["Title"] = "Recharge";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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








    function QueryRechargecheck() {
             
        if ($('#txtPhone1rech').val() == """") {
            alert('Enter Phone No.');
            $('#txtPhone1').focus();
            return;
        }


        var data = new FormData;

        data.append(""amount"", $(""#ddlplan"").val());
        data.append(""operator"", $(""#ddloperator :selected"").attr(""idval""));
        data.append(""canumber"", $(""#txtPhone1rech"").val());
        //alert($(""#ddloperator :selected"").attr(""idval""))


        $(""#showSpinner"").show();

        $.ajax({
            url: ""/Admin/DoMobileRecharge"",
            type: ""POST"",
            contentType: false,
            processDa");
            WriteLiteral(@"ta: false,
            data: data,
            success: function (r) {
                if (r!=null) {
                   // console.log(r)
                    alert(r.message)
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




    function QueryDTHRechargecheckBrowsPlan() {
        var data = new FormData;

        data.append(""circle"", $(""#ddlcircle"").val());
        data.append(""op"", $(""#ddloperator"").val());


        $(""#showSpinner"").show();

        $.ajax({
            url: ""/Admin/DTHBrjowsPlan"",
            type: ""POST"",
            contentType: false,
            processData: false,
            data: data,
            success");
            WriteLiteral(@": function (r) {
               debugger;
                //console.log(r)
                //var dt=eval(r)
                var dt = jQuery.parseJSON(r);
                //console.log(dt.info.TOPUP)
                 $(""#ddlplan"").empty();
                $(""#ddlplan"").append(""<option value='0' disabled selected>-- Select Plan --</option>"")
                if (dt != """" && dt != """") {
                    var allplan = dt.info;
                    var fttplan = allplan.FULLTT;
                    if (fttplan != null && fttplan != """") {
                        for (var item of fttplan) {
                            $(""#ddlplan"").append(""<option value=""+item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbsp;&nbsp; "" + item.desc + ""</option>"")
                        }

                    }
                    var plan3g4g = allplan['3G/4G'];
                    if (plan3g4g != null && plan3g4g != """") {
                        for (var item of plan3g4g) {
               ");
            WriteLiteral(@"             $(""#ddlplan"").append(""<option value="" + item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbsp;&nbsp; "" + item.desc + ""</option>"")
                        }

                    }
                    var plan1 = allplan.TOPUP;
                    if (plan1 != null && plan1 != """") {
                        for (var item of plan1) {
                            $(""#ddlplan"").append(""<option value="" + item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbsp;&nbsp; "" + item.desc + ""</option>"")
                        }
                    }
                    var plan2 = allplan.COMBO;
                    if (plan2 != null && plan2 != """") {
                        for (var item of plan2) {
                            $(""#ddlplan"").append(""<option value="" + item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbsp;&nbsp; "" + item.desc + ""</option>"")
                        }
                    }
                    var");
            WriteLiteral(@" plansms = allplan.SMS;
                    if (plansms != null && plansms != """") {
                        for (var item of plansms) {
                            $(""#ddlplan"").append(""<option value="" + item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbsp;&nbsp; "" + item.desc + ""</option>"")
                        }

                    }
                    var plan2g = allplan['2G'];
                    if (plan2g != null && plan2g != """") {
                        for (var item of plan2g) {
                            $(""#ddlplan"").append(""<option value="" + item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbsp;&nbsp; "" + item.desc + ""</option>"")
                        }

                    }

                }
                else {
                    alert('Server not Responding !!!');
                    $(""#showSpinner"").hide();
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown)");
            WriteLiteral(@" {
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
                <h5 class=""m-0""> Recharge</h5>
            </div>
            <div class=""col-sm-6"">
                <ol class=""breadcrumb float-sm-right"">
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
                        <h3 class=""card-title""> Recharge</h3>
                    </div>

                    <div class=""card-body "">
             ");
            WriteLiteral(@"           <!-- brows Plan start -->

                        <div class=""row"">






                            <div class=""col-sm-3"">
                                Circle:

                                <select class=""form-control"" onchange=""QueryDTHRechargecheckBrowsPlan()"" id=""ddlcircle"" required name=""Pipe"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7db57b761252e8321d90a01ee5ed7d6a4d5041010998", async() => {
                WriteLiteral("-- Select Operator --");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 205 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
                                     foreach (DataRow dr in ViewBag.rechargeplan.Rows)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7db57b761252e8321d90a01ee5ed7d6a4d5041013184", async() => {
                WriteLiteral(" ");
#nullable restore
#line 207 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
                                                                Write(dr["name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 207 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
                                           WriteLiteral(dr["name"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 208 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </select>
                            </div>

                            <div class=""col-sm-3"">
                                Operator:

                                <select class=""form-control"" onchange=""QueryDTHRechargecheckBrowsPlan()"" id=""ddloperator"" required name=""Pipe"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7db57b761252e8321d90a01ee5ed7d6a4d5041015783", async() => {
                WriteLiteral("-- Select Plan --");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 217 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
                                     foreach (DataRow dr in Model.Rows)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7db57b761252e8321d90a01ee5ed7d6a4d5041017950", async() => {
                WriteLiteral(" ");
#nullable restore
#line 219 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
                                                                                  Write(dr["name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ");
#nullable restore
#line 219 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
                                                                                                                                         Write(dr["category"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 219 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
                                           WriteLiteral(dr["name"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "idval", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 219 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
AddHtmlAttributeValue("", 7631, dr["id"], 7631, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 220 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhubportal\Grofin\Views\Admin\Recharge.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </select>\r\n                            </div>\r\n");
            WriteLiteral("                        </div>\r\n");
            WriteLiteral(@"

                        <!-- brows Plan end -->
                        <div class=""row"">



                            <div class=""col-sm-3"">

                                <div class=""form-group"">
                                    <label>Phone No:	 </label>
                                    <input type=""text"" class=""form-control"" placeholder=""Enter Phone No"" maxlength=""10"" id=""txtPhone1rech"" onkeypress=""return numeric(event);"" onchange=""phonenumberlength();"" />

                                </div>
                            </div>


");
            WriteLiteral("\r\n                            <div class=\"col-sm-3\">\r\n                                Plan:\r\n\r\n                                <select class=\"form-control\" id=\"ddlplan\" required name=\"Pipe\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7db57b761252e8321d90a01ee5ed7d6a4d5041022163", async() => {
                WriteLiteral("-- Select Plan --");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"                                </select>
                            </div>
                        </div>
                        <button type=""button"" id=""btnSearch"" class=""btn btn-primary waves-effect waves-light"" onclick=""QueryRechargecheck()"">Do Recharge </button>




                    </div>

                </div>
            </div>
        </div>
        <div class=""col-md-12"" style=""display:none;"">
            <div class=""card card-warning"">
                <div class=""card-header"">
                    <div class=""card-tools"">
                    </div>

                    <div class=""card-body"">
                        <div style=""overflow-x:auto;"">

                            <table id=""example3"" class=""my  table table-bordered table-hover"">
                                <thead>
                                    <tr>
                                        <th>Sr.No.</th>
                                        <th>Customer Name</th>
                             ");
            WriteLiteral(@"           <th>NextRechargeDate</th>
                                        <th>Planname</th>
                                        <th>Monthly Recharge</th>
                                        <th>Balance</th>
                                        <th>Message</th>
");
            WriteLiteral("\r\n                                    </tr>\r\n\r\n                                </thead>\r\n");
            WriteLiteral("                            </table>\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</section>\r\n\r\n");
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
