#pragma checksum "C:\Users\Dev\Documents\Estudar.NET\SistemaVenda\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab32d73024a10db48c39ce67248d05ea599028cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Index), @"mvc.1.0.view", @"/Views/Categoria/Index.cshtml")]
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
#line 1 "C:\Users\Dev\Documents\Estudar.NET\SistemaVenda\Views\_ViewImports.cshtml"
using SistemaVenda;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dev\Documents\Estudar.NET\SistemaVenda\Views\_ViewImports.cshtml"
using SistemaVenda.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab32d73024a10db48c39ce67248d05ea599028cb", @"/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9542d2a040dc74eba97c4a394c73aefd7909e77c", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SistemaVenda.Models.CategoriaViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Dev\Documents\Estudar.NET\SistemaVenda\Views\Categoria\Index.cshtml"
  
    ViewData["Title"] = "Categorias";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<h2>Categorias</h2>\r\n<hr />\r\n\r\n<table class=\"table table-bordered\">\r\n    <thead>\r\n        <tr style=\"background-color: #f6f6f6;\">\r\n            <th>Cógigo</th>\r\n            <th>Descrição</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "C:\Users\Dev\Documents\Estudar.NET\SistemaVenda\Views\Categoria\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("onclick", " onclick=\"", 404, "\"", 434, 3);
            WriteAttributeValue("", 414, "Editar(", 414, 7, true);
#nullable restore
#line 21 "C:\Users\Dev\Documents\Estudar.NET\SistemaVenda\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 421, item.Codigo, 421, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 433, ")", 433, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"cursor: pointer;\">\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Dev\Documents\Estudar.NET\SistemaVenda\Views\Categoria\Index.cshtml"
               Write(item.Codigo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Dev\Documents\Estudar.NET\SistemaVenda\Views\Categoria\Index.cshtml"
               Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Dev\Documents\Estudar.NET\SistemaVenda\Views\Categoria\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
<br />
<button type=""button"" class=""btn btn-block btn-primary"" onclick=""Cadastrar()"">Cadastrar Categoria</button>
<script>
    function Editar(Codigo) {
        window.location = window.origin + ""\\Categoria\\Cadastro\\"" + Codigo;
    }

    function Cadastrar() {
        window.location = window.origin + ""\\Categoria\\Cadastro"";
    }
</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SistemaVenda.Models.CategoriaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591