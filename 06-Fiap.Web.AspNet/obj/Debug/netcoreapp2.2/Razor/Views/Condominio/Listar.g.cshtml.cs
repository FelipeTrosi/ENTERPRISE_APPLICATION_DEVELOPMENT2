#pragma checksum "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Condominio\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0598d79a95f77ed33f218e7b85f5af3fcfb9ae91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Condominio_Listar), @"mvc.1.0.view", @"/Views/Condominio/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Condominio/Listar.cshtml", typeof(AspNetCore.Views_Condominio_Listar))]
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
#line 1 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _06_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _06_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0598d79a95f77ed33f218e7b85f5af3fcfb9ae91", @"/Views/Condominio/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd844120a173759076490277497cbda0ead918bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Condominio_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Condominio>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Condominio\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(68, 181, true);
            WriteLiteral("\r\n<h1>Listar</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Nome</th>\r\n        <th>Blocos</th>\r\n        <th>Tipo</th>\r\n        <th>Ativo</th>\r\n    </tr>\r\n");
            EndContext();
#line 16 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Condominio\Listar.cshtml"
     foreach (var itens in Model)
    {

#line default
#line hidden
            BeginContext(291, 23, true);
            WriteLiteral("     <tr>\r\n        <td>");
            EndContext();
            BeginContext(315, 18, false);
#line 19 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Condominio\Listar.cshtml"
       Write(itens.CondominioId);

#line default
#line hidden
            EndContext();
            BeginContext(333, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(353, 10, false);
#line 20 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Condominio\Listar.cshtml"
       Write(itens.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(363, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(383, 12, false);
#line 21 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Condominio\Listar.cshtml"
       Write(itens.Blocos);

#line default
#line hidden
            EndContext();
            BeginContext(395, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(415, 10, false);
#line 22 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Condominio\Listar.cshtml"
       Write(itens.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(425, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(445, 11, false);
#line 23 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Condominio\Listar.cshtml"
       Write(itens.Ativo);

#line default
#line hidden
            EndContext();
            BeginContext(456, 19, true);
            WriteLiteral("</td>\r\n     </tr>\r\n");
            EndContext();
#line 25 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\06-Fiap.Web.AspNet\06-Fiap.Web.AspNet\Views\Condominio\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(482, 10, true);
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Condominio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
