#pragma checksum "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\Client\CIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2220077b9408943c30c12e3a0d3a1a9238481b3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_CIndex), @"mvc.1.0.view", @"/Views/Client/CIndex.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\_ViewImports.cshtml"
using CommuneLetters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\_ViewImports.cshtml"
using CommuneLetters.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2220077b9408943c30c12e3a0d3a1a9238481b3f", @"/Views/Client/CIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb390c84d01ea131eb06c4937c05963e40c2482", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_CIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CommuneLetters.Models.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\Client\CIndex.cshtml"
  
    ViewData["Title"] = "CIndex";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List of Clients</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\Client\CIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\Client\CIndex.cshtml"
           Write(Html.DisplayNameFor(model => model.Essay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\Client\CIndex.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 26 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\Client\CIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\Client\CIndex.cshtml"
           Write(Html.DisplayFor(modelItem => item.Essay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\Client\CIndex.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new {  id=item.Name }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 33 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\Client\CIndex.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id=item.Name }, new { @class = "btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 34 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\Client\CIndex.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Name }, new { @class = "btn btn-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Ngina\Desktop\CommuneLetters\CommuneLetters\Views\Client\CIndex.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CommuneLetters.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591