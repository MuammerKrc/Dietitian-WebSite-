#pragma checksum "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6839f57804003ffa9f5ff6e78e176c1eb10d73aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Diet), @"mvc.1.0.view", @"/Views/Admin/Diet.cshtml")]
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
#line 2 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\_ViewImports.cshtml"
using app.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\_ViewImports.cshtml"
using app.entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6839f57804003ffa9f5ff6e78e176c1eb10d73aa", @"/Views/Admin/Diet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd55125ad3ddd8f7603658fa261010ee6afc019", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Diet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Diet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("css", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6839f57804003ffa9f5ff6e78e176c1eb10d73aa4011", async() => {
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
            WriteLiteral("<section class=\"customer-view\">\r\n\r\n    <div class=\"container-card\">\r\n        <div class=\"card-title\">\r\n\r\n            <H2>DiYET GENEL BAKIŞ</H2>\r\n        </div>\r\n        <div class=\"name-card\">\r\n            <div class=\"item1\">\r\n                <p>");
#nullable restore
#line 15 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
                               Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"item2\">\r\n                <p>\r\n                    Başlangıç=");
#nullable restore
#line 19 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
                         Write(Model.Diet.DateStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    Bitiş=");
#nullable restore
#line 22 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
                     Write(Model.Diet.DateEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
        </div>
        <div class=""diet"">
            <div class=""diet-date"">
                <p>15-11-1994</p>
            </div>
        </div>
        <h2 class=""DietTitle"">Haftalık Diyet</h2>

        <div class=""DietWekkly"">
");
#nullable restore
#line 34 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
             foreach (var item in Model.Diet.DietWekklies)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 959, "\"", 993, 2);
            WriteAttributeValue("", 966, "/Admin/DietWekklys/", 966, 19, true);
#nullable restore
#line 36 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
WriteAttributeValue("", 985, item.Id, 985, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"dwt1\">\r\n                        <p>");
#nullable restore
#line 38 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 41 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"MenüCntr\">\r\n            <h1 class=\"h3\">Yazlıan Menüler</h1>\r\n\r\n            <div class=\"menüChecked\">\r\n                <hr>\r\n");
#nullable restore
#line 48 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
                 foreach (var item in ViewBag.Menü)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-check checkItems\">\r\n                        <label class=\"form-check-label\" for=\"Name\">\r\n                            ");
#nullable restore
#line 52 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n                        <input class=\"form-check-input \" type=\"checkbox\" name=\"menü\"");
            BeginWriteAttribute("value", " value=\"", 1661, "\"", 1679, 1);
#nullable restore
#line 54 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
WriteAttributeValue("", 1669, item.Name, 1669, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Name)\"\r\n                        ");
#nullable restore
#line 55 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
                    Write(item.Gived?"checked":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 57 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"PackageContainer\">\r\n        <div class=\"packageone\">\r\n            <a style=\"width: 80px; height: 50px;\" class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1986, "\"", 2022, 2);
            WriteAttributeValue("", 1993, "/Admin/DietOneMonth/", 1993, 20, true);
#nullable restore
#line 64 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
WriteAttributeValue("", 2013, Model.Id, 2013, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aylık Paket</a>\r\n        </div>\r\n\r\n        <div class=\"packagetwo\">\r\n            <a style=\"width: 80px; height: 50px;\" class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2166, "\"", 2201, 2);
            WriteAttributeValue("", 2173, "/Admin/DietOneWeek/", 2173, 19, true);
#nullable restore
#line 68 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_3\app.webui\Views\Admin\Diet.cshtml"
WriteAttributeValue("", 2192, Model.Id, 2192, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">1. Hafta Paket</a>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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