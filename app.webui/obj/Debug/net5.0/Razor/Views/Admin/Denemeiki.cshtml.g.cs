#pragma checksum "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_11\app.webui\Views\Admin\Denemeiki.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "374bb36ed5d814f14f06bb6940051a146b014efa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Denemeiki), @"mvc.1.0.view", @"/Views/Admin/Denemeiki.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"374bb36ed5d814f14f06bb6940051a146b014efa", @"/Views/Admin/Denemeiki.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c64f982aa68b539b544c37e671c4f43c6da773", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Denemeiki : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-user-img img-fluid "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/avatar/avatar2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User profile picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("css", async() => {
                WriteLiteral(@"
<style>
    .makeFlex {
        display: flex;
        justify-content: center;
    }

    .list-group-item {
        display: flex;
        flex-direction: row;
        justify-content: space-between;
        align-items: center;
    }

    .profile-user-img {
        border: 1px solid gray;
        border-radius: 50%;
    }

    .make-flex-row {
        display: flex;
        flex-direction: row;
        flex-wrap: wrap;
    }

    .make-flex-column {
        display: flex;
        flex-direction: column;
    }

    .space-around {
        justify-content: space-around;
        align-items: flex-start;
    }

    .space-beetwen {
        justify-content: space-between;
        align-items: flex-start;
    }

    .center {
        justify-content: center;
        align-items: center;
    }

    .box-shadow {
        box-shadow: 1px 5px 5px 1px #A6A6A6;
    }

    .asd li .active {
        color: white !important;
    }

    .general-information {
       ");
                WriteLiteral(" position: relative;\r\n\r\n    }\r\n\r\n    .general-information .time {\r\n        position: absolute;\r\n        top: 0px;\r\n        right: 0px;\r\n        color: black;\r\n    }\r\n</style>\r\n");
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
                        <h1>Diyet Genel Görünüm</h1>
                    </div>
                    <div class=""col-sm-6"">
                        <ol class=""breadcrumb float-sm-right"">
                            <li class=""breadcrumb-item""><a href=""#"">AnaSayfa</a></li>
                            <li class=""breadcrumb-item active"">Diyet</li>
                        </ol>
                    </div>
                </div>
            </div><!-- /.container-fluid -->
        </section>

        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-3"">

                    <div class=""card card-primary card-outline"">
                        <div class=""card-body box-p");
            WriteLiteral("rofile\">\r\n                            <div class=\"text-center\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "374bb36ed5d814f14f06bb6940051a146b014efa7956", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>

                            <h3 class=""profile-username text-center"">Sinem Karaca</h3>

                            <div class=""row make-flex-row space-around my-3"">
                                <a href=""#"" class=""btn btn-secondary btn-block col-5 col-sm-3 col-md-5""><b>Diet</b></a>
                                <a href=""#""
                                    class=""btn btn-secondary btn-block col-5 col-sm-3 col-md-5""><b>Pilates</b></a>
                            </div>

                            <div class=""card  g-0"" style=""width:100%;"">
                                <h5 class=""card-header text-center "">Kalan Paketler</h5>
                                <div class=""card-body  make-flex-row space-beetwen"">
                                    <div class="" make-flex-column center p-2 box-shadow"" style=""min-width: 150px;"">
                                        <h5 class=""card-title text-muted""
                                            style=""bor");
            WriteLiteral(@"der-bottom: 2px solid black; padding-bottom:12px;"">Kalan Diet
                                            Adeti</h5>
                                        <p class=""card-text "" style=""font-size:20px;"">5</p>
                                        <a href=""#"" class=""btn btn-primary"">Paket Satın Al</a>
                                    </div>
                                    <div class=""make-flex-column center p-2 box-shadow"" style=""min-width: 150px;"">
                                        <h5 class=""card-title  text-muted""
                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">Kalan Pilates
                                            Adeti</h5>
                                        <p class=""card-text"" style=""font-size:20px;"">3</p>
                                        <a href=""#"" class=""btn btn-primary"">Paket Satın Al</a>
                                    </div>
                                </div>
                            </di");
            WriteLiteral(@"v>


                        </div>
                        <!-- /.card-body -->
                    </div>

                </div>
                <div class=""col-md-9"">
                    <div class=""card"">
                        <div class=""card-header p-2"">
                            <ul class=""nav nav-pills asd"">
                                <li class=""nav-item""><a class=""nav-link active"" href=""#activity"" data-toggle=""tab"">Genel
                                        Bilgilendirme</a></li>

                                <li class=""nav-item""><a class=""nav-link"" href=""#settings"" data-toggle=""tab"">Mesaj
                                        Gönder</a>
                                </li>
                            </ul>
                        </div>
                        <div class=""card-body"">
                            <div class=""tab-content"">
                                <div class=""active tab-pane g-0 "" id=""activity"">
                                    <div c");
            WriteLiteral(@"lass=""post "">
                                          <div class=""general-information mt-3"">
                                            <div class=""card g-0"" style=""width:100%;"">
                                                <h5 class=""card-header text-center text-danger"" >Haftalık Diyet</h5>
                                                <div class=""card-body bg-dark make-flex-row center"">
                                                    <div class="" make-flex-column center  bg-light mx-2 p-2 box-shadow""
                                                        style=""min-width: 150px;"">
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            1. Hafta</h5>
                                                        <a href=""#"" class=""btn btn-primary"">Git</a>
                        ");
            WriteLiteral(@"                            </div>
                                                    <div class=""make-flex-column center bg-light mx-2 p-2 box-shadow""
                                                        style=""min-width: 150px;"">
                                                        <h5 class=""card-title  text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            2. Hafta</h5>
                                                        <a href=""#"" class=""btn btn-primary"">Git</a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""general-information mt-3"">
                                            <div class=""card g-0"" style=""width:100%;"">
          ");
            WriteLiteral(@"                                      <h5 class=""card-header text-center text-danger "">Beden Güncel Analiz</h5>
                                                <div class=""card-body  make-flex-row center"">
                                                    <div class="" make-flex-column center mx-3 p-2 box-shadow""
                                                        style=""min-width: 125px;"">
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Başlagıç kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">65</p>
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
   ");
            WriteLiteral(@"                                                         Güncel kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">50</p>
                                                    </div>
                                                    <div class="" make-flex-column center  mx-3  p-2 box-shadow""
                                                        style=""min-width: 125px;"">
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Başlagıç kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">65</p>
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px s");
            WriteLiteral(@"olid black; padding-bottom:12px;"">
                                                            Güncel kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">50</p>
                                                    </div>
                                                    <div class="" make-flex-column center  mx-3  p-2 box-shadow""
                                                        style=""min-width: 125px;"">
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Başlagıç kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">65</p>
                                                        <h5 class=""card-title text-muted""
                                                ");
            WriteLiteral(@"            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Güncel kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">50</p>
                                                    </div>
                                                    <div class="" make-flex-column center  mx-3  p-2 box-shadow""
                                                        style=""min-width: 125px;"">
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Başlagıç kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">65</p>
                                                        <h5 class=""card-title text-muted""
         ");
            WriteLiteral(@"                                                   style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Güncel kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">50</p>
                                                    </div>
                                                    <div class="" make-flex-column center  mx-3  p-2 box-shadow""
                                                        style=""min-width: 125px;"">
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Başlagıç kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">65</p>
                                                        <h5 c");
            WriteLiteral(@"lass=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Güncel kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">50</p>
                                                    </div>
                                                    <div class="" make-flex-column center  mx-3  p-2 box-shadow""
                                                        style=""min-width: 125px;"">
                                                        <h5 class=""card-title text-muted""
                                                            style=""border-bottom: 2px solid black; padding-bottom:12px;"">
                                                            Başlagıç kilo</h5>
                                                        <p class=""card-text "" style=""font-size:20px;"">65</p>
                      ");
            WriteLiteral(@"                                  <h5 class=""card-title text-muted""
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "374bb36ed5d814f14f06bb6940051a146b014efa21808", async() => {
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>");
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
