#pragma checksum "D:\DEVELOPMENT\LES\LES\LES\Views\Conta\PartialViews\_ListaTelefonesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa4a23e3c2b9b26ed0c34e44a00f7da140d6b918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conta_PartialViews__ListaTelefonesPartial), @"mvc.1.0.view", @"/Views/Conta/PartialViews/_ListaTelefonesPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa4a23e3c2b9b26ed0c34e44a00f7da140d6b918", @"/Views/Conta/PartialViews/_ListaTelefonesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05d182fd369d3f2aa535a82b7100c694a2ef0f04", @"/Views/_ViewImports.cshtml")]
    public class Views_Conta_PartialViews__ListaTelefonesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<DetalhesTelefoneModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../PartialViews/_DlTelefonePartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n    <div>\r\n        <div class=\"row\">\r\n            <h2 class=\"font-weight-light col-sm-12\">\r\n                Telefones\r\n            </h2>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 10 "D:\DEVELOPMENT\LES\LES\LES\Views\Conta\PartialViews\_ListaTelefonesPartial.cshtml"
             foreach (var tel in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-6 my-1 card\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa4a23e3c2b9b26ed0c34e44a00f7da140d6b9184167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 13 "D:\DEVELOPMENT\LES\LES\LES\Views\Conta\PartialViews\_ListaTelefonesPartial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => tel);

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
            WriteLiteral("\r\n                    <dl>\r\n                        <dd class=\"row justify-content-start mx-1\">\r\n                            <button class=\"btn btn-secondary botaoTelefone col-6 mr-3\" type=\"button\" data-toggle=\"modal\" data-target=\"#myModal\"");
            BeginWriteAttribute("value", " value=\"", 657, "\"", 672, 1);
#nullable restore
#line 16 "D:\DEVELOPMENT\LES\LES\LES\Views\Conta\PartialViews\_ListaTelefonesPartial.cshtml"
WriteAttributeValue("", 665, tel.Id, 665, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                Editar este telefone\r\n                            </button>\r\n");
#nullable restore
#line 19 "D:\DEVELOPMENT\LES\LES\LES\Views\Conta\PartialViews\_ListaTelefonesPartial.cshtml"
                             if (Model.Count > 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button class=\"btn btn-danger botaoRemoverTelefone col-2  mx-3\" type=\"button\" data-toggle=\"modal\" data-target=\"#myModal\"");
            BeginWriteAttribute("value", " value=\"", 1003, "\"", 1018, 1);
#nullable restore
#line 21 "D:\DEVELOPMENT\LES\LES\LES\Views\Conta\PartialViews\_ListaTelefonesPartial.cshtml"
WriteAttributeValue("", 1011, tel.Id, 1011, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    &times;\r\n                                </button>\r\n");
#nullable restore
#line 24 "D:\DEVELOPMENT\LES\LES\LES\Views\Conta\PartialViews\_ListaTelefonesPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 26 "D:\DEVELOPMENT\LES\LES\LES\Views\Conta\PartialViews\_ListaTelefonesPartial.cshtml"
                             if (!tel.EPreferencial)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button class=\"btn btn-outline-warning col-2 ml-3\" type=\"button\"");
            BeginWriteAttribute("value", " value=\"", 1324, "\"", 1339, 1);
#nullable restore
#line 28 "D:\DEVELOPMENT\LES\LES\LES\Views\Conta\PartialViews\_ListaTelefonesPartial.cshtml"
WriteAttributeValue("", 1332, tel.Id, 1332, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    &#9733;\r\n                                </button>\r\n");
#nullable restore
#line 31 "D:\DEVELOPMENT\LES\LES\LES\Views\Conta\PartialViews\_ListaTelefonesPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </dd>\r\n                    </dl>\r\n                </div>\r\n");
#nullable restore
#line 35 "D:\DEVELOPMENT\LES\LES\LES\Views\Conta\PartialViews\_ListaTelefonesPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        \r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<DetalhesTelefoneModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
