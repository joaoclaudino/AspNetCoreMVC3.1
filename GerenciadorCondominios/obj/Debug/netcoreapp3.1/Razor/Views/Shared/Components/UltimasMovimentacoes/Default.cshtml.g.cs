#pragma checksum "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "740c3dd55815bfe05810744794fba5295096b9d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UltimasMovimentacoes_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml")]
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
#line 1 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/_ViewImports.cshtml"
using GerenciadorCondominios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/_ViewImports.cshtml"
using GerenciadorCondominios.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
using GerenciadorCondominios.BLL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"740c3dd55815bfe05810744794fba5295096b9d4", @"/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0cfb221ef3ab357afb8a1c2acf66aa8d50e076", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UltimasMovimentacoes_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GerenciadorCondominios.BLL.Models.HistoricoRecursos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n\n");
#nullable restore
#line 6 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
 if (Model.Any())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
         if (item.Tipo == Tipos.Saida)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"collection-item\">\n                <text class=\"valign-wrapper\">\n                    <i class=\"material-icons down\">arrow_downward</i>\n                    R$ ");
#nullable restore
#line 15 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
                  Write(item.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; <span class=\"new badge\" data-badge-caption=\"\">");
#nullable restore
#line 15 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
                                                                                   Write(item.Dia);

#line default
#line hidden
#nullable disable
            WriteLiteral(" de ");
#nullable restore
#line 15 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
                                                                                                Write(item.Mes.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </text>\n            </div>\n");
#nullable restore
#line 18 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"collection-item\">\n                <text class=\"valign-wrapper\">\n                    <i class=\"material-icons up\">arrow_upward</i>\n                    R$ ");
#nullable restore
#line 24 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
                  Write(item.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; <span class=\"new badge\" data-badge-caption=\"\">");
#nullable restore
#line 24 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
                                                                                   Write(item.Dia);

#line default
#line hidden
#nullable disable
            WriteLiteral(" de ");
#nullable restore
#line 24 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
                                                                                                Write(item.Mes.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </text>\n            </div>\n");
#nullable restore
#line 27 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"collection-item\">\n        <text>Sem movimentações ainda</text>\n    </div>\n");
#nullable restore
#line 35 "/home/joao/Documentos/GerenciadorCondominios/GerenciadorCondominios/Views/Shared/Components/UltimasMovimentacoes/Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GerenciadorCondominios.BLL.Models.HistoricoRecursos>> Html { get; private set; }
    }
}
#pragma warning restore 1591