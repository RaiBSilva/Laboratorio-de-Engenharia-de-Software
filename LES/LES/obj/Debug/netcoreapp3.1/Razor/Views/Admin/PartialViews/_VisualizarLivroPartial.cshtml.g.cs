#pragma checksum "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88de0711c449c2418a2acc10a0f18326c92a6866"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialViews__VisualizarLivroPartial), @"mvc.1.0.view", @"/Views/Admin/PartialViews/_VisualizarLivroPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88de0711c449c2418a2acc10a0f18326c92a6866", @"/Views/Admin/PartialViews/_VisualizarLivroPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d182fd369d3f2aa535a82b7100c694a2ef0f04", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_PartialViews__VisualizarLivroPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LES.Models.ViewModel.Admin.AdminLivroModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/the-Winds-of-Winter-cover.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            <h4 class=""modal-title"">Detalhes do Livro</h4>
            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
        </div>
        <div class=""modal-body"">
            <div class=""container"">

                <div class=""row my-2"">
                    <div class=""col-md-6"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "88de0711c449c2418a2acc10a0f18326c92a68664546", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-sm-12\">\r\n                                <h3 class=\"font-weight-light\">");
#nullable restore
#line 19 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                         Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-sm-12\">\r\n                                <h5 class=\"text-muted\">");
#nullable restore
#line 24 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                  Write(Model.Autor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row mt-2"">
                    <div class=""col-4"">
                        <div class=""font-weight-bold"">");
#nullable restore
#line 32 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                 Write(Html.DisplayNameFor(m => m.Editora));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"font-weight-light\">");
#nullable restore
#line 33 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                  Write(Model.Editora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"col-4\">\r\n                        <div class=\"font-weight-bold\">");
#nullable restore
#line 36 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                 Write(Html.DisplayNameFor(m => m.Edicao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"font-weight-light\">");
#nullable restore
#line 37 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                  Write(Model.Edicao);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ª Edição</div>\r\n                    </div>\r\n                    <div class=\"col-4\">\r\n                        <div class=\"font-weight-bold\">");
#nullable restore
#line 40 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                 Write(Html.DisplayNameFor(m => m.DtLancamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"font-weight-light\">");
#nullable restore
#line 41 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                  Write(Model.DtLancamento.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n                <div class=\"row mt-2\">\r\n                    <div class=\"col-4\">\r\n                        <div class=\"font-weight-bold\">");
#nullable restore
#line 48 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                 Write(Html.DisplayNameFor(m => m.Isbn));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"font-weight-light\">");
#nullable restore
#line 49 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                  Write(Model.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"col-4\">\r\n                        <div class=\"font-weight-bold\">");
#nullable restore
#line 52 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                 Write(Html.DisplayNameFor(m => m.Paginas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"font-weight-light\">");
#nullable restore
#line 53 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                  Write(Model.Paginas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"col-4\">\r\n                        <div class=\"font-weight-bold\">Dimensões</div>\r\n                        <div class=\"font-weight-light\">");
#nullable restore
#line 57 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                  Write(Model.Comprimento);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 57 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                                       Write(Model.Altura);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 57 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                                                       Write(Model.Largura);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm</div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"row mt-2\">\r\n                    <div class=\"col-12\">\r\n                        <div class=\"font-weight-bold\">");
#nullable restore
#line 63 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                 Write(Html.DisplayNameFor(m => m.Sinopse));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-12\">\r\n                        <small class=\"font-weight-light\">");
#nullable restore
#line 68 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                    Write(Model.Sinopse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"row my-2\">\r\n                    <div class=\"col-4\">\r\n                        <div class=\"font-weight-bold\">");
#nullable restore
#line 74 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                 Write(Html.DisplayNameFor(m => m.GrupoPreco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"font-weight-light\">");
#nullable restore
#line 75 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                  Write(Model.GrupoPreco.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (margem de ");
#nullable restore
#line 75 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                                                     Write(Model.GrupoPreco.MargemLucro );

#line default
#line hidden
#nullable disable
            WriteLiteral(" %)</div>\r\n                    </div>\r\n                    <div class=\"col-4\">\r\n                        <div class=\"font-weight-bold\">");
#nullable restore
#line 78 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                 Write(Html.DisplayNameFor(m => m.Preco));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"font-weight-light\">R$ ");
#nullable restore
#line 79 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                     Write(Model.Preco.ToString("0.00").Replace(".",","));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"col-4\">\r\n                        <div class=\"font-weight-bold\">");
#nullable restore
#line 82 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                 Write(Html.DisplayNameFor(m => m.CodigoBarras));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"font-weight-light\">");
#nullable restore
#line 83 "C:\Programming\LES\LES\LES\Views\Admin\PartialViews\_VisualizarLivroPartial.cshtml"
                                                  Write(Model.CodigoBarras);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                </div>


            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Sair</button>
            </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LES.Models.ViewModel.Admin.AdminLivroModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
