#pragma checksum "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a332cda639bd4d43b47f99bc8907607d60049a10"
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
#line 2 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\_ViewImports.cshtml"
using app.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\_ViewImports.cshtml"
using app.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\_ViewImports.cshtml"
using app.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a332cda639bd4d43b47f99bc8907607d60049a10", @"/Views/Admin/Diet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c64f982aa68b539b544c37e671c4f43c6da773", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Diet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("css", async() => {
                WriteLiteral("\r\n<link rel=\"stylesheet\" href=\"\\css\\Diet.css\">\r\n");
            }
            );
            WriteLiteral("<section class=\"customer-view\">\r\n    <div class=\"container-card\">\r\n        <div class=\"card-title\">\r\n            <H2>DiYET GENEL BAKIŞ</H2>\r\n        </div>\r\n        <div class=\"name-card\">\r\n            <div class=\"item1\">\r\n                <p>");
#nullable restore
#line 13 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
              Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 13 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
                               Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"item2\">\r\n                <p>\r\n                    Başlangıç=");
#nullable restore
#line 17 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
                         Write(Model.Diet.DateStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    Bitiş=");
#nullable restore
#line 20 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
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
#line 32 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
             foreach (var item in Model.Diet.DietWekklies)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 954, "\"", 988, 2);
            WriteAttributeValue("", 961, "/Admin/DietWekklys/", 961, 19, true);
#nullable restore
#line 34 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
WriteAttributeValue("", 980, item.Id, 980, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"dwt1\">\r\n                        <p>");
#nullable restore
#line 36 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </a>\r\n");
#nullable restore
#line 39 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"MenüCntr\">\r\n            <h1 class=\"h3\">Yazlıan Menüler</h1>\r\n\r\n            <div class=\"menüChecked\">\r\n                <hr>\r\n");
#nullable restore
#line 46 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
                 foreach (var item in ViewBag.Menü)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-check checkItems\">\r\n                        <label class=\"form-check-label\" for=\"Name\">\r\n                            ");
#nullable restore
#line 50 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n                        <input class=\"form-check-input \" type=\"checkbox\" name=\"menü\"");
            BeginWriteAttribute("value", " value=\"", 1656, "\"", 1674, 1);
#nullable restore
#line 52 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
WriteAttributeValue("", 1664, item.Name, 1664, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"Name)\"\r\n                        ");
#nullable restore
#line 53 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
                    Write(item.Gived?"checked":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                    </div>\r\n");
#nullable restore
#line 55 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"PackageContainer\">\r\n        <div class=\"packageone\">\r\n            <a style=\"width: 80px; height: 50px;\" class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1981, "\"", 2017, 2);
            WriteAttributeValue("", 1988, "/Admin/DietOneMonth/", 1988, 20, true);
#nullable restore
#line 62 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
WriteAttributeValue("", 2008, Model.Id, 2008, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aylık\r\n                Paket</a>\r\n        </div>\r\n\r\n        <div class=\"packagetwo\">\r\n            <a style=\"width: 80px; height: 50px;\" class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 2178, "\"", 2213, 2);
            WriteAttributeValue("", 2185, "/Admin/DietOneWeek/", 2185, 19, true);
#nullable restore
#line 67 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Diet.cshtml"
WriteAttributeValue("", 2204, Model.Id, 2204, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">1. Hafta\r\n                Paket</a>\r\n        </div>\r\n    </div>\r\n\r\n  \r\n</section>\r\n");
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
