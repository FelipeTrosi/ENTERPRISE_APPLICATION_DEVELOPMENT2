#pragma checksum "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5586204c21b809cfc94cea354e2cb7f9c5f822d5"
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
#line 1 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _07_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _07_Fiap.Web.AspNet.Models;

#line default
#line hidden
#line 3 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _07_Fiap.Web.AspNet.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5586204c21b809cfc94cea354e2cb7f9c5f822d5", @"/Views/Cela/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184c610675fc72a1d29679a170ce50655c290126", @"/Views/_ViewImports.cshtml")]
    public class Views_Cela_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Cela>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detalhar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(63, 171, true);
            WriteLiteral("\r\n<h1>Celas</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Área</th>\r\n        <th>Quantidade Maxima</th>\r\n        <th>Opções</th>\r\n    </tr>\r\n");
            EndContext();
#line 15 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
     foreach(var itens in Model)
    {

#line default
#line hidden
            BeginContext(275, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(306, 10, false);
#line 18 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
           Write(itens.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(316, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(340, 10, false);
#line 19 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
           Write(itens.Area);

#line default
#line hidden
            EndContext();
            BeginContext(350, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(374, 22, false);
#line 20 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
           Write(itens.QuantidadeMaxima);

#line default
#line hidden
            EndContext();
            BeginContext(396, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(437, 155, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5586204c21b809cfc94cea354e2cb7f9c5f822d55837", async() => {
                BeginContext(540, 48, true);
                WriteLiteral("\r\n                    Detalhes\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-codigo", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
                         WriteLiteral(itens.CelaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-codigo", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["codigo"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(592, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 28 "D:\Thiago\ENTERPRISE_APPLICATION_DEVELOPMENT2\07-Fiap.Web.AspNet\Views\Cela\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(635, 12, true);
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
