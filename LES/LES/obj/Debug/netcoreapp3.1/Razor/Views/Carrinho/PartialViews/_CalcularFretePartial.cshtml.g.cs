#pragma checksum "C:\Programming\LES\LES\LES\Views\Carrinho\PartialViews\_CalcularFretePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c1516efa9fcbb067d471f98d77aff1793f2f4ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_PartialViews__CalcularFretePartial), @"mvc.1.0.view", @"/Views/Carrinho/PartialViews/_CalcularFretePartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c1516efa9fcbb067d471f98d77aff1793f2f4ab", @"/Views/Carrinho/PartialViews/_CalcularFretePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d182fd369d3f2aa535a82b7100c694a2ef0f04", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_PartialViews__CalcularFretePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <div class=""modal-content"">

        <!-- Modal content-->
        <div class=""modal-header"">
            <h4 class=""modal-title"">Calcular Frete</h4>
            <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
        </div>
        <div class=""modal-body"">

            <div class=""row"">
                <div class=""col-sm-6 border-right p-5"">
                    <div class=""row"">CEP:</div>
                    <div class=""row""> <input class=""form-control"" /></div>
                </div>
                <div class=""col-sm-6 border-left p-5"">
                    <div class=""row"">Frete: </div>
                    <div class=""row""><h5 class=""font-weight-bold"">R$<span>0,00</span></h5></div>
                </div>
            </div>


            <div class=""row"">
                <div class=""form-group col-12"">
                    <button class=""btn btn-primary btn-lg btn-block"" id=""btnFrete"">Calcular</button>
                </div>
            </div>

     ");
            WriteLiteral("   </div>\r\n        <div class=\"modal-footer\">\r\n            <button type=\"button\" class=\"btn btn-default\" data-dismiss=\"modal\">Cancelar</button>\r\n        </div>\r\n\r\n    </div>");
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
