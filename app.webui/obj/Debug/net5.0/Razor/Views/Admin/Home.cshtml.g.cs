#pragma checksum "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce275c09d009422627fb75d6c30f3408eb76fe21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Home), @"mvc.1.0.view", @"/Views/Admin/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce275c09d009422627fb75d6c30f3408eb76fe21", @"/Views/Admin/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c64f982aa68b539b544c37e671c4f43c6da773", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("css", async() => {
                WriteLiteral(@"
<style>
    .addHeight {
        height: 40px;

    }

    .changeColor {
        color: var(--primary-color);
    }

    section {
        position: relative;
        width: auto;
        min-height: 1080px;
    }

    .makeCenterContent {
        display: flex;
        align-items: center;
        justify-content: center;
    }

    .deneme {
        position: absolute;
        width: 100%;
        height: 100%;
        background: black;
        background-image: url(""/img/aa2.jpg"");
        background-position: center;
        background-repeat: no-repeat;
        background-size: cover;
        z-index: -1000;
    }

    .asdasd {
        background-color: rgba(0, 0, 0, 0.2);
    }

    a {
        color: #fff;
        font-weight: normal;
        text-decoration: none;
        transition: all 0.3s ease;
    }

    a:hover,
    a:active,
    a:focus {
        color: var(--primary-color);
        outline: none;
        text-decoration: none;
    }

  ");
                WriteLiteral(@"  .asdasda {
        background-color: rgba(0, 0, 0, 0.5);
    }


    /* BG OVERLAY */

    .bg-overlay {
        background: var(--dark-color);
        position: absolute;
        top: 0;
        right: 0;
        bottom: 0;
        left: 0;
        width: 100%;
        height: 100%;
        opacity: 0.10;
    }

    #r2,
    #r3 {
        display: none;
    }
</style>
");
            }
            );
            WriteLiteral("\r\n\r\n<section style=\"margin-top: 20px;\">\r\n    <div class=\"deneme\">\r\n    </div>\r\n    <div class=\"container-fluid\" style=\"padding: 50px;\">\r\n");
#nullable restore
#line 87 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
         if (ViewBag.Package != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"alert alert-info\" role=\"alert\">\r\n                    ");
#nullable restore
#line 91 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
               Write(ViewBag.Package);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 94 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row justify-content-sm-center justify-content-md-around\">\r\n            <div class=\"col-12 col-md-4 col-lg-3 asdasd h-100\">\r\n                ");
#nullable restore
#line 97 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
           Write(await Html.PartialAsync("_AdminNavbar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""col-12 col-md-6 col-lg-5  "" style=""color: #fff;"">
                <div class=""row justify-content-sm-between justify-content-around asdasda mt-2"" style=""padding: 10px;"">
                    <div class=""col-4"">
                        <a id=""item1"" href=""#"" class="" addHeight bg-primary makeCenterContent"">Duyurular</a>
                    </div>
                    <div class=""col-4"">
                        <a id=""item2"" href=""#"" class="" addHeight bg-primary makeCenterContent"">Bildirimler</a>
                    </div>
                    <div class=""col-4"">
                        <a id=""item3"" href=""#"" class="" addHeight bg-primary makeCenterContent"">Mesaj Gönder</a>
                    </div>
                </div>
                <div class=""row asdasda mt-3"">
                    <div id=""r1"" class=""col-12 justify-content-around p-5"">
                        <div class=""col-12 text-center changeColor"">
                            <h1>Duyurular</h1");
            WriteLiteral(@">
                            <hr style=""height: 3px;"">
                        </div>
                        <div class=""aler alert-dark   mt-4"">
                            <h2>Diyetlerle ilgili Bilgilendirme</h2>
                            <hr>
                            <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Voluptatibus deleniti impedit
                                accusamus aut, nobis in blanditiis voluptatem, omnis cupiditate ducimus sint dolor eius
                                magni libero et ab tenetur, culpa officia!</p>
                        </div>
                        <div class=""aler alert-success  mt-4"">
                            <h2>Platesler hakkında genel bilgilendirme</h2>
                            <hr>
                            <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Voluptatibus deleniti impedit
                                accusamus aut, nobis in blanditiis voluptatem, omnis cupiditate ducimus sint dolor eius");
            WriteLiteral(@"
                                magni libero et ab tenetur, culpa officia!</p>
                        </div>
                    </div>
                    <div id=""r2"" class=""col-12  justify-content-around  p-5"">
                        <div class=""col-12 text-center changeColor"">
                            <h1>Bildirimler</h1>
                            <hr style=""height: 3px;"">
                        </div>
                        <div class=""col-12 table-responsive"">
                            <table class=""table table-hover  table-dark"">
                                <thead>
                                    <tr>
                                        <th>İstek</th>
                                        <th>Adı</th>
                                        <th>Tarih</th>
                                        <th>Git</th>
                                        <th>Sil</th>
                                    </tr>
                                </thead>
                 ");
            WriteLiteral("               <tbody>\r\n");
#nullable restore
#line 149 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
                                     if (ViewBag.Request != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
                                         foreach (var item in (List<PackageRequest>)ViewBag.Request)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 154 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
                                               Write(item.PackageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 155 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
                                               Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 156 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
                                               Write(item.RequestTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                <td><a");
            BeginWriteAttribute("href", " href=\"", 5690, "\"", 5725, 2);
            WriteAttributeValue("", 5697, "/Diet/Index/", 5697, 12, true);
#nullable restore
#line 158 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
WriteAttributeValue("", 5709, item.CustomerId, 5709, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Git</a></td>\r\n                                                <td><a");
            BeginWriteAttribute("href", " href=\"", 5819, "\"", 5854, 2);
            WriteAttributeValue("", 5826, "/Diet/DeleteRequest/", 5826, 20, true);
#nullable restore
#line 159 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
WriteAttributeValue("", 5846, item.Id, 5846, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 161 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_8\app.webui\Views\Admin\Home.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div id=""r3"" class=""col-12  justify-content-around  p-5"">
                        <div class=""col-12 text-center changeColor"">
                            <h1>Duyurular</h1>
                            <hr style=""height: 3px;"">
                        </div>
                        <div class=""aler alert-dark  mt-4"">
                            <h2>Diyetlerle ilgili Bilgilendirme</h2>
                            <hr>
                            <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Voluptatibus deleniti impedit
                                accusamus aut, nobis in blanditiis voluptatem, omnis cupiditate ducimus sint dolor eius
                                magni libero et ab tenetur, culpa officia!</p>
                        </div>
                        <div class=""aler alert-success mt-4"">
                 ");
            WriteLiteral(@"           <h2>Platesler hakkında genel bilgilendirme</h2>
                            <hr>
                            <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Voluptatibus deleniti impedit
                                accusamus aut, nobis in blanditiis voluptatem, omnis cupiditate ducimus sint dolor eius
                                magni libero et ab tenetur, culpa officia!</p>
                        </div>
                    </div>

                </div>


            </div>
        </div>
</section>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>

    var item1 = document.getElementById(""item1"");
    var item2 = document.getElementById(""item2"");
    var item3 = document.getElementById(""item3"");
    var r1 = document.getElementById(""r1"");
    var r2 = document.getElementById(""r2"");
    var r3 = document.getElementById(""r3"");

    item1.addEventListener(""click"", selectedItem1);
    item2.addEventListener(""click"", selectedItem2);
    item3.addEventListener(""click"", selectedItem3);

    function selectedItem1(e) {
        var temp = false;
        console.log(""asfaa"")

        for (var x of item1.classList) {
            if (x == ""active"") {
                temp = true;
            }
        }
        if (temp == false) {
            item2.style.background = ""none"";
            item3.style.background = ""none"";
            r2.style.display = ""none"";
            r3.style.display = ""none"";


            r1.style.display = ""inline"";
            item1.style.background = ""#fff"";
        }
    }
    function selectedIt");
                WriteLiteral(@"em2(e) {
        var temp = false;
        console.log(""asd"");

        for (var x of item2.classList) {
            console.log(""asd"");
            if (x == ""active"") {
                temp = true;
            }
        }
        console.log(temp);
        if (temp == false) {
            item1.style.background = ""none"";
            item3.style.background = ""none"";
            r1.style.display = ""none"";
            r3.style.display = ""none"";

            r2.style.display = ""inline"";
            item2.style.background = ""#fff"";
        }
    }


    function selectedItem3(e) {
        var temp = false;

        for (var x of item2.classList) {
            if (x == ""active"") {
                temp = true;
            }
        }
        if (temp == false) {
            item1.style.background = ""none"";
            item2.style.background = ""none"";
            r2.style.display = ""none"";
            r1.style.display = ""none"";

            r3.style.display = ""inline"";
         ");
                WriteLiteral("   item3.style.background = \"#fff\";\r\n        }\r\n    }\r\n</script>\r\n");
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
