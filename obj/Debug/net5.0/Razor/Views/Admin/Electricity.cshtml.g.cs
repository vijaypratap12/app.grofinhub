#pragma checksum "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Electricity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed3dfab21fd0b0373a157896180a4330f54ca747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Electricity), @"mvc.1.0.view", @"/Views/Admin/Electricity.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed3dfab21fd0b0373a157896180a4330f54ca747", @"/Views/Admin/Electricity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bbb2031673621bf224697d6f9b4bc70040137b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Electricity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "online", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "offline", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Sigma\OneDrive\Desktop\Atul Singh\Grofin\Working\Grofinhub\Grofin\Views\Admin\Electricity.cshtml"
  
    ViewData["Title"] = "Electricity";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content"">
    <div class=""container-fluid"">

        <div class=""row"">

            <div class=""col-md-12"">

                <div class=""card card-warning"">
                    <div class=""card-header"">
                        <h4 class=""card-title"">Electricity</h4>
                    </div>

                    <div class=""card-body "">

                        <div class=""row"">



                            <div class=""col-sm-6"">

                                <div class=""form-group"">
                                    <span style=""color:red"">*</span>
                                    <select class=""form-control"" id=""txtmodel"" onchange=""bindoperatorList()"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed3dfab21fd0b0373a157896180a4330f54ca7475483", async() => {
                WriteLiteral("--select Mode--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed3dfab21fd0b0373a157896180a4330f54ca7476691", async() => {
                WriteLiteral("online");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed3dfab21fd0b0373a157896180a4330f54ca7477890", async() => {
                WriteLiteral("offline");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <div class=""col-sm-6"">

                               
                                       
                               <div class=""form-group"">
                                    <input type=""hidden"" class=""form-control"" id=""ddlCategory"" name=""CityId"" />
                                    <span style=""color:red"">*</span>
                                    <select class=""form-control"" id=""ddoperator"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed3dfab21fd0b0373a157896180a4330f54ca7479681", async() => {
                WriteLiteral(" --select Operator-- ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div>

                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <span style=""color:red"">*</span>
                                    <input type=""text"" id=""txtBill"" placeholder=""Bill NO"" class=""form-control"" />
                                </div>
                                <input type=""hidden"" id=""ddlamt"">
                                <input type=""hidden"" id=""ddlUsername"">

                                <input type=""hidden"" id=""ddldate"">
                            </div>

                            <div class=""col-sm-6 mt-3"">
                                <div class=""form-group"">

                                    <button type=""button"" id=""btnSearch"" class=""btn btn-primary form-control waves-effect waves-light"" onclick=""FetchBillDetails()""> Search </button>
               ");
            WriteLiteral(@"                 </div>
                        </div>
                       




                    </div>

                </div>
            </div>
        </div>
            <div class=""col-md-12"" style=""display:none;"" id=""showbilldetailsdv"">
                <div class=""card card-warning"">
                    <div class=""card-header"">

                        <div class=""card-tools"">
                        </div>

                        <div class=""card-body"">
                            <div class=""border p-4"">
                                <div class=""row"">
                                    <div class=""col-sm-3""><lable>User Name:</lable></div>
                                    <div class=""col-sm-3""> <span id=""showusernamespan""></span></div>
                                    <div class=""col-sm-3""><lable>Amount:</lable></div>
                                    <div class=""col-sm-3""> <span id=""showamountspan""></span></div>


                                </div>
 ");
            WriteLiteral(@"                               <div class=""row"">
                                    <div class=""col-sm-3""><lable>Due Date:</lable></div>
                                    <div class=""col-sm-3""> <span id=""showduedatespan""></span></div>
                                    <div class=""col-sm-3""><lable>Bill Date:</lable></div>
                                    <div class=""col-sm-3""> <span id=""showbilldatespan""></span></div>


                                </div>
                                <div class=""row"">
                                    <div class=""col-sm-3""><lable>AD2:</lable></div>
                                    <div class=""col-sm-3""> <span id=""showad2span""></span></div>
                                    <div class=""col-sm-3""><lable>AD3:</lable></div>
                                    <div class=""col-sm-3""> <span id=""showad3pan""></span></div>


                                </div>
                            </div>

                            <br />
");
            WriteLiteral(@"
                            <input type=""button"" onclick=""PayBill()"" id=""btnsave"" class=""btn btn-primary"" value=""Pay Now"" />


                            <div style=""display:none;"">
                                <input type=""text"" id=""txtcurrentlocation"" placeholder=""Location"" />
                                <input type=""text"" id=""lat"" placeholder=""lat"" />
                                <input type=""text"" id=""lon"" placeholder=""lon"" />
                            </div>
                        </div>

                    </div>
                </div>


            </div>

    </div>

</section>


<script>

    $(document).ready(function () {
        $(""#btnsave"").hide();
    })

    var category = [];
    var operator = {};
    function bindoperatorList() {
        debugger;
        var dataobject = {
            Mode: $(""#txtmodel"").val(),
        };
        $.ajax({
            url: ""/Admin/BindOperatorList"",
            type: ""POST"",
            data: dataobject");
            WriteLiteral(@",
            success: function (r) {
                var obj = jQuery.parseJSON(r);
                //console.log(obj);
                if (obj.response_code == 1) {
                    //debugger;
                    var data = obj.data;
                    // $(""tbody"").empty();
                    $('#ddlCategory').empty();
                    //$(""#ddoperator"").empty();
                    
                    // $(""#ddoperator"").append(""<option value='0'> --select operator-- </option>"")
                    //    for (var i = 0; i < obj.data.length; i++) {
                    //        if (obj.data[i].category != null){
                    //            debugger;

                    //        $('#ddlCategory').append(""<option value='"" + obj.data[i].id + ""'>"" + obj.data[i].category + ""</option>"");
                    //           // $('#ddoperator').append(""<option value='"" + obj.data[i].id + ""'>"" + obj.data[i].name + ""</option>"");
                    //        }
                    //");
            WriteLiteral(@"    }
                    //debugger;


                    //$(""#ddlCategory"").append(""<option selected disabled value='0'> --select Category-- </option>"")


                    for (var i = 0; i < data.length; i++) {
                        if (data[i]['category'] != null) {
                            category[i] = data[i]['category'];
                        }
                    }
                    var catarr = removeDuplicates(category)
                    for (var i = 0; i < catarr.length; i++) {
                        if (catarr[i] == ""Electricity""){
                       // $('#ddlCategory').append(""<option value='"" + catarr[i] + ""'>"" + catarr[i] + ""</option>"");
                            $('#ddlCategory').val(catarr[i])
                        }
                    }
                    for (var i = 0; i < data.length; i++) {
                        operator[data[i]['id']] = data[i]['name'] + "","" + data[i]['category'];
                    }
                    var checkop ");
            WriteLiteral(@"= $('#ddlCategory').val();
                    var arrkey = Object.keys(operator)
                    for (var i = 0; i < arrkey.length; i++) {
                        var slicearr = operator[arrkey[i]].split(',');

                        if (slicearr[1] == checkop) {
                            $('#ddoperator').append(""<option value='"" + arrkey[i] + ""'>"" + slicearr[0] + ""</option>"");
                        }
                    }
                }
                // console.log(operator)
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert('Please Check values Entered by you !!!');
                $(""#showSpinner"").hide();
            }
        })
    }



    function FetchBillDetails() {
        if ($(""#txtmodel"").val() == '0') {
            alert(""Please select mode ?"")
            $(""#txtmodel"").focus();
            return false;
        }

        if ($(""#ddoperator"").val() == '0') {
            alert(""Please select o");
            WriteLiteral(@"perator ?"")
            $(""#ddoperator"").focus();
            return false;
        }


        if ($(""#txtBill"").val() == '') {
            alert(""Please enter Biil No ?"")
            $(""#txtBill"").focus();
            return false;
        }

        var dataobj = {

            Mode: $(""#txtmodel"").val(),
            OP: $(""#ddoperator"").val(),
            BillNo: $(""#txtBill"").val(),
        }
        $.ajax({
            url: ""/Admin/FetchBillDetasilsApi"",
            type: ""POST"",
            data: dataobj,
            success: function (r) {
                debugger;
                var obj = jQuery.parseJSON(r);
                console.log(obj);
                if (obj.response_code == 1) {
                    debugger;
                    //$(""tbody"").empty();
                    $(""#btnsave"").show();
                    $(""#ddlamt"").val(obj.amount)
                    $(""#ddlUsername"").val(obj.name)
                    $(""#ddldate"").val(obj.duedate)
                 ");
            WriteLiteral(@"   //$(""tbody"").append(""<tr><td>1</td> <td>"" + obj.name + ""</td><td>"" + obj.amount + ""</td>  <td>""
                    //    + obj.duedate + ""</td>  <td>"" + obj.ad2 + ""</td><td>"" + obj.ad3 + ""</td>  </tr>"");


                    $(""#showusernamespan"").text(obj.name);
                    $(""#showamountspan"").text(obj.amount);
                    $(""#showduedatespan"").text(obj.duedate);
                    $(""#showbilldatespan"").text();
                    $(""#showad2span"").text(obj.ad2);
                    $(""#showad3pan"").text(obj.ad3);

                    $(""#showbilldetailsdv"").show();
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert('Please Check values Entered by you !!!');
                $(""#showSpinner"").hide();
            }
        })
    }

    function removeDuplicates(arr) {
        return arr.filter((item,
            index) => arr.indexOf(item) === index);
    }


    //function BindBlockN");
            WriteLiteral(@"ame(arr) {
    //    // debugger;
    //    $('#ddoperator').empty();
    //    var checkop = $(""#ddlCategory"").val();
    //    var arrkey = Object.keys(operator)
    //    $(""#ddoperator"").append(""<option value='0' selected disabled > --select Operator-- </option>"")
    //    for (var i = 0; i < arrkey.length; i++) {
    //        var slicearr = operator[arrkey[i]].split(',');

    //        if (slicearr[1] == checkop) {
    //            $('#ddoperator').append(""<option value='"" + arrkey[i] + ""'>"" + slicearr[0] + ""</option>"");
    //        }
    //    }
    //    //alert($(""#ddlCategory"").val())
    //    // console.log(operator)
    //    //console.log(arrkey)
    //}


    function PayBill() {
        debugger;
        var dataobj = {
            OperatorID: $(""#ddoperator"").val(),
            Canumber: $(""#txtBill"").val(),
            Amount: $(""#ddlamt"").val(),
            Mode: $(""#txtmodel"").val(),
            UserName: $(""#ddlUsername"").val(),
            DueDate: $(""#ddl");
            WriteLiteral(@"date"").val(),
            
            Latitude: $(""#lat"").val(),
            Longitude: $(""#lon"").val()
        };
        $.ajax({
            url: ""/Admin/PayBill"",
            type: ""POST"",
            data: dataobj,
            success: function (r) {
                debugger;
                console.log(r);
                if (r.response_code == 1) {
                    alert(r.message);
                }
                else {
                    alert(r.message);
                }
            },
            error: function (XMLHttpRequest, textStatus, errorThrown) {
                alert('Please Check values Entered by you !!!');
                $(""#showSpinner"").hide();
            }
        });
    }



</script>


<script>
    $(document).ready(function () {
        debugger;
        var x = $(""#txtcurrentlocation"")
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(showPosition);
        } else {
            x.val(""Geoloc");
            WriteLiteral("ation is not supported by this browser.\");\r\n        }\r\n        function showPosition(position) {\r\n            $(\"#lat\").val(position.coords.latitude)\r\n            $(\"#lon\").val(position.coords.longitude)\r\n        }\r\n\r\n    })\r\n\r\n</script>\r\n");
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
