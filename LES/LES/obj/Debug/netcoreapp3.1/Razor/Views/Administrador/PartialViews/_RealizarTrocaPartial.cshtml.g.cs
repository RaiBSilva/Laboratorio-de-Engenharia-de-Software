#pragma checksum "D:\DEVELOPMENT\LES\LES\LES\Views\Administrador\PartialViews\_RealizarTrocaPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc9cfc4b7f09235a60649ec62762f35e51633c50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_PartialViews__RealizarTrocaPartial), @"mvc.1.0.view", @"/Views/Administrador/PartialViews/_RealizarTrocaPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc9cfc4b7f09235a60649ec62762f35e51633c50", @"/Views/Administrador/PartialViews/_RealizarTrocaPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d182fd369d3f2aa535a82b7100c694a2ef0f04", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_PartialViews__RealizarTrocaPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PedidoLivroModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/the-Winds-of-Winter-cover.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height:16rem"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal-content"">

    <!-- Modal content-->
    <div class=""modal-header"">
        <h4 class=""modal-title"">Realizar Troca</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
    </div>
    <div class=""modal-body"">
        <div>
            <div>
                <h5>
                    Tem certeza que deseja solicitar a troca desse livro?
                </h5>
            </div>

            <table class=""table table-borderless"">
                <thead>
                    <tr>
                        <th scope=""col"" style=""width:15%""></th>
                        <th scope=""col"">Título</th>
                        <th scope=""col"">Preço</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc9cfc4b7f09235a60649ec62762f35e51633c505323", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "D:\DEVELOPMENT\LES\LES\LES\Views\Administrador\PartialViews\_RealizarTrocaPartial.cshtml"
                       Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>R$ ");
#nullable restore
#line 30 "D:\DEVELOPMENT\LES\LES\LES\Views\Administrador\PartialViews\_RealizarTrocaPartial.cshtml"
                          Write(Model.Preco.ToString("0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n\r\n                <div class=\"form-group\">\r\n                    <button type=\"submit\"");
            BeginWriteAttribute("value", " value=\"", 1264, "\"", 1285, 1);
#nullable restore
#line 36 "D:\DEVELOPMENT\LES\LES\LES\Views\Administrador\PartialViews\_RealizarTrocaPartial.cshtml"
WriteAttributeValue("", 1272, Model.Codigo, 1272, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info col-12\" id=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1323, "\"", 1406, 3);
            WriteAttributeValue("", 1333, "window.location.href=\'", 1333, 22, true);
#nullable restore
#line 36 "D:\DEVELOPMENT\LES\LES\LES\Views\Administrador\PartialViews\_RealizarTrocaPartial.cshtml"
WriteAttributeValue("", 1355, Url.Action("RealizarTroca","Conta", Model.Codigo), 1355, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1405, "\'", 1405, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                        Pedir troca
                    </button>
                </div>

        </div>
    </div>
    <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Cancelar</button>
    </div>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PedidoLivroModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
