#pragma checksum "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Online\AnamnezForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9eb353fc436c65db93383aba5c17c009c8283f1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Online_AnamnezForm), @"mvc.1.0.view", @"/Views/Online/AnamnezForm.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\_ViewImports.cshtml"
using app.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\_ViewImports.cshtml"
using app.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\_ViewImports.cshtml"
using app.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb353fc436c65db93383aba5c17c009c8283f1c", @"/Views/Online/AnamnezForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c64f982aa68b539b544c37e671c4f43c6da773", @"/Views/_ViewImports.cshtml")]
    public class Views_Online_AnamnezForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("msform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("css", async() => {
                WriteLiteral(@"
<style>
    #grad1 {
        background-color: #9C27B0;
        background-image: linear-gradient(120deg, #FF4081, #81D4FA);
    }

    #msform {
        text-align: center;
        position: relative;
        margin-top: 20px;
    }

    #msform fieldset .form-card {
        background: white;
        border: 0 none;
        border-radius: 0px;
        box-shadow: 0 2px 2px 2px rgba(0, 0, 0, 0.2);
        padding: 20px 40px 30px 40px;
        box-sizing: border-box;
        width: 94%;
        margin: 0 3% 20px 3%;
        position: relative
    }

    #msform fieldset {
        background: white;
        border: 0 none;
        border-radius: 0.5rem;
        box-sizing: border-box;
        width: 100%;
        margin: 0;
        padding-bottom: 20px;
        position: relative
    }

    #msform fieldset:not(:first-of-type) {
        display: none
    }

    #msform fieldset .form-card {
        text-align: left;
        color: #9E9E9E
    }

    #msform input,
                WriteLiteral(@"
    #msform textarea {
        padding: 0px 8px 4px 8px;
        border: none;
        border-bottom: 1px solid #ccc;
        border-radius: 0px;
        margin-bottom: 25px;
        margin-top: 2px;
        width: 100%;
        box-sizing: border-box;
        font-family: montserrat;
        color: #2C3E50;
        font-size: 16px;
        letter-spacing: 1px
    }

    #msform input:focus,
    #msform textarea:focus {
        -moz-box-shadow: none !important;
        -webkit-box-shadow: none !important;
        box-shadow: none !important;
        border: none;
        font-weight: bold;
        border-bottom: 2px solid skyblue;
        outline-width: 0
    }

    #msform .action-button {
        width: 100px;
        background: skyblue;
        font-weight: bold;
        color: white;
        border: 0 none;
        border-radius: 0px;
        cursor: pointer;
        padding: 10px 5px;
        margin: 10px 5px
    }

    #msform .action-button:hover,
    #msform .a");
                WriteLiteral(@"ction-button:focus {
        box-shadow: 0 0 0 2px white, 0 0 0 3px skyblue
    }

    #msform .action-button-previous {
        width: 100px;
        background: #616161;
        font-weight: bold;
        color: white;
        border: 0 none;
        border-radius: 0px;
        cursor: pointer;
        padding: 10px 5px;
        margin: 10px 5px
    }

    #msform .action-button-previous:hover,
    #msform .action-button-previous:focus {
        box-shadow: 0 0 0 2px white, 0 0 0 3px #616161
    }

    select.list-dt {
        border: none;
        outline: 0;
        border-bottom: 1px solid #ccc;
        padding: 2px 5px 3px 5px;
        margin: 2px
    }

    select.list-dt:focus {
        border-bottom: 2px solid skyblue
    }

    .card {
        z-index: 0;
        border: none;
        border-radius: 0.5rem;
        position: relative
    }

    .fs-title {
        font-size: 25px;
        color: #2C3E50;
        margin-bottom: 10px;
        font-weight: bo");
                WriteLiteral(@"ld;
        text-align: left
    }

    #progressbar {
        margin-bottom: 30px;
        overflow: hidden;
        color: lightgrey
    }

    #progressbar .active {
        color: #000000
    }

    #progressbar li {
        list-style-type: none;
        font-size: 12px;
        width: 25%;
        float: left;
        position: relative
    }

    #progressbar #account:before {
        font-family: FontAwesome;
        content: ""\f023""
    }

    #progressbar #personal:before {
        font-family: FontAwesome;
        content: ""\f007""
    }

    #progressbar #payment:before {
        font-family: FontAwesome;
        content: ""\f09d""
    }

    #progressbar #confirm:before {
        font-family: FontAwesome;
        content: ""\f00c""
    }

    #progressbar li:before {
        width: 50px;
        height: 50px;
        line-height: 45px;
        display: block;
        font-size: 18px;
        color: #ffffff;
        background: lightgray;
        border");
                WriteLiteral(@"-radius: 50%;
        margin: 0 auto 10px auto;
        padding: 2px
    }

    #progressbar li:after {
        content: '';
        width: 100%;
        height: 2px;
        background: lightgray;
        position: absolute;
        left: 0;
        top: 25px;
        z-index: -1
    }

    #progressbar li.active:before,
    #progressbar li.active:after {
        background: skyblue
    }

    .radio-group {
        position: relative;
        margin-bottom: 25px
    }

    .radio {
        display: inline-block;
        width: 204;
        height: 104;
        border-radius: 0;
        background: lightblue;
        box-shadow: 0 2px 2px 2px rgba(0, 0, 0, 0.2);
        box-sizing: border-box;
        cursor: pointer;
        margin: 8px 2px
    }

    .radio:hover {
        box-shadow: 2px 2px 2px 2px rgba(0, 0, 0, 0.3)
    }

    .radio.selected {
        box-shadow: 1px 1px 2px 2px rgba(0, 0, 0, 0.1)
    }

    .fit-image {
        width: 100%;
        objec");
                WriteLiteral("t-fit: cover\r\n    }\r\n</style>\r\n");
            }
            );
            WriteLiteral(@"
<!-- MultiStep Form -->
<div class=""container-fluid"" id=""grad1"">
    <div class=""row justify-content-center mt-0"">
        <div class=""col-11 col-sm-9 col-md-7 col-lg-6 text-center p-0 mt-3 mb-2"">
            <div class=""card px-0 pt-4 pb-0 mt-3 mb-3"">
                <h2><strong>Sign Up Your User Account</strong></h2>
                <p>Fill all form field to go to next step</p>
                <div class=""row"">
                    <div class=""col-md-12 mx-0"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c10254", async() => {
                WriteLiteral(@"
                            <!-- progressbar -->
                            <ul id=""progressbar"">
                                <li class=""active"" id=""account""><strong>Account</strong></li>
                                <li id=""personal""><strong>Personal</strong></li>
                                <li id=""payment""><strong>Payment</strong></li>
                                <li id=""confirm""><strong>Finish</strong></li>
                            </ul> <!-- fieldsets -->
                            <fieldset>
                                <div class=""form-card"">
                                    <h2 class=""fs-title"">Account Information</h2>
                                    <input type=""email"" name=""email"" placeholder=""Email Id"" />
                                    <input type=""text"" name=""uname"" placeholder=""UserName"" />
                                    <input type=""password"" name=""pwd"" placeholder=""Password"" />
                                    <input type=""password"" name");
                WriteLiteral(@"=""cpwd"" placeholder=""Confirm Password"" />
                                </div> <input type=""button"" name=""next"" class=""next action-button"" value=""Next Step"" />
                            </fieldset>
                            <fieldset>
                                <div class=""form-card"">
                                    <h2 class=""fs-title"">Personal Information</h2> <input type=""text"" name=""fname""
                                        placeholder=""First Name"" /> <input type=""text"" name=""lname""
                                        placeholder=""Last Name"" /> <input type=""text"" name=""phno""
                                        placeholder=""Contact No."" /> <input type=""text"" name=""phno_2""
                                        placeholder=""Alternate Contact No."" />
                                </div> <input type=""button"" name=""previous"" class=""previous action-button-previous""
                                    value=""Previous"" /> <input type=""button"" name=""next"" class=""next actio");
                WriteLiteral(@"n-button""
                                    value=""Next Step"" />
                            </fieldset>
                            <fieldset>
                                <div class=""form-card"">
                                    <h2 class=""fs-title"">Payment Information</h2>
                                    <div class=""radio-group"">
                                        <div class='radio' data-value=""credit""><img
                                                src=""https://i.imgur.com/XzOzVHZ.jpg"" width=""200px"" height=""100px"">
                                        </div>
                                        <div class='radio' data-value=""paypal""><img
                                                src=""https://i.imgur.com/jXjwZlj.jpg"" width=""200px"" height=""100px"">
                                        </div> <br>
                                    </div> <label class=""pay"">Card Holder Name*</label> <input type=""text""
                                        name=""holdername""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 8759, "\"", 8773, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-9\"> <label class=\"pay\">Card Number*</label> <input type=\"text\"\r\n                                                name=\"cardno\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 9015, "\"", 9029, 0);
                EndWriteAttribute();
                WriteLiteral(@" /> </div>
                                        <div class=""col-3""> <label class=""pay"">CVC*</label> <input type=""password""
                                                name=""cvcpwd"" placeholder=""***"" /> </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-3""> <label class=""pay"">Expiry Date*</label> </div>
                                        <div class=""col-9""> <select class=""list-dt"" id=""month"" name=""expmonth"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c14974", async() => {
                    WriteLiteral("Month");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c16359", async() => {
                    WriteLiteral("January");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c17423", async() => {
                    WriteLiteral("February");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c18488", async() => {
                    WriteLiteral("March");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c19550", async() => {
                    WriteLiteral("April");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c20612", async() => {
                    WriteLiteral("May");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c21672", async() => {
                    WriteLiteral("June");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c22733", async() => {
                    WriteLiteral("July");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c23794", async() => {
                    WriteLiteral("August");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c24857", async() => {
                    WriteLiteral("September");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c25923", async() => {
                    WriteLiteral("October");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c26987", async() => {
                    WriteLiteral("November");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c28052", async() => {
                    WriteLiteral("December");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </select> <select class=\"list-dt\" id=\"year\" name=\"expyear\">\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eb353fc436c65db93383aba5c17c009c8283f1c29230", async() => {
                    WriteLiteral("Year");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
                WriteLiteral(@"
                                            </select> </div>
                                    </div>
                                </div> <input type=""button"" name=""previous"" class=""previous action-button-previous""
                                    value=""Previous"" /> <input type=""button"" name=""make_payment""
                                    class=""next action-button"" value=""Confirm"" />
                            </fieldset>
                            <fieldset>
                                <div class=""form-card"">
                                    <h2 class=""fs-title text-center"">Success !</h2> <br><br>
                                    <div class=""row justify-content-center"">
                                        <div class=""col-3""> <img src=""https://img.icons8.com/color/96/000000/ok--v2.png""
                                                class=""fit-image""> </div>
                                    </div> <br><br>
                                    <div class=""row justif");
                WriteLiteral(@"y-content-center"">
                                        <div class=""col-7 text-center"">
                                            <h5>You Have Successfully Signed Up</h5>
                                        </div>
                                    </div>
                                </div>
                            </fieldset>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    $(document).ready(function () {

        var current_fs, next_fs, previous_fs; //fieldsets
        var opacity;

        $("".next"").click(function () {

            current_fs = $(this).parent();
            next_fs = $(this).parent().next();

            //Add Class Active
            $(""#progressbar li"").eq($(""fieldset"").index(next_fs)).addClass(""active"");

            //show the next fieldset
            next_fs.show();
            //hide the current fieldset with style
            current_fs.animate({ opacity: 0 }, {
                step: function (now) {
                    // for making fielset appear animation
                    opacity = 1 - now;

                    current_fs.css({
                        'display': 'none',
                        'position': 'relative'
                    });
                    next_fs.css({ 'opacity': opacity });
                },
                duration: 600
            });
        });

        $("".previous"").cli");
                WriteLiteral(@"ck(function () {

            current_fs = $(this).parent();
            previous_fs = $(this).parent().prev();

            //Remove class active
            $(""#progressbar li"").eq($(""fieldset"").index(current_fs)).removeClass(""active"");

            //show the previous fieldset
            previous_fs.show();

            //hide the current fieldset with style
            current_fs.animate({ opacity: 0 }, {
                step: function (now) {
                    // for making fielset appear animation
                    opacity = 1 - now;

                    current_fs.css({
                        'display': 'none',
                        'position': 'relative'
                    });
                    previous_fs.css({ 'opacity': opacity });
                },
                duration: 600
            });
        });

        $('.radio-group .radio').click(function () {
            $(this).parent().find('.radio').removeClass('selected');
            $(this).addClass('s");
                WriteLiteral("elected\');\r\n        });\r\n\r\n        $(\".submit\").click(function () {\r\n            return false;\r\n        })\r\n\r\n    });\r\n</script>\r\n\r\n");
            }
            );
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