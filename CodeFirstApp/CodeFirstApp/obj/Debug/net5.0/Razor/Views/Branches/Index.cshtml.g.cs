#pragma checksum "C:\Users\taef_\source\repos\CodeFirstApp\CodeFirstApp\Views\Branches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90be4cc502d1255763c58cbc46e7263ca0143757"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branches_Index), @"mvc.1.0.view", @"/Views/Branches/Index.cshtml")]
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
#line 1 "C:\Users\taef_\source\repos\CodeFirstApp\CodeFirstApp\Views\_ViewImports.cshtml"
using CodeFirstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taef_\source\repos\CodeFirstApp\CodeFirstApp\Views\_ViewImports.cshtml"
using CodeFirstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90be4cc502d1255763c58cbc46e7263ca0143757", @"/Views/Branches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a67b1c23b3f15af6920d3c70b52285a28e3f28e", @"/Views/_ViewImports.cshtml")]
    public class Views_Branches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\taef_\source\repos\CodeFirstApp\CodeFirstApp\Views\Branches\Index.cshtml"
   var Branches = (List<BranchModel>)ViewData["Branches"];
    string searchId = (string)ViewBag.Address;
    var greatthanTwo = (List<BranchModel>)ViewData["greatthanTwo"];
    var search = (string)ViewBag.Address;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>This is index Branches !! </h1>\r\n\r\n<h3> Search value : ");
#nullable restore
#line 9 "C:\Users\taef_\source\repos\CodeFirstApp\CodeFirstApp\Views\Branches\Index.cshtml"
               Write(searchId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<table border=\"1\">\r\n    <thead>\r\n        <tr>\r\n            <td>ID</td>\r\n            <td>Address</td>\r\n            <td>Name</td>\r\n            <td>Area</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\taef_\source\repos\CodeFirstApp\CodeFirstApp\Views\Branches\Index.cshtml"
         foreach (var b in Branches)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\taef_\source\repos\CodeFirstApp\CodeFirstApp\Views\Branches\Index.cshtml"
               Write(b.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\taef_\source\repos\CodeFirstApp\CodeFirstApp\Views\Branches\Index.cshtml"
               Write(b.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\taef_\source\repos\CodeFirstApp\CodeFirstApp\Views\Branches\Index.cshtml"
               Write(b.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\taef_\source\repos\CodeFirstApp\CodeFirstApp\Views\Branches\Index.cshtml"
               Write(b.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 30 "C:\Users\taef_\source\repos\CodeFirstApp\CodeFirstApp\Views\Branches\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n\r\n");
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
