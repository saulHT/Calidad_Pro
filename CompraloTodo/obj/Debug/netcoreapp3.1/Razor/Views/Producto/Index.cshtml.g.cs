#pragma checksum "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e11c5417edfb4c9231ae2a84460e815d755b6000"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Index), @"mvc.1.0.view", @"/Views/Producto/Index.cshtml")]
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
#line 1 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\_ViewImports.cshtml"
using CompraloTodo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\_ViewImports.cshtml"
using CompraloTodo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11c5417edfb4c9231ae2a84460e815d755b6000", @"/Views/Producto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d357e76891340c090ce61bd598c413da697f830", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Index.cshtml"
  
    Layout = "/Views/Shared/_LayoutLogin.cshtml";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n<h3>");
#nullable restore
#line 8 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Index.cshtml"
Write(ViewBag.usuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 9 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Index.cshtml"
Write(ViewBag.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
<h2>lista de Productos</h2>
<br />
<div class=""row"">
    <div class=""col-xs-2 text-right"">
        <a href=""/Producto/Crear"" class=""btn btn-info"">Nuevo</a>
    </div>
</div>
<table class=""table border"">
    <thead>
        <tr class=""table-primary"">
            <th>Nombre</th>
            <th>Precio</th>
            <th>Estado</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Index.cshtml"
               Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Index.cshtml"
               Write(item.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Index.cshtml"
               Write(item.estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a>Editar</a>|\r\n                    <a>Eliminar</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
            WriteLiteral("\r\n");
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