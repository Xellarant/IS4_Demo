#pragma checksum "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "581fbc40195b4c5cd61fb952e1635bffe448ff7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#line 5 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"581fbc40195b4c5cd61fb952e1635bffe448ff7f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(91, 29, true);
            WriteLiteral("\r\n\r\n<h2>Claims</h2>\r\n\r\n<dl>\r\n");
            EndContext();
#line 11 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\Home\Index.cshtml"
     foreach (var claim in User.Claims)
    {

#line default
#line hidden
            BeginContext(168, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(181, 10, false);
#line 13 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\Home\Index.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(191, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(211, 11, false);
#line 14 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\Home\Index.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(222, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 15 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(236, 38, true);
            WriteLiteral("</dl>\r\n\r\n<h2>Properties</h2>\r\n\r\n<dl>\r\n");
            EndContext();
#line 21 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\Home\Index.cshtml"
     foreach (var prop in (await Context.AuthenticateAsync()).Properties.Items)
    {

#line default
#line hidden
            BeginContext(362, 12, true);
            WriteLiteral("        <dt>");
            EndContext();
            BeginContext(375, 8, false);
#line 23 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\Home\Index.cshtml"
       Write(prop.Key);

#line default
#line hidden
            EndContext();
            BeginContext(383, 19, true);
            WriteLiteral("</dt>\r\n        <dd>");
            EndContext();
            BeginContext(403, 10, false);
#line 24 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\Home\Index.cshtml"
       Write(prop.Value);

#line default
#line hidden
            EndContext();
            BeginContext(413, 7, true);
            WriteLiteral("</dd>\r\n");
            EndContext();
#line 25 "C:\Users\rhunt\source\repos\IdentityServer4Demo\WebApplication1\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(427, 5, true);
            WriteLiteral("</dl>");
            EndContext();
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
