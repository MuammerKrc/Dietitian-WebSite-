#pragma checksum "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e16d79d11edf9e114b8de420e5d68da09896bbde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diet_Index), @"mvc.1.0.view", @"/Views/Diet/Index.cshtml")]
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
#line 2 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\_ViewImports.cshtml"
using app.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\_ViewImports.cshtml"
using app.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\_ViewImports.cshtml"
using app.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e16d79d11edf9e114b8de420e5d68da09896bbde", @"/Views/Diet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c64f982aa68b539b544c37e671c4f43c6da773", @"/Views/_ViewImports.cshtml")]
    public class Views_Diet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Diet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Diet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AnamnezForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/womena.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("css", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e16d79d11edf9e114b8de420e5d68da09896bbde6190", async() => {
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
            WriteLiteral("<section class=\"customer-view\">\r\n    <div class=\"container-card\">\r\n        <div class=\"card-title\">\r\n\r\n            <H2>DiYET GENEL BAKIŞ</H2>\r\n        </div>\r\n        <div class=\"name-card\">\r\n            <div class=\"item1\">\r\n                <p>");
#nullable restore
#line 14 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
                               Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"item2\">\r\n                <p>\r\n                    Başlangıç=");
#nullable restore
#line 18 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
                         Write(Model.Diet.DateStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    Bitiş=");
#nullable restore
#line 21 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
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
#line 33 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
             foreach (var item in Model.Diet.DietWekklies)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 957, "\"", 990, 2);
            WriteAttributeValue("", 964, "/Diet/DietWekklys/", 964, 18, true);
#nullable restore
#line 35 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
WriteAttributeValue("", 982, item.Id, 982, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"dwt1\">\r\n                        <p>");
#nullable restore
#line 37 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 40 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"MenüCntr\">\r\n            <h1 class=\"h3\">Yazlıan Menüler</h1>\r\n            <hr>\r\n");
#nullable restore
#line 45 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
             foreach (var item in (List<Recipe>)ViewBag.Recipe)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-check\">\r\n                    <input class=\"form-check-input \" type=\"checkbox\" name=\"selectedRecipe\"");
            BeginWriteAttribute("value", " value=\"", 1469, "\"", 1485, 1);
#nullable restore
#line 48 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
WriteAttributeValue("", 1477, item.Id, 1477, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", "\r\n                    id=\"", 1486, "\"", 1522, 1);
#nullable restore
#line 49 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
WriteAttributeValue("", 1512, item.Id, 1512, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 49 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
                                Write(Model.Diet.CombineDietRecipes.Any(i=>i.RecipeId==item.Id)?"checked":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                    <label class=\"form-check-label\" for=\"item.id\">\r\n                        ");
#nullable restore
#line 51 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </label>\r\n                </div>\r\n");
#nullable restore
#line 54 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"PackageContainer\">\r\n            <div class=\"packageone\">\r\n                <a style=\"width: 80px; height: 50px;\" class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1944, "\"", 1980, 2);
            WriteAttributeValue("", 1951, "/Admin/DietOneMonth/", 1951, 20, true);
#nullable restore
#line 58 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
WriteAttributeValue("", 1971, Model.Id, 1971, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aylık\r\n                    Paket</a>\r\n            </div>\r\n\r\n            <div class=\"packagetwo\">\r\n                <a style=\"width: 80px; height: 50px;\" class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2157, "\"", 2192, 2);
            WriteAttributeValue("", 2164, "/Admin/DietOneWeek/", 2164, 19, true);
#nullable restore
#line 63 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
WriteAttributeValue("", 2183, Model.Id, 2183, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">1.
                    Hafta Paket</a>
            </div>
        </div>
    </div>
    <div class=""card-2"">
        <div class=""Anamnez"">
            <div class=""card text-center"">
            <div class=""card-header"">
                <ul class=""nav nav-tabs card-header-tabs"">
                    <li class=""nav-item"">
                        <a class=""nav-link text-danger active"">Asla Yiyemediklerim</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link text-warning "" >Sağlığıma Dokunanlar</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link disabled text-primary"">Vazgeçemediklerim</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link disabled text-primary"">Ananmnez Formu Güncelle</a>
                    </li>
                </ul>
            </div>
            <div class=""card-body "">
                ");
            WriteLiteral("<h5 class=\"card-title\">Special title treatment</h5>\r\n                <p class=\"card-text\">With supporting text below as a natural lead-in to additional content.</p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e16d79d11edf9e114b8de420e5d68da09896bbde15153", async() => {
                WriteLiteral("Go somewhere");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\Diet\Index.cshtml"
                                                                    WriteLiteral(Model.Diet.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"Img-woman\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e16d79d11edf9e114b8de420e5d68da09896bbde17723", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
