#pragma checksum "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca\app.webui\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "312eb7674a8f37497960b633526f89c83c99472f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca\app.webui\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca\app.webui\Views\_ViewImports.cshtml"
using app.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca\app.webui\Views\_ViewImports.cshtml"
using app.entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312eb7674a8f37497960b633526f89c83c99472f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcd55125ad3ddd8f7603658fa261010ee6afc019", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/homeIndex.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("display-style", new global::Microsoft.AspNetCore.Html.HtmlString("none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-one"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "312eb7674a8f37497960b633526f89c83c99472f5510", async() => {
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
            WriteLiteral(@"<section class=""start-container"">
    <div class=""start-img""></div>
    <div class=""start-content"">
        <article class=""start-explain"">
            <p>
                Diyetisyen Sinem Karaca ile Sürdürülebilir Beslenme Danışmanlığı Dünya’nın her yerine sadece 1 Tık
                uzaktayız. <br><span> Sen neredeysen, biz oradayız.</span>
            </p>
        </article>
        <div class=""btn-box"">
            <div class=""btn-absolute""></div>
            <div class=""btn-content"">
                <p>Motivasyonlu <br> Online Diyet <br> <span style=""font-size: 3rem;"">Dyt Sinem Karaca</span></p>
                <div class=""btn-1"">
                    <p>Online Diyet</p>
                    </button>
                </div>
            </div>
        </div>
</section>

<section class=""container-hesaplama"">
    <div class=""hesaplama-header"">
        <h3>Gelin Vücudunuzu Değerlendirelim</h3>
    </div>
    <div class=""hesaplama-box"">
        <div class=""right-box"">
            <di");
            WriteLiteral(@"v class=""img-items"">
                <div id=""asd"" class=""img-content"">
                    <div class=""img-item"">
                    </div>
                    <p class=""pointer"">Bazal Metobolizma</p>
                </div>
                <div class=""img-content"">
                    <div class=""img-item"">
                    </div>
                    <p>Beden Kitle İndeksi</p>
                </div>
                <div class=""img-content"">
                    <div class=""img-item"">
                    </div>
                    <p>Günlük Enerji Miktarı</p>
                </div>
                <div class=""img-content"">
                    <div class=""img-item"">
                    </div>
                    <p>Bel Cevresi</p>
                </div>
                <div class=""img-content"">
                    <div class=""img-item"">
                    </div>
                    <p>Yağ Yakma Nabzı</p>
                </div>
            </div>
        </div>

        <div id=");
            WriteLiteral(@"""dsa"" class=""left-box"">
            <div class=""left-box-content"">
                <span class=""header-text""><strong>Graphics Design</strong></span>
                <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Vel, est?</p>
                <div class=""selected-img"">
                </div>
            </div>
            <div class=""table"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "312eb7674a8f37497960b633526f89c83c99472f9300", async() => {
                WriteLiteral("\r\n                    <table class=\"evulation-information\">\r\n\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "312eb7674a8f37497960b633526f89c83c99472f9649", async() => {
                    WriteLiteral(@"
                            <tr>
                                <td><label for=""age"">Yaşınız:</label></td>
                                <td><input type=""number"" name=""age""></td>
                            </tr>
                            <tr>
                                <td><label for=""length"">Boyunuz:</label></td>
                                <td><input type=""number"" name=""length""></td>
                            </tr>
                            <tr>
                                <td><label for=""weight"">Beden Ağırlığınız(kg):</label></td>
                                <td><input type=""number"" name=""weight""></td>
                            </tr>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </table>
                    <div class=""checkbox-group"">
                        <p class=""checkbox-title"">Cinsiyetiniz:</p>
                        <div class=""checkbox-item"">
                            <label for=""gender"">Kadın
                                <input type=""radio"" name=""gender""");
                BeginWriteAttribute("id", " id=\"", 3697, "\"", 3702, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </label>\r\n                            <label for=\"gender\">Erkek\r\n                                <input type=\"radio\" name=\"gender\"");
                BeginWriteAttribute("id", " id=\"", 3864, "\"", 3869, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            </label>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
</section>
<section class=""services"">
    <h3>HİZMETLERİMİZ</h3>
    <div class=""box-container"">
        <iframe src=""https://www.youtube.com/embed/tgbNymZ7vqY?autoplay=1&mute=1"">
        </iframe>
        <div class=""box-area"">
            <div class=""single-box"">
                <div class=""img-area""></div>
                <div class=""img-text"">
                    <span class=""header-text""><strong>Graphics Design</strong></span>
                    <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Consequatur animi nihil eligendi soluta
                        impedit quibusdam, tempore rem exercitationem ex maiores saepe deleniti natus dolorem maxime,
                        ipsam laudantium. Maxime, deleniti
                        molestiae.
                    </p>
                </div>
            </div>
            <div class=""single-box"">
                <div class=""img-area""></div>
                <div class=""img-text"">
        ");
            WriteLiteral(@"            <span class=""header-text""><strong>Graphics Design</strong></span>
                    <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Consequatur animi nihil eligendi soluta
                        impedit quibusdam, tempore rem exercitationem ex maiores saepe deleniti natus dolorem maxime,
                        ipsam laudantium. Maxime, deleniti
                        molestiae.
                    </p>
                </div>
            </div>

        </div>
    </div>
</section>
<section class=""blog-container"">
    <h2>BLOG</h2>
    <div class=""blog-background"">
    </div>
    <div class=""blog-box-area-row"">

        <div class=""blog-single-box"">
            <div class=""blog-img-area"">
            </div>
            <div class=""blog-img-border""></div>
            <div class=""blog-img-explain"">
                <div class=""blog-img-explain-content"">
                    <p>asddasasd</p>
                </div>
            </div>
        </div>

        ");
            WriteLiteral(@"<div class=""blog-double-box"">
            <div class=""blog-img-area"">
            </div>
            <div class=""blog-img-border""></div>
            <div class=""blog-img-explain"">
                <div class=""blog-img-explain-content"">
                    <p>asddasasd asdasdasda</p>
                </div>
            </div>
        </div>
    </div>

    <div class=""blog-box-area-row"">

        <div class=""blog-double-box"">
            <div class=""blog-img-area"">
            </div>
            <div class=""blog-img-border""></div>
            <div class=""blog-img-explain"">
                <div class=""blog-img-explain-content"">
                    <p>asddasasd asdasdasda</p>
                </div>
            </div>
        </div>
        <div class=""blog-single-box"">
            <div class=""blog-img-area"">
            </div>
            <div class=""blog-img-border""></div>
            <div class=""blog-img-explain"">
                <div class=""blog-img-explain-content"">
              ");
            WriteLiteral(@"      <p>asddasasd</p>
                </div>
            </div>
        </div>
    </div>
    <div class=""blog-box-area-row"">
        <div class=""blog-single-box"">
            <div class=""blog-img-area"">
            </div>
            <div class=""blog-img-border""></div>
            <div class=""blog-img-explain"">
                <div class=""blog-img-explain-content"">
                    <p>asddasasd</p>
                </div>
            </div>
        </div>
        <div class=""blog-double-box"">
            <div class=""blog-img-area"">
            </div>
            <div class=""blog-img-border""></div>
            <div class=""blog-img-explain"">
                <div class=""blog-img-explain-content"">
                    <p>asddasasd asdasdasda</p>
                </div>
            </div>
        </div>
    </div>
</section>
<section class=""about-container"">
    <div class=""about"">

        <div class=""about-article"">
            <span class=""header-text""><strong>Sinem Karaca</str");
            WriteLiteral(@"ong></span>
            </hr>
            <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Consequatur animi nihil eligendi soluta impedit
                quibusdam, tempore rem exercitationem ex maiores saepe deleniti natus dolorem maxime, ipsam laudantium.
                Maxime, deleniti molestiae.
            </p>
        </div>
        <div class=""about-imgbox"">
            <div class=""about-imgbox-img"">
            </div>
        </div>
    </div>
</section>");
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
