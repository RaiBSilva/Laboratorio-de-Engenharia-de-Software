#pragma checksum "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0c2388a4744e0336f821d09dfc3c724fbedbb40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Detalhes), @"mvc.1.0.view", @"/Views/Clientes/Detalhes.cshtml")]
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
#line 1 "D:\DEVELOPMENT\LES\LES\LES\Views\_ViewImports.cshtml"
using LES;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DEVELOPMENT\LES\LES\LES\Views\_ViewImports.cshtml"
using LES.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c2388a4744e0336f821d09dfc3c724fbedbb40", @"/Views/Clientes/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26cf44f01c1eae048a1ce84ded07886f12edd399", @"/Views/_ViewImports.cshtml")]
    public class Views_Clientes_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LES.Models.ViewModel.ClienteCadastro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n\r\n<div>\r\n    <h4>Cliente</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.DtNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.DtNascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Genero));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
       Write(Html.DisplayFor(model => model.Ddd));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 42 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                                              Write(Html.DisplayFor(model => model.Telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
       Write(Html.DisplayNameFor(model => model.Enderecos));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <dl class=\"row\">\r\n");
#nullable restore
#line 49 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                   int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                 foreach (var endereco in Model.Enderecos.Values)
                {
                    { i++; }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                        Endereco  ");
#nullable restore
#line 54 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 57 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                   Write(endereco.Logradouro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 57 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                                        Write(endereco.Numero);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        ");
#nullable restore
#line 58 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                   Write(endereco.Cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 58 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                                      Write(endereco.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 58 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                                                        Write(endereco.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 59 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                         if (endereco.ECobranca)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>É endereço de cobrança.</p>\r\n");
#nullable restore
#line 62 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                         if (endereco.EEntrega)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>É endereço de entrega.</p>\r\n");
#nullable restore
#line 66 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </dd>\r\n");
#nullable restore
#line 68 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dl>\r\n        </dd>\r\n");
#nullable restore
#line 71 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
           i = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 75 "D:\DEVELOPMENT\LES\LES\LES\Views\Clientes\Detalhes.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0c2388a4744e0336f821d09dfc3c724fbedbb4011032", async() => {
                WriteLiteral("De volta a listagem");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LES.Models.ViewModel.ClienteCadastro> Html { get; private set; }
    }
}
#pragma warning restore 1591
