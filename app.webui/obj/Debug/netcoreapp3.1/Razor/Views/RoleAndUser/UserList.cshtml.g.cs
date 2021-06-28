#pragma checksum "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8462bd477f75201b37da5af9a77de1d1eba2c0e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoleAndUser_UserList), @"mvc.1.0.view", @"/Views/RoleAndUser/UserList.cshtml")]
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
#line 2 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\_ViewImports.cshtml"
using app.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\_ViewImports.cshtml"
using app.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\_ViewImports.cshtml"
using app.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8462bd477f75201b37da5af9a77de1d1eba2c0e0", @"/Views/RoleAndUser/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7c64f982aa68b539b544c37e671c4f43c6da773", @"/Views/_ViewImports.cshtml")]
    public class Views_RoleAndUser_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/user/delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script src=""//cdn.datatables.net/1.10.24/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.24/js/dataTables.bootstrap5.min.js""></script>
<script>
    $(document).ready(function () {
        $('#myTable').DataTable();
    });
</script>

");
            }
            );
            WriteLiteral(@"
<section style=""margin-top: 20px;"">
    
    <div class=""container-fluid"" style=""padding: 50px;"">
       
                <div class=""row  justify-content-around asdasda mt-2 p-5"">
                    <div class=""col-md-12"">
                        <h1>Role List</h1>
                        <hr>
                        <a class=""btn btn-primary btn-sm mb-3"" href=""/admin/User/create"">Create User</a>
                        <div class=""table-responsive-md"">
                            <table id=""myTable"" class=""table table-bordered "">
                                <thead>
                                    <tr>
                                        <th>First Name</th>
                                        <th>Last Name</th>
                                        <th>USer Name</th>
                                        <th>Email</th>
                                        <th>Email Confirmed</th>
                                        <th style=""width: 160ox;""></th>
             ");
            WriteLiteral("                       </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
                                     if (Model.Count() > 0)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
                                         foreach (var item in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr");
            BeginWriteAttribute("class", " class=\"", 1728, "\"", 1774, 1);
#nullable restore
#line 41 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
WriteAttributeValue("", 1736, item.EmailConfirmed?"":"bg-warning", 1736, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <td>");
#nullable restore
#line 42 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
                                               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 43 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
                                               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 44 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
                                               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 45 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
                                               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 46 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
                                               Write(item.EmailConfirmed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    <a");
            BeginWriteAttribute("href", " href=\"", 2255, "\"", 2292, 2);
            WriteAttributeValue("", 2262, "/RoleAndUSer/useredit/", 2262, 22, true);
#nullable restore
#line 48 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
WriteAttributeValue("", 2284, item.Id, 2284, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                                class=\"btn btn-primary btn-sm me-1\">Edit</a>\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8462bd477f75201b37da5af9a77de1d1eba2c0e09960", async() => {
                WriteLiteral("\r\n                                                        <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 2606, "\"", 2622, 1);
#nullable restore
#line 51 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
WriteAttributeValue("", 2614, item.Id, 2614, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                        <button type=\"submit\" class=\"btn btn-danger btn-sm\">Delete</button>\r\n                                                    ");
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
            WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
                                         
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"alert alert-warning\">\r\n                                            <h3>No User</h3>\r\n                                        </div>\r\n");
#nullable restore
#line 63 "C:\Users\muamm\OneDrive\Masaüstü\SinemKaraca_12\app.webui\Views\RoleAndUser\UserList.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n            </div>\r\n        </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
