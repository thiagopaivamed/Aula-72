#pragma checksum "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\Shared\Components\FormacoesAcademicas\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3953f8968143bd215aae66f09c4a12bd19c2f85e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FormacoesAcademicas_Default), @"mvc.1.0.view", @"/Views/Shared/Components/FormacoesAcademicas/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/FormacoesAcademicas/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_FormacoesAcademicas_Default))]
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
#line 1 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\_ViewImports.cshtml"
using MontagemCr;

#line default
#line hidden
#line 2 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\_ViewImports.cshtml"
using MontagemCr.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3953f8968143bd215aae66f09c4a12bd19c2f85e", @"/Views/Shared/Components/FormacoesAcademicas/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b60d8e5b39658c10a7588a88957d12c1d367a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FormacoesAcademicas_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MontagemCr.Models.FormacaoAcademica>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "FormacoesAcademicas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating btn-small blue darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\Shared\Components\FormacoesAcademicas\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
            BeginContext(92, 96, true);
            WriteLiteral("    <li class=\"collection-item row\">\r\n        <div class=\"valign-wrapper col s10\">\r\n            ");
            EndContext();
            BeginContext(189, 49, false);
#line 7 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\Shared\Components\FormacoesAcademicas\Default.cshtml"
       Write(Html.DisplayFor(modelItem => item.TipoCurso.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(238, 4, true);
            WriteLiteral(" em ");
            EndContext();
            BeginContext(243, 44, false);
#line 7 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\Shared\Components\FormacoesAcademicas\Default.cshtml"
                                                             Write(Html.DisplayFor(modelItem => item.NomeCurso));

#line default
#line hidden
            EndContext();
            BeginContext(287, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(302, 46, false);
#line 8 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\Shared\Components\FormacoesAcademicas\Default.cshtml"
       Write(Html.DisplayFor(modelItem => item.Instituicao));

#line default
#line hidden
            EndContext();
            BeginContext(348, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(351, 44, false);
#line 8 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\Shared\Components\FormacoesAcademicas\Default.cshtml"
                                                        Write(Html.DisplayFor(modelItem => item.AnoInicio));

#line default
#line hidden
            EndContext();
            BeginContext(395, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(399, 41, false);
#line 8 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\Shared\Components\FormacoesAcademicas\Default.cshtml"
                                                                                                        Write(Html.DisplayFor(modelItem => item.AnoFim));

#line default
#line hidden
            EndContext();
            BeginContext(440, 68, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col s2 right\">\r\n            ");
            EndContext();
            BeginContext(508, 182, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef639a532cd2434f8afe6b8e345f1d4d", async() => {
                BeginContext(652, 34, true);
                WriteLiteral("<i class=\"material-icons\">edit</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\Shared\Components\FormacoesAcademicas\Default.cshtml"
                                                                        WriteLiteral(item.FormacaoAcademicaId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(690, 16, true);
            WriteLiteral("\r\n            <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 706, "\"", 777, 4);
            WriteAttributeValue("", 716, "ExibirModal(", 716, 12, true);
#line 13 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\Shared\Components\FormacoesAcademicas\Default.cshtml"
WriteAttributeValue("", 728, item.FormacaoAcademicaId, 728, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 753, ",", 753, 1, true);
            WriteAttributeValue(" ", 754, "\'FormacoesAcademicas\')", 755, 23, true);
            EndWriteAttribute();
            BeginContext(778, 122, true);
            WriteLiteral(" class=\"btn-floating btn-small red darken-4\"><i class=\"material-icons\">delete_forever</i></a>\r\n        </div>\r\n    </li>\r\n");
            EndContext();
#line 16 "E:\Aulas core mvc\Aula 37\MontagemCr\MontagemCr\Views\Shared\Components\FormacoesAcademicas\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MontagemCr.Models.FormacaoAcademica>> Html { get; private set; }
    }
}
#pragma warning restore 1591
