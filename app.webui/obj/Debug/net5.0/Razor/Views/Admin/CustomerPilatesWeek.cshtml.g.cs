#pragma checksum "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d27ff0ab71fd540031f9fa07b2ac7d61232dac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CustomerPilatesWeek), @"mvc.1.0.view", @"/Views/Admin/CustomerPilatesWeek.cshtml")]
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
#line 2 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\_ViewImports.cshtml"
using app.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\_ViewImports.cshtml"
using app.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\_ViewImports.cshtml"
using app.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d27ff0ab71fd540031f9fa07b2ac7d61232dac1", @"/Views/Admin/CustomerPilatesWeek.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c64f982aa68b539b544c37e671c4f43c6da773", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CustomerPilatesWeek : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PilatesWeek>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/online.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/MakePilatesDate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/UpdatePilatesDate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger  mt-3 col-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/online.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
  
    Customer c = Model.Pilates.Customer;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2d27ff0ab71fd540031f9fa07b2ac7d61232dac17157", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<style>
    .aaaaa{
        position: relative;
        
    }
    #sssss{
        position: absolute;
        display: flex;
        flex-direction: row;
        align-items: center;
        font-size: 15px;
        font-weight: 700;
        justify-content: space-between;
        top: -20px;
        right: 0px;
        left: 0px;
    }
    .make-flex-column-center{
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
    }
</style>
");
            }
            );
            WriteLiteral(@"
<div class=""content-wrapper"" style=""margin-top: 50px;"">

    <!-- Main content -->
    <section class=""content"">
        <section class=""content-header"">
            <div class=""container-fluid"">
                <div class=""row mb-2"">
                    <div class=""col-sm-6"">
                        <h1> ");
#nullable restore
#line 43 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Pilates</h1>\r\n                    </div>\r\n                    <div class=\"col-sm-6\">\r\n                        <ol class=\"breadcrumb float-sm-right\">\r\n                                     <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d27ff0ab71fd540031f9fa07b2ac7d61232dac19730", async() => {
                WriteLiteral("Admin");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                    <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d27ff0ab71fd540031f9fa07b2ac7d61232dac110875", async() => {
                WriteLiteral("Müsteri");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1322, "~/admin/CustomerHome/", 1322, 21, true);
#nullable restore
#line 48 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
AddHtmlAttributeValue("", 1343, Model.Pilates.Customer.Id, 1343, 26, false);

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
            WriteLiteral("</li>\r\n                                    <li class=\"breadcrumb-item \">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d27ff0ab71fd540031f9fa07b2ac7d61232dac112519", async() => {
                WriteLiteral("Pilates");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1463, "~/admin/CustomerPilates/?customerId=", 1463, 36, true);
#nullable restore
#line 49 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
AddHtmlAttributeValue("", 1499, Model.Pilates.Customer.Id, 1499, 26, false);

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
            WriteLiteral("</li>\r\n                                    <li class=\"breadcrumb-item text-danger\">");
#nullable restore
#line 50 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
                                                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Pilates</li>
                        </ol>
                    </div>
                </div>
            </div><!-- /.container-fluid -->
        </section>
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-3"">
                    <!-- Partial View -->
                    ");
#nullable restore
#line 60 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
               Write(await Html.PartialAsync("_AdminNavbar",c));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <!-- Partial View -->
                </div>
                <div class=""col-md-9"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <div class=""tab-content"">
                                <div class=""active tab-pane"" id=""activity"">
                                    <div class=""row make-flex-row space-around"">
                                        <div class=""card  g-0 shadow  bg-body rounded"" style=""width:360px;"">
                                            <div class=""card-header text-center"">
                                                <p class=""h2"">Randevu</p>
                                                <hr>
                                            </div>
                                            <div class=""card-body g-0"">
                                                <div class=""row make-flex-column center"" style=""min-height: 200px;"">

");
#nullable restore
#line 77 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
                                                     if (Model.calendar == null)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p class=\"text-center h3\">Randevu Verilmedi\r\n                                                        </p>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d27ff0ab71fd540031f9fa07b2ac7d61232dac116687", async() => {
                WriteLiteral(@"

                                                            <div class=""form-group row mt-2"">
                                                                <label for=""DateTime""
                                                                class=""col-sm-2 col-form-label"">Tarih</label>
                                                                <div class=""col-sm-10"">
                                                                    <input type=""datetime-local""  class=""form-control""
                                                                    id=""DateTime"" name=""TimeofDates"" required>
                                                                </div>
                                                            </div>
                                                            <div class=""form-group row mt-2"">
                                                                <label for=""Durations""
                                                                class=""col-sm-2 col");
                WriteLiteral(@"-form-label"">Süre</label>
                                                                <div class=""col-sm-10"">
                                                                    <input type=""number"" step=""10"" min=""10"" name=""durations""
                                                                    class=""form-control"" id=""DateTime"" value=""10"">
                                                                </div>
                                                            </div>
                                                            <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 5001, "\"", 5042, 1);
#nullable restore
#line 99 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
WriteAttributeValue("", 5009, Model.Pilates.Customer.FirstName, 5009, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                                            name=\"firstname\">\r\n                                                            <input type=\"hidden\" name=\"customerId\"");
                BeginWriteAttribute("value", " value=\"", 5222, "\"", 5256, 1);
#nullable restore
#line 101 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
WriteAttributeValue("", 5230, Model.Pilates.Customer.Id, 5230, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5340, "\"", 5380, 1);
#nullable restore
#line 102 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
WriteAttributeValue("", 5348, Model.Pilates.Customer.LastName, 5348, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                                            name=\"lastname\">\r\n                                                            <input type=\"hidden\" name=\"pilatesWeekId\"");
                BeginWriteAttribute("value", " value=\"", 5562, "\"", 5579, 1);
#nullable restore
#line 104 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
WriteAttributeValue("", 5570, Model.Id, 5570, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                            <div class=""row center "">
                                                                <button class=""btn btn-warning  mt-3 col-6""
                                                                type=""submit"">Randevu Ayarla</button>
                                                            </div>
                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 110 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"

                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p class=\"card-title text-center h1 p-3 text-white bg-dark\">\r\n                                                            ");
#nullable restore
#line 115 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
                                                        Write(Model.calendar.CurrentDay+"/"+Model.calendar.CurrentMounth+"/"+Model.calendar.CurrentYear+" "+Model.calendar.CurrentHour);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("Form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d27ff0ab71fd540031f9fa07b2ac7d61232dac123718", async() => {
                WriteLiteral(@"

                                                            <div class=""form-group row mt-2"">
                                                                <label for=""DateTime""
                                                                class=""col-sm-2 col-form-label"">Tarih</label>
                                                                <div class=""col-sm-10"">
                                                                    <input type=""datetime-local"" class=""form-control""
                                                                    id=""DateTime"" name=""TimeofDates"" required>
                                                                </div>
                                                            </div>
                                                            <div class=""form-group row mt-2"">
                                                                <label for=""Durations""
                                                                class=""col-sm-2 col-");
                WriteLiteral(@"form-label"">Tarih</label>
                                                                <div class=""col-sm-10"">
                                                                    <input type=""number"" step=""10"" min=""10"" name=""durations""
                                                                    class=""form-control"" id=""DateTime"" value=""10"">
                                                                </div>
                                                            </div>
                                                            <input type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 8205, "\"", 8246, 1);
#nullable restore
#line 134 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
WriteAttributeValue("", 8213, Model.Pilates.Customer.FirstName, 8213, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                                            name=\"firstname\">\r\n                                                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 8408, "\"", 8448, 1);
#nullable restore
#line 136 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
WriteAttributeValue("", 8416, Model.Pilates.Customer.LastName, 8416, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                                                            name=\"lastname\">\r\n                                                            <input type=\"hidden\" name=\"pilatesWeekId\"");
                BeginWriteAttribute("value", " value=\"", 8630, "\"", 8647, 1);
#nullable restore
#line 138 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
WriteAttributeValue("", 8638, Model.Id, 8638, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                            <input type=\"hidden\" name=\"customerId\"");
                BeginWriteAttribute("value", " value=\"", 8749, "\"", 8783, 1);
#nullable restore
#line 139 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
WriteAttributeValue("", 8757, Model.Pilates.Customer.Id, 8757, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                            <input type=\"hidden\" name=\"DateId\"");
                BeginWriteAttribute("value", " value=\"", 8881, "\"", 8907, 1);
#nullable restore
#line 140 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
WriteAttributeValue("", 8889, Model.calendar.Id, 8889, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                            <div class=""row center "">
                                                                <button class=""btn btn-warning  mt-3 col-6""
                                                                type=""submit"">Randevu değiştir</button>

                                                            </div>
                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d27ff0ab71fd540031f9fa07b2ac7d61232dac130292", async() => {
                WriteLiteral("Randevu\r\n                                                            Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9412, "~/admin/RemoveDatePilates?pilatesWeekId=", 9412, 40, true);
#nullable restore
#line 147 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
AddHtmlAttributeValue("", 9452, Model.Id, 9452, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 9461, "&DateId=", 9461, 8, true);
#nullable restore
#line 147 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
AddHtmlAttributeValue("", 9469, Model.calendar.Id, 9469, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 9487, "&customerId=", 9487, 12, true);
#nullable restore
#line 147 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
AddHtmlAttributeValue("", 9499, Model.Pilates.Customer.Id, 9499, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 149 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\CustomerPilatesWeek.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d27ff0ab71fd540031f9fa07b2ac7d61232dac133455", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PilatesWeek> Html { get; private set; }
    }
}
#pragma warning restore 1591