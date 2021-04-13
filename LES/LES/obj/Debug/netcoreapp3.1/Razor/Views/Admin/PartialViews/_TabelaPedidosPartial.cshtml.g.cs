#pragma checksum "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98d565bdd063cdef23c09dc9f2303862b55a8373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialViews__TabelaPedidosPartial), @"mvc.1.0.view", @"/Views/Admin/PartialViews/_TabelaPedidosPartial.cshtml")]
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
#nullable restore
#line 3 "D:\DEVELOPMENT\LES\LES\LES\Views\_ViewImports.cshtml"
using LES.Models.ViewModel.Conta;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
using LES.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98d565bdd063cdef23c09dc9f2303862b55a8373", @"/Views/Admin/PartialViews/_TabelaPedidosPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d182fd369d3f2aa535a82b7100c694a2ef0f04", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PartialViews__TabelaPedidosPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LES.Models.ViewModel.Admin.AdminPedidoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
   IDictionary<StatusPedidos, string[]> statusInfo = new Dictionary<StatusPedidos, string[]>();

    statusInfo[(StatusPedidos)0] = new string[] { "text-info", "Em processamento." };
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
            WriteLiteral("\r\n<tr>\r\n    <th scope=\"row\">");
#nullable restore
#line 18 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
               Write(Model.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    <td>");
#nullable restore
#line 19 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
   Write(Model.Cliente.InfoUsuario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>´");
#nullable restore
#line 20 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
    Write(Model.DtPedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>R$ ");
#nullable restore
#line 21 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
      Write(Model.PreçoTotal.ToString("0.00").Replace('.', ','));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td");
            BeginWriteAttribute("class", " class=\"", 1158, "\"", 1194, 1);
#nullable restore
#line 22 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
WriteAttributeValue("", 1166, statusInfo[Model.Status][0], 1166, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 22 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
                                        Write(statusInfo[Model.Status][1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>\r\n");
#nullable restore
#line 24 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
         if (Model.Status == (StatusPedidos)0 || Model.Status == (StatusPedidos)2)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-success btnAprovar btn-block\" data-toggle=\"modal\" data-target=\"#myModal\"");
            BeginWriteAttribute("value", " value=\"", 1445, "\"", 1466, 1);
#nullable restore
#line 27 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
WriteAttributeValue("", 1453, Model.Codigo, 1453, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Aprovar</button>\r\n            <button class=\"btn btn-danger btnNegar btn-block\" data-toggle=\"modal\" data-target=\"#myModal\"");
            BeginWriteAttribute("value", " value=\"", 1590, "\"", 1611, 1);
#nullable restore
#line 28 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
WriteAttributeValue("", 1598, Model.Codigo, 1598, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Negar</button>\r\n");
#nullable restore
#line 29 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"

        }
        else if (Model.Status <= (StatusPedidos)4)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-danger btnCancelar btn-block\" data-toggle=\"modal\" data-target=\"#myModal\"");
            BeginWriteAttribute("value", " value=\"", 1812, "\"", 1833, 1);
#nullable restore
#line 33 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
WriteAttributeValue("", 1820, Model.Codigo, 1820, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Cancelar</button>\r\n");
#nullable restore
#line 34 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button class=\"btn btn-outline-info btnVisualizar btn-block\" data-toggle=\"modal\" data-target=\"#myModal\"");
            BeginWriteAttribute("value", " value=\"", 1976, "\"", 1997, 1);
#nullable restore
#line 35 "D:\DEVELOPMENT\LES\LES\LES\Views\Admin\PartialViews\_TabelaPedidosPartial.cshtml"
WriteAttributeValue("", 1984, Model.Codigo, 1984, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Visualizar</button>\r\n    </td>\r\n</tr>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LES.Models.ViewModel.Admin.AdminPedidoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
