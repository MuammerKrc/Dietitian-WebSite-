#pragma checksum "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5de92250fc2bd81f1a2c1034225fc6b64deacc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CustomerDiet), @"mvc.1.0.view", @"/Views/Admin/CustomerDiet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5de92250fc2bd81f1a2c1034225fc6b64deacc1", @"/Views/Admin/CustomerDiet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c64f982aa68b539b544c37e671c4f43c6da773", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CustomerDiet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/online.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/online/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CustomerNavbar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/online.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("css", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c5de92250fc2bd81f1a2c1034225fc6b64deacc16223", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"

<div class=""content-wrapper"" style=""margin-top: 50px;"">

    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Online Diyet</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5de92250fc2bd81f1a2c1034225fc6b64deacc17910", async() => {
                WriteLiteral("AnaSayfa");
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
            WriteLiteral(@"</li>
                        <li class=""breadcrumb-item text-danger"">Diyet</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-3"">

                    <!-- Partial View -->
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c5de92250fc2bd81f1a2c1034225fc6b64deacc19441", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "value", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml"
AddHtmlAttributeValue("", 1041, Model, 1041, 6, false);

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
            WriteLiteral(@"
                        <!-- Partial View -->

                </div>
                <div class=""col-md-9"">
                    <div class=""card"">
                        <div class=""card-header p-2"">
                            <ul class=""nav nav-pills asd"">
                                <li class=""nav-item""><a class=""nav-link active"" href=""#activity""
                                        data-toggle=""tab"">Haftalık Diet</a></li>
                                <li class=""nav-item""><a class=""nav-link"" href=""#package"" data-toggle=""tab"">Diet
                                        Paketi</a></li>
                            </ul>
                        </div>
                        <div class=""card-body"">
                            <div class=""tab-content"">
                                <div class=""active tab-pane g-0 "" id=""activity"">
                                    <div class=""post "">
                                        <div class=""general-information "">
                  ");
            WriteLiteral("                          <div class=\"card g-0\" style=\"width:100%;border:none; \">\r\n                                                <div class=\"card-body  make-flex-row center\" style=\"border:none;\">\r\n");
#nullable restore
#line 53 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml"
                                                     if (Model.Diet != null)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml"
                                                         if (Model.Diet.DietWekklies != null)
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml"
                                                             foreach (var item in Model.Diet.DietWekklies)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                <div class="" make-flex-column center  bg-light mx-2 p-2 box-shadow""
                                                        style=""min-width: 150px;border-top: 3px solid #ffc107;"">
                                                                    <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                                        ");
#nullable restore
#line 63 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml"
                                                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                                    <a");
            BeginWriteAttribute("href", " href=\"", 3362, "\"", 3391, 2);
            WriteAttributeValue("", 3369, "HaftalıkDiyet/", 3369, 14, true);
#nullable restore
#line 64 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml"
WriteAttributeValue("", 3383, item.Id, 3383, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Git</a>\r\n                                                                </div>\r\n");
#nullable restore
#line 66 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml"
                                                             
                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <div class=\"alert alert-danger\">Diet Paketi Yok</div>\r\n");
#nullable restore
#line 71 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml"
                                                         
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <div class=\"alert alert-danger\">Diet Paketi Yok</div>\r\n");
#nullable restore
#line 76 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_9\app.webui\Views\Admin\CustomerDiet.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""tab-pane"" id=""package"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5de92250fc2bd81f1a2c1034225fc6b64deacc117090", async() => {
                WriteLiteral(@"
                                        <div class=""form-group row mt-2"">
                                            <label for=""inputName"" class=""col-sm-2 col-form-label"">Name</label>
                                            <div class=""col-sm-10"">
                                                <input type=""email"" class=""form-control"" id=""inputName""
                                                    placeholder=""Name"">
                                            </div>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <label for=""inputEmail"" class=""col-sm-2 col-form-label"">Email</label>
                                            <div class=""col-sm-10"">
                                                <input type=""email"" class=""form-control"" id=""inputEmail""
                                                    placeholder=""Email"">
                                            </di");
                WriteLiteral(@"v>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <label for=""inputName2"" class=""col-sm-2 col-form-label"">Name</label>
                                            <div class=""col-sm-10"">
                                                <input type=""text"" class=""form-control"" id=""inputName2""
                                                    placeholder=""Name"">
                                            </div>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <label for=""inputExperience""
                                                class=""col-sm-2 col-form-label"">Experience</label>
                                            <div class=""col-sm-10"">
                                                <textarea class=""form-control"" id=""inputExperience""
                 ");
                WriteLiteral(@"                                   placeholder=""Experience""></textarea>
                                            </div>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <label for=""inputSkills"" class=""col-sm-2 col-form-label"">Skills</label>
                                            <div class=""col-sm-10"">
                                                <input type=""text"" class=""form-control"" id=""inputSkills""
                                                    placeholder=""Skills"">
                                            </div>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <div class=""offset-sm-2 col-sm-10"">
                                                <div class=""checkbox"">
                                                    <label>
                    ");
                WriteLiteral(@"                                    <input type=""checkbox""> I agree to the <a href=""#"">terms and
                                                            conditions</a>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <div class=""offset-sm-2 col-sm-10"">
                                                <button type=""submit"" class=""btn btn-danger"">Submit</button>
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""card-header p-2"">
                            <ul class=""nav nav-pills asd"">
                                <li class=""nav-item""><a class=""nav-link active"" href=""#activity"" data-toggle=""tab"">Beden
                                        Güncel Analiz</a></li>
                            </ul>
                        </div>
                        <div class=""card-body"">
                            <div class=""tab-content"">
                                <div class=""active tab-pane g-0 "" id=""activity"">
                                    <div class=""post "">
                                        <div class=""general-information mt-3"">
                                            <div class=""card g-0"" style=""width:100%; border:none;"">

                                                <div");
            WriteLiteral(@" class=""card-body  make-flex-row center"">
                                                    <div class="" make-flex-column center mx-3 p-2 box-shadow""
                                                        style=""min-width: 125px;"">
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Başlagıç kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">65</p>
                                                        <i class=""fas fa-arrow-down "" style=""color: red;""></i>
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                        ");
            WriteLiteral(@"    Güncel kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">50</p>
                                                    </div>
                                                    <div class="" make-flex-column center mx-3 p-2 box-shadow""
                                                        style=""min-width: 125px;"">
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Başlagıç kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">65</p>
                                                        <i class=""fas fa-arrow-down "" style=""color: red;""></i>
                                                        <h5 class=""card-title text-muted""
                              ");
            WriteLiteral(@"                              style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Güncel kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">50</p>
                                                    </div>
                                                    <div class="" make-flex-column center mx-3 p-2 box-shadow""
                                                        style=""min-width: 125px;"">
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Başlagıç kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">65</p>
                                                        <i class=""fas fa-arrow-down ");
            WriteLiteral(@""" style=""color: red;""></i>
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Güncel kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">50</p>
                                                    </div>
                                                    <div class="" make-flex-column center mx-3 p-2 box-shadow""
                                                        style=""min-width: 125px;"">
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Başlagıç kilo</h5>
                                             ");
            WriteLiteral(@"           <p class=""card-text "" style=""font-size:20px;"">65</p>
                                                        <i class=""fas fa-arrow-down "" style=""color: red;""></i>
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Güncel kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">50</p>
                                                    </div>

                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                                <div class=""tab-pane"" id=""settings"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5de92250fc2bd81f1a2c1034225fc6b64deacc128870", async() => {
                WriteLiteral(@"
                                        <div class=""form-group row mt-2"">
                                            <label for=""inputName"" class=""col-sm-2 col-form-label"">Name</label>
                                            <div class=""col-sm-10"">
                                                <input type=""email"" class=""form-control"" id=""inputName""
                                                    placeholder=""Name"">
                                            </div>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <label for=""inputEmail"" class=""col-sm-2 col-form-label"">Email</label>
                                            <div class=""col-sm-10"">
                                                <input type=""email"" class=""form-control"" id=""inputEmail""
                                                    placeholder=""Email"">
                                            </di");
                WriteLiteral(@"v>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <label for=""inputName2"" class=""col-sm-2 col-form-label"">Name</label>
                                            <div class=""col-sm-10"">
                                                <input type=""text"" class=""form-control"" id=""inputName2""
                                                    placeholder=""Name"">
                                            </div>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <label for=""inputExperience""
                                                class=""col-sm-2 col-form-label"">Experience</label>
                                            <div class=""col-sm-10"">
                                                <textarea class=""form-control"" id=""inputExperience""
                 ");
                WriteLiteral(@"                                   placeholder=""Experience""></textarea>
                                            </div>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <label for=""inputSkills"" class=""col-sm-2 col-form-label"">Skills</label>
                                            <div class=""col-sm-10"">
                                                <input type=""text"" class=""form-control"" id=""inputSkills""
                                                    placeholder=""Skills"">
                                            </div>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <div class=""offset-sm-2 col-sm-10"">
                                                <div class=""checkbox"">
                                                    <label>
                    ");
                WriteLiteral(@"                                    <input type=""checkbox""> I agree to the <a href=""#"">terms and
                                                            conditions</a>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""form-group row mt-2"">
                                            <div class=""offset-sm-2 col-sm-10"">
                                                <button type=""submit"" class=""btn btn-danger"">Submit</button>
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5de92250fc2bd81f1a2c1034225fc6b64deacc134584", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
