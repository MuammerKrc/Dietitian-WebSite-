#pragma checksum "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\RoleAndUser\RoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74955ea28f6e4081a52030e415a345d642c6271c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoleAndUser_RoleList), @"mvc.1.0.view", @"/Views/RoleAndUser/RoleList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74955ea28f6e4081a52030e415a345d642c6271c", @"/Views/RoleAndUser/RoleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c64f982aa68b539b544c37e671c4f43c6da773", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAndUser_RoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/role/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">

        <h1>Role List</h1>
        <hr>
        <a class=""btn btn-primary btn-sm mb-3"" href=""/RoleAnduser/RoleCreate"">Create Role</a>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th style=""width: 100px;"">ID</th>
                    <th >Role name</th>
                    <th style=""width: 100px;""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 18 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\RoleAndUser\RoleList.cshtml"
                 if (Model.Count()> 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\RoleAndUser\RoleList.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 23 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\RoleAndUser\RoleList.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\RoleAndUser\RoleList.cshtml"
                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            \r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 883, "\"", 920, 2);
            WriteAttributeValue("", 890, "/RoleAndUser/roleEdit/", 890, 22, true);
#nullable restore
#line 27 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\RoleAndUser\RoleList.cshtml"
WriteAttributeValue("", 912, item.Id, 912, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm me-1\">Edit</a>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74955ea28f6e4081a52030e415a345d642c6271c7124", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 1145, "\"", 1161, 1);
#nullable restore
#line 29 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\RoleAndUser\RoleList.cshtml"
WriteAttributeValue("", 1153, item.Id, 1153, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <button type=\"submit\"  class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\RoleAndUser\RoleList.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\RoleAndUser\RoleList.cshtml"
                     
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Products</h3>\r\n                    </div>\r\n");
#nullable restore
#line 39 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_5\app.webui\Views\RoleAndUser\RoleList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591