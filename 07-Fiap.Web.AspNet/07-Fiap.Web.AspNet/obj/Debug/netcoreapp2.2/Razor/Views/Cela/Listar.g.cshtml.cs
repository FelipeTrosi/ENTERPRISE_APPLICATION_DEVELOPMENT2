#pragma checksum "D:\2TDSF-Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8ae1a0b352a604a76867995b8314e52fe03e607"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cela_Listar), @"mvc.1.0.view", @"/Views/Cela/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cela/Listar.cshtml", typeof(AspNetCore.Views_Cela_Listar))]
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
#line 1 "D:\2TDSF-Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _07_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "D:\2TDSF-Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _07_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8ae1a0b352a604a76867995b8314e52fe03e607", @"/Views/Cela/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fcefac41c0b128535ff853c05ae7e249b40b834", @"/Views/_ViewImports.cshtml")]
    public class Views_Cela_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Cela>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\2TDSF-Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(63, 146, true);
            WriteLiteral("\r\n<h1>Celas</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Área</th>\r\n        <th>Quantidade Maxima</th>\r\n    </tr>\r\n");
            EndContext();
#line 14 "D:\2TDSF-Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
     foreach(var itens in Model)
    {

#line default
#line hidden
            BeginContext(250, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(281, 10, false);
#line 17 "D:\2TDSF-Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
           Write(itens.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(291, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(315, 10, false);
#line 18 "D:\2TDSF-Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
           Write(itens.Area);

#line default
#line hidden
            EndContext();
            BeginContext(325, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(349, 22, false);
#line 19 "D:\2TDSF-Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
           Write(itens.QuantidadeMaxima);

#line default
#line hidden
            EndContext();
            BeginContext(371, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 21 "D:\2TDSF-Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(400, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Cela>> Html { get; private set; }
    }
}
#pragma warning restore 1591
