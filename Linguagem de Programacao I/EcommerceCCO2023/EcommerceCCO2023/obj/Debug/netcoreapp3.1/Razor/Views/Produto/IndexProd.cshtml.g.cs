#pragma checksum "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a41da5b60a72c36e2ae1a90378ceffc87959d25850c2a25666cf35fa57ae3f45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_IndexProd), @"mvc.1.0.view", @"/Views/Produto/IndexProd.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\_ViewImports.cshtml"
using EcommerceCCO2023;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\_ViewImports.cshtml"
using EcommerceCCO2023.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a41da5b60a72c36e2ae1a90378ceffc87959d25850c2a25666cf35fa57ae3f45", @"/Views/Produto/IndexProd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d4cf9a087e6dcad1b435963ec34b4d4e953f6daf5173aab5e26dc8ecee89b3a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Produto_IndexProd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-striped table-hover\">\r\n");
#nullable restore
#line 4 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>Código</th>\r\n            <th>Produto</th>\r\n            <th>Descrição</th>\r\n            <th>Preço</th>\r\n            <th>Categoria</th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 15 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
         foreach (var p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
               Write(p.IdProduto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
               Write(p.NomeProd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
               Write(p.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
               Write(p.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
               Write(p.Categoria.NomeCategoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-sm btn-success\"");
            BeginWriteAttribute("href", " href=\"", 661, "\"", 696, 2);
            WriteAttributeValue("", 668, "/Produto/Update/", 668, 16, true);
#nullable restore
#line 24 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
WriteAttributeValue("", 684, p.IdProduto, 684, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                    <a class=\"btn btn-sm btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 763, "\"", 798, 2);
            WriteAttributeValue("", 770, "/Produto/Delete/", 770, 16, true);
#nullable restore
#line 25 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
WriteAttributeValue("", 786, p.IdProduto, 786, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Apagar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td> VOLTOU NULL </td>\r\n    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Lagoa\Downloads\EcommerceCCO2023 (2)\EcommerceCCO2023\EcommerceCCO2023\Views\Produto\IndexProd.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n\r\n<a class=\"btn btn-primary\" href=\"/Produto/Create\">Adicionar</a>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
