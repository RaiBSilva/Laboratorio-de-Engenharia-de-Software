#pragma checksum "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b3ded2cf19a359f5ee2d1cab49d75a920a0fc03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_PartialViews__ListaPedidosPartial), @"mvc.1.0.view", @"/Views/Conta/PartialViews/_ListaPedidosPartial.cshtml")]
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
#line 1 "C:\Programming\LES\LES\LES\Views\_ViewImports.cshtml"
using LES;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Programming\LES\LES\LES\Views\_ViewImports.cshtml"
using LES.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Programming\LES\LES\LES\Views\_ViewImports.cshtml"
using LES.Models.ViewModel.Conta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
using LES.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b3ded2cf19a359f5ee2d1cab49d75a920a0fc03", @"/Views/Conta/PartialViews/_ListaPedidosPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d182fd369d3f2aa535a82b7100c694a2ef0f04", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_PartialViews__ListaPedidosPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<PedidoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../PartialViews/_TablePedidos.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <h2 class=\"font-weight-light col-sm-12\">\r\n            Histórico de Compras\r\n        </h2>\r\n    </div>\r\n\r\n");
#nullable restore
#line 11 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
       IDictionary<StatusPedidos, string[]> statusInfo = new Dictionary<StatusPedidos, string[]>();

        statusInfo[(StatusPedidos)0] = new string[] { "text-info", "Em processamento."};
        statusInfo[(StatusPedidos)1] = new string[] { statusInfo[(StatusPedidos)0][0], "Em trânsito..." };
        statusInfo[(StatusPedidos)2] = new string[] { statusInfo[(StatusPedidos)0][0], "Troca em processamento..." };
        statusInfo[(StatusPedidos)3] = new string[] { statusInfo[(StatusPedidos)0][0], "Troca autorizada!" };
        statusInfo[(StatusPedidos)4] = new string[] { statusInfo[(StatusPedidos)0][0], "Aprovado!" };
        statusInfo[(StatusPedidos)5] = new string[] { "text-success", "Trocado!" };
        statusInfo[(StatusPedidos)6] = new string[] { statusInfo[(StatusPedidos)5][0], "Entregue!" };
        statusInfo[(StatusPedidos)7] = new string[] { "text-danger", "Negado." };

    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n    \r\n        <div id=\"accordion\" class=\"row justify-content-center\">\r\n");
#nullable restore
#line 27 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
               int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
             foreach (var pedido in Model)
            {
                string classeStatus = statusInfo[pedido.Status][0];

                string displayStatus = statusInfo[pedido.Status][1];


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-12 card\">\r\n                    <div class=\"card-header btn-light btn-pedido\"");
            BeginWriteAttribute("id", " id=\"", 1551, "\"", 1566, 2);
            WriteAttributeValue("", 1556, "heading_", 1556, 8, true);
#nullable restore
#line 35 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
WriteAttributeValue("", 1564, i, 1564, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h5 class=\"mb-0\">\r\n                            <button class=\"btn col-12 btn-pedido shadow-none\" data-toggle=\"collapse\" data-target=\"#collapse_");
#nullable restore
#line 37 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" aria-expanded=\"true\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 1761, "\"", 1788, 2);
            WriteAttributeValue("", 1777, "collapse_", 1777, 9, true);
#nullable restore
#line 37 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
WriteAttributeValue("", 1786, i, 1786, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"container\">\r\n                                    <div class=\"row justify-content-between\">\r\n                                        <span class=\"col-sm-2\">Pedido  #");
#nullable restore
#line 40 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
                                                                   Write(pedido.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <span class=\"col-sm-10 text-right font-weight-light\">\r\n                                            <span");
            BeginWriteAttribute("class", " class=\"", 2167, "\"", 2188, 1);
#nullable restore
#line 42 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
WriteAttributeValue("", 2175, classeStatus, 2175, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
                                                                   Write(displayStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - </span>\r\n                                            <span>Feito em ");
#nullable restore
#line 43 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
                                                      Write(pedido.DtPedido.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        </span>
                                    </div>
                                </div>
                            </button>
                        </h5>
                        
                    </div>

                    <div");
            BeginWriteAttribute("id", " id=\"", 2603, "\"", 2619, 2);
            WriteAttributeValue("", 2608, "collapse_", 2608, 9, true);
#nullable restore
#line 52 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
WriteAttributeValue("", 2617, i, 2617, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"collapse\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2637, "\"", 2665, 2);
            WriteAttributeValue("", 2655, "heading_", 2655, 8, true);
#nullable restore
#line 52 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
WriteAttributeValue("", 2663, i, 2663, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-parent=\"#accordion\">\r\n                        <div class=\"card-body\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b3ded2cf19a359f5ee2d1cab49d75a920a0fc0310266", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 54 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => pedido);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 59 "C:\Programming\LES\LES\LES\Views\Conta\PartialViews\_ListaPedidosPartial.cshtml"

                i++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<PedidoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
