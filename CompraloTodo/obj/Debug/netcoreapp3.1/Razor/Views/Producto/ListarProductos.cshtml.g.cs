#pragma checksum "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\ListarProductos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47497e88da88406af07cb06f752fe8c01bf18973"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_ListarProductos), @"mvc.1.0.view", @"/Views/Producto/ListarProductos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47497e88da88406af07cb06f752fe8c01bf18973", @"/Views/Producto/ListarProductos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d357e76891340c090ce61bd598c413da697f830", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_ListarProductos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagen/hero-banner.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\ListarProductos.cshtml"
  
    ViewData["Title"] = "ListarProductos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>ListarProductos</h1>

<main class=""site-main"">
    <section>
        <div class=""container"">
            <div class=""row no-gutters align-items-center pt-60px"">
                <div class=""col-5 d-none d-sm-block"">
                    <div class=""hero-banner__img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47497e88da88406af07cb06f752fe8c01bf189734798", async() => {
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
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-sm-7 col-lg-6 offset-lg-1 pl-4 pl-md-5 pl-lg-0"">
                    <div class=""hero-banner__content"">
                        <h4>Comprar es divertido</h4>
                        <h1>EXPLORE NUESTRO PRODUCTOS</h1>
                        <p>
                            Registrate y podras vender tus productos nuevos
                            sin pagar  facil y sencillo.
                        </p>
                        <a class=""button button-hero "" href=""/Usuario/Crear"">Registrarse</a>
                    </div>
                </div>
            </div>
        </div>
    </section>

</main>
<br />
<br />
<h3>Productos</h3>
<div class=""row"">
");
#nullable restore
#line 37 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\ListarProductos.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-6 col-xl-3\">\r\n            <div class=\"card text-center card-product\">\r\n                <div class=\"card-product__img\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "47497e88da88406af07cb06f752fe8c01bf189737110", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1413, "~/imagen/", 1413, 9, true);
#nullable restore
#line 42 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\ListarProductos.cshtml"
AddHtmlAttributeValue("", 1422, item.imagen, 1422, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("                </div>\r\n                <div class=\"card-body\">\r\n                    <p></p>\r\n                    <h4 class=\"card-product__title\"><a");
            BeginWriteAttribute("href", " href=\"", 1914, "\"", 1947, 2);
            WriteAttributeValue("", 1921, "/Producto/Detalle/", 1921, 18, true);
#nullable restore
#line 51 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\ListarProductos.cshtml"
WriteAttributeValue("", 1939, item.id, 1939, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\ListarProductos.cshtml"
                                                                                    Write(item.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                    <p class=\"card-product__price\">");
#nullable restore
#line 52 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\ListarProductos.cshtml"
                                              Write(item.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>usuario: ");
#nullable restore
#line 53 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\ListarProductos.cshtml"
                           Write(item.Usuario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 57 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\ListarProductos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
