#pragma checksum "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e739cb0e15dc32f237c72be6df2fa906bd064c6"
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
#line 8 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e739cb0e15dc32f237c72be6df2fa906bd064c6", @"/Views/Admin/Recharge.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
  
    ViewData["Title"] = "Recharge";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<style>



   .wraperplan {
    min-width: 120px;
    max-height: 450px;
    overflow-y: scroll;
}

    body {
        padding: 10px;
    }

    #exTab1 .tab-content {
        color: white;
        background-color: #428bca;
        padding: 5px 15px;
    }

    #exTab2 h3 {
        color: white;
        background-color: #428bca;
        padding: 5px 15px;
    }

    /* remove border radius for the tab */

    #exTab1 .nav-pills > li > a {
        border-radius: 0;
    }

    /* change border radius for the tab , apply corners on top*/

    #exTab3 .nav-pills > li > a {
        border-radius: 4px 4px 0 0;
    }

    #exTab3 .tab-content {
        color: white;
        background-color: #428bca;
        padding: 5px 15px;
    }

    ul#myTab {
        display: flex;
        width: 100%;
    }

    .tab-pane {
        padding: 18px;
    }

    nav#myTab {
        display: block !important;
    }

    .tab-content {
        width: 100%;
        backgr");
            WriteLiteral(@"ound: #fff;
    }
</style>

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
    ");
            WriteLiteral(@"        processData: false,
            data: data,
            success: function (r) {
                if (r != null) {
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

    function bildrsddlpan(rs) {
        $(""#ddlplan"").val(rs);
        $(""#btnSearchdorecharge"").removeAttr(""disabled"");
        $(window).scrollTop(0);
    }


    function QueryDTHRechargecheckBrowsPlan() {
        var data = new FormData;

        data.append(""circle"", $(""#ddlcircle"").val());
        data.append(""op"", $(""#ddloperator"").val());


        $(""#showSpinner"").show();

        $.aja");
            WriteLiteral(@"x({
            url: ""/Admin/DTHBrjowsPlan"",
            type: ""POST"",
            contentType: false,
            processData: false,
            data: data,
            success: function (r) {
                debugger;
                //console.log(r)
                //var dt=eval(r)
                var dt = jQuery.parseJSON(r);
                //console.log(dt.info.TOPUP)
                $(""#tbl_plan"").empty();
                $(""#ddlplan"").empty();
                $(""#ddlplan"").append(""<option value='0' disabled selected>-- Select Plan --</option>"")
                if (dt != """" && dt != """") {
                    var allplan = dt.info;
                    var fttplan = allplan.FULLTT;
                    var plan2g = allplan['2G'];
                    var plan3g4g = allplan['3G/4G'];
                    var plan1 = allplan.TOPUP;
                    var plansms = allplan.SMS;
                    var plan2 = allplan.COMBO;
                    //if (fttplan != null && fttplan != """") {");
            WriteLiteral(@"
                    //    for (var item of fttplan) {
                    //        $(""#ddlplan"").append(""<option value=""+item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbsp;&nbsp; "" + item.desc + ""</option>"")
                    //    }

                    //}
                    //var plan3g4g = allplan['3G/4G'];
                    //if (plan3g4g != null && plan3g4g != """") {
                    //    for (var item of plan3g4g) {
                    //        $(""#ddlplan"").append(""<option value="" + item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbsp;&nbsp; "" + item.desc + ""</option>"")
                    //    }

                    //}
                    //var plan1 = allplan.TOPUP;
                    //if (plan1 != null && plan1 != """") {
                    //    for (var item of plan1) {
                    //        $(""#ddlplan"").append(""<option value="" + item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbs");
            WriteLiteral(@"p;&nbsp; "" + item.desc + ""</option>"")
                    //    }
                    //}
                    //var plan2 = allplan.COMBO;
                    //if (plan2 != null && plan2 != """") {
                    //    for (var item of plan2) {
                    //        $(""#ddlplan"").append(""<option value="" + item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbsp;&nbsp; "" + item.desc + ""</option>"")
                    //    }
                    //}
                    //var plansms = allplan.SMS;
                    //if (plansms != null && plansms != """") {
                    //    for (var item of plansms) {
                    //        $(""#ddlplan"").append(""<option value="" + item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbsp;&nbsp; "" + item.desc + ""</option>"")
                    //    }

                    //}
                    //var plan2g = allplan['2G'];
                    //if (plan2g != null && plan2g != """") {
       ");
            WriteLiteral(@"             //    for (var item of plan2g) {
                    //        $(""#ddlplan"").append(""<option value="" + item.rs+"">"" + item.rs + "" &nbsp;&nbsp;&nbsp; "" + item.validity + "" &nbsp;&nbsp;&nbsp; "" + item.desc + ""</option>"")
                    //    }

                    //}
                    ////bind tbl plan

                    if (plan3g4g != null && plan3g4g != """") {
                        //alert(""hjnjh"")
                        $(""#tbl_plan"").append(""<tr><th>3G/4G</th></tr>"")
                        for (var item of plan3g4g) {
                            $(""#tbl_plan"").append(""<tr onclick='bildrsddlpan("" + item.rs + "")' class1='border' style='min-width:120px;min-height:100px;'><td class1='px-5 py-3'>"" + item.rs + ""</td><td class1='px-5 py-3'>"" + item.validity + ""</td><td class1='px-4 py-3'> "" + item.desc + "" </td></tr> "")
                        }

                    }
                    if (fttplan != null && fttplan != """") {
                        //alert(""hjnjh"")
    ");
            WriteLiteral(@"                    $(""#tbl_plan"").append(""<tr><th>FULL TALKTIME</th></tr>"")
                        for (var item of fttplan) {
                            $(""#tbl_plan"").append(""<tr onclick='bildrsddlpan("" + item.rs + "")' class1='border' style='min-width:120px;min-height:100px;'><td class1='px-5 py-3'>"" + item.rs + ""</td><td class1='px-5 py-3'>"" + item.validity + ""</td><td class1='px-4 py-3'> "" + item.desc + "" </td></tr> "")
                        }

                    }

                    if (plan1 != null && plan1 != """") {
                        //alert(""hjnjh"")
                        $(""#tbl_plan"").append(""<tr><th>TOP UP </th></tr>"")
                        for (var item of plan1) {
                            $(""#tbl_plan"").append(""<tr onclick='bildrsddlpan("" + item.rs + "")' class1='border' style='min-width:120px;min-height:100px;'><td class1='px-5 py-3'>"" + item.rs + ""</td><td class1='px-5 py-3'>"" + item.validity + ""</td><td class1='px-4 py-3'> "" + item.desc + "" </td></tr> "")
         ");
            WriteLiteral(@"               }
                    }
                    if (plan2 != null && plan2 != """") {
                        //alert(""hjnjh"")
                        $(""#tbl_plan"").append(""<tr><th>COMBO PACK </th></tr>"")
                        for (var item of plan2) {
                            $(""#tbl_plan"").append(""<tr onclick='bildrsddlpan("" + item.rs + "")' class1='border' style='min-width:120px;min-height:100px;'><td class1='px-5 py-3'>"" + item.rs + ""</td><td class1='px-5 py-3'>"" + item.validity + ""</td><td class1='px-4 py-3'> "" + item.desc + "" </td></tr> "")
                        }
                    }
                    if (plansms != null && plansms != """") {
                        //alert(""hjnjh"")
                        $(""#tbl_plan"").append(""<tr><th>SMS PACK </th></tr>"")
                        for (var item of plansms) {
                            $(""#tbl_plan"").append(""<tr onclick='bildrsddlpan("" + item.rs + "")' class1='border' style='min-width:120px;min-height:100px;'><td class1='px");
            WriteLiteral(@"-5 py-3'>"" + item.rs + ""</td><td class1='px-5 py-3'>"" + item.validity + ""</td><td class1='px-4 py-3'> "" + item.desc + "" </td></tr> "")
                        }
                    }
                    if (plan2g != null && plan2g != """") {
                        //alert(""hjnjh"")
                        $(""#tbl_plan"").append(""<tr><th>2G PACK </th></tr>"")
                        for (var item of plan2g) {
                            $(""#tbl_plan"").append(""<tr onclick='bildrsddlpan("" + item.rs + "")' class1='border' style='min-width:120px;min-height:100px;'><td class1='px-5 py-3'>"" + item.rs + ""</td><td class1='px-5 py-3'>"" + item.validity + ""</td><td class1='px-4 py-3'> "" + item.desc + "" </td></tr> "")
                        }
                    }
                    $(""tr"").attr(""class"", ""card p-2"")
                }
                else {
                    alert('Server not Responding !!!');
                    $(""#showSpinner"").hide();
                }
            },
            error: f");
            WriteLiteral("unction (XMLHttpRequest, textStatus, errorThrown) {\r\n                alert(\'Please Check values Entered by you !!!\');\r\n                $(\"#showSpinner\").hide();\r\n            }\r\n\r\n\r\n        });\r\n    }\r\n\r\n\r\n\r\n</script>\r\n\r\n");
            WriteLiteral(@"







<div class=""row"">
    <div class=""col-12 "">
        <div class=""box q1 bg-gradient-primary overflow-hidden pull-up"">
            <div class=""box-body pr-0 pl-lg-50 pl-15 py-0"">
                <div class=""row align-items-center"">
                    <div class=""col-12 col-lg-8"">
                        <h3 class=""font-size-25 text-white"">Recharge</h3>
                       
                    </div>
");
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<!--Tab-->


<nav class=""navbar navbar-expand-lg navbar-light bg-light"" id=""myTab"" role=""tablist"">



    <div class=""tab-content"" id=""myTabContent"">
        <div class=""tab-pane fade show active"" id=""demo"" role=""tabpanel"" aria-labelledby=""home-tab"">

            <section class=""content"" id=""dorechargedv"">
                <div class=""container-fluid"">

                    <div class=""row"">

                        <div class=""col-md-12"">

                            <div");
            BeginWriteAttribute("class", " class=\"", 12642, "\"", 12650, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral(@"

                                <!-- brows Plan start -->   

                                <div class=""row"">

                                    <div class=""col-md-4"" >
                                         <div class=""col-md-12 mb-3"">

                                            <div class=""form-group"">
                                                <label>Phone No:	 </label>
                                                <input type=""text"" class=""form-control"" placeholder=""Enter Phone No"" maxlength=""10"" id=""txtPhone1rech"" onkeypress=""return numeric(event);"" onchange=""phonenumberlength();"" />

                                            </div>
                                        </div>
                                        <div class=""col-md-12 mb-2"">


                                            <label>  Circle:</label>
                                            <select class=""form-control"" onchange=""QueryDTHRechargecheckBrowsPlan()"" id=""ddlcircle"" required name=""Pipe"">");
            WriteLiteral("\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e739cb0e15dc32f237c72be6df2fa906bd064c617513", async() => {
                WriteLiteral("-- Select Circle --");
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
#line 368 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
                                                 foreach (DataRow dr in ViewBag.rechargeplan.Rows)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e739cb0e15dc32f237c72be6df2fa906bd064c619727", async() => {
                WriteLiteral(" ");
#nullable restore
#line 370 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
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
#line 370 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
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
#line 371 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </select>
                                        </div>

                                        <div class=""col-md-12 mb-2"">

                                            <label> Operator:</label>

                                            <select class=""form-control"" onchange=""QueryDTHRechargecheckBrowsPlan()"" id=""ddloperator"" required name=""Pipe"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e739cb0e15dc32f237c72be6df2fa906bd064c622440", async() => {
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
#line 381 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
                                                 foreach (DataRow dr in Model.Rows)
                                                {
                                                    if (@dr["category"].ToString() != "DTH")
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e739cb0e15dc32f237c72be6df2fa906bd064c624794", async() => {
                WriteLiteral(" ");
#nullable restore
#line 385 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
                                                                                                  Write(dr["name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ");
#nullable restore
#line 385 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
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
#line 385 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
                                                           WriteLiteral(dr["name"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "idval", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 385 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
AddHtmlAttributeValue("", 15176, dr["id"], 15176, 9, false);

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
#line 386 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Recharge.cshtml"
                                                    }
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </select>
                                        </div>

                                      

                                        <div class=""col-md-12 mb-2"">

                                            <label>Plan:</label>

                                            <input type=""text"" class=""form-control"" id=""ddlplan"" required name=""Pipe"" />
");
            WriteLiteral("                                        </div>\r\n\r\n");
            WriteLiteral(@"
                                        <div class=""col-md-12 p-3"">
                                            <button type=""button"" id=""btnSearchdorecharge"" disabled class=""btn btn-primary waves-effect waves-light"" onclick=""QueryRechargecheck()"">Do Recharge </button>


                                        </div>

                                        <div class=""row"">

                                            <div class=""col-md-12"">

                                                <div");
            BeginWriteAttribute("class", " class=\"", 17342, "\"", 17350, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                 

                                                    <div class=""card-body border  "">

                                                     
                                                      
                                                        <div class=""row"">
                                                            <div class=""card-header"">
");
            WriteLiteral(@"                                                            </div>
                                                            <h4 class=""text-center"" id=""resmsg""></h4>
                                                            <div class=""col-sm-12 p-3"">
                                                                <span style=""color:red"">*</span> <label>
                                                                    Status Enquiry
                                                                </label>
                                                                <input id=""txtrefid"" type=""text"" placeholder=""enter ReferenceId.."" class=""form-control"" />
                                                            </div>
                                                            <div class=""col-md-lg -6"">
                                                                <button type=""button"" id=""btnSearch"" class=""btn btn-primary "" onclick=""checkEnquiryStatus()"">Check Status </button>

     ");
            WriteLiteral(@"                                                       </div>

                                                        </div>




                                                    </div>

                                                </div>
                                            </div>
                                        </div>



                                    </div>
                                    
                                    <div class=""col-md-8  border"">
                                        <div class=""box-header"">
                                            <ul class=""nav nav-tabs customtab nav-justified"" role=""tablist"">

                                                <li class=""nav-item"">
                                                    <button class=""nav-link"" id=""home-tab"" data-bs-toggle=""tab"" data-bs-target=""#messages"" type=""button"" role=""tab"" aria-controls=""home"" aria-selected=""false"">3G/4G</button>
                                         ");
            WriteLiteral(@"       </li>
                                                <li class=""nav-item"">
                                                    <button class=""nav-link"" id=""Benificiary-tab"" data-bs-toggle=""tab"" data-bs-target=""#contacts"" type=""button"" role=""tab"" aria-controls=""Benificiary"" aria-selected=""false"">TOP UP</button>
                                                </li>
                                                <li class=""nav-item"">
                                                    <button class=""nav-link"" id=""Refund-tab"" data-bs-toggle=""tab"" data-bs-target=""#demo3"" type=""button"" role=""tab"" aria-controls=""Refund"" aria-selected=""false"">COMBO</button>
                                                </li>
                                                <li class=""nav-item"">
                                                    <button class=""nav-link active"" id=""TransactionStatus-tab"" data-bs-toggle=""tab"" data-bs-target=""#demo4"" type=""button"" role=""tab"" aria-controls=""TransactionStatus"" aria-selec");
            WriteLiteral(@"ted=""true""> TalkTime</button>
                                                </li>
                                            </ul>
                                        </div>


                                        <div class=""col-md-12 wraperplan"">


                                          
                                            <table id=""tbl_plan"">
                                            </table>
                                        </div>

                                    </div>

                                </div>



                              

                            </div>

                        </div>
                    </div>

                    <div class=""col-md-12"" style=""display:none;"">
                        <div class=""card card-warning"">
                            <div class=""card-header"">
                                <div class=""card-tools"">
                                </div>

                                <di");
            WriteLiteral(@"v class=""card-body"">
                                    <div style=""overflow-x:auto;"">

                                        <table id=""example3"" class=""my  table table-bordered table-responsive table-hover"">
                                            <thead>
                                                <tr>
                                                    <th rowspan=""2"" colspan=""2"">Sr.No.</th>
                                                    <th>Customer Name</th>
                                                    <th>NextRechargeDate</th>
                                                    <th>Planname</th>
                                                    <th>Monthly Recharge</th>
                                                    <th>Balance</th>
                                                    <th>Message</th>
");
            WriteLiteral("\r\n                                                </tr>\r\n\r\n                                            </thead>\r\n");
            WriteLiteral(@"                                        </table>


                                    </div>
                                </div>

                            </div>
                        </div>


                    </div>

                </div>

            </section>

        </div>
        <div class=""tab-pane fade"" id=""demo1"" role=""tabpanel"" aria-labelledby=""profile-tab"" style=""display:none"">

            <section class=""content"" id=""checkstatusdv"">
                <div class=""container-fluid"">
                </div>

            </section>


        </div>

    </div>

</nav>
<!--Tab End-->





<script>
    $(document).ready(function () {
        //$(""#checkstatusdv"").hide()
    })
    function chackStatesHideShow() {
        $(""#checkstatusdv"").show()
        $(""#dorechargedv"").hide()
    }
    function doRechargeHideShow() {
        $(""#checkstatusdv"").hide()
        $(""#dorechargedv"").show()
    }

    function checkEnquiryStatus() {
        i");
            WriteLiteral(@"f ($(""#txtrefid"").val() == """") {
            $(""#txtrefid"").focus();
            alert(""Enter Reference Id !!"")
            return;
        }
        var dataobj = new FormData;

        dataobj.append(""referenceid"", $(""#txtrefid"").val());

        $(""#showSpinner"").show();
        $.ajax({
            url: ""/Admin/DoRechargeStatesEnquiry"",
            type: ""POST"",
            contentType: false,
            processData: false,
            data: dataobj,
            success: function (r) {
                // debugger;

                if (r == ""Something Went Wrong!!"" || r == ""Enter Reference Number!!"") {
                    $(""#resmsg"").text(r)
                }
                else {
                    var res = jQuery.parseJSON(r);
                    if (res != null) {
                        $(""#resmsg"").text(res.message)
                        debugger;
                        if (res.data.status == ""0"") {
                            $(""#resmsg"").css(""color"", ""green"")
   ");
            WriteLiteral(@"                     }
                        else {
                            $(""#resmsg"").css(""color"", ""red"")
                        }

                    }
                    $(""#txtrefid"").val("""")
                }
                //console.log(res)

                $(""#showSpinner"").hide();
            },
            error: function () {
                alert(""Error Occured !!!"")
                $(""#showSpinner"").hide();
            }
        })
    }
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
