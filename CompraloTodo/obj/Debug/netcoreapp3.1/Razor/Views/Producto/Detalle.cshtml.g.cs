#pragma checksum "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "817c984f608aef4890d5b98d2bb70b3326933a56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Detalle), @"mvc.1.0.view", @"/Views/Producto/Detalle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"817c984f608aef4890d5b98d2bb70b3326933a56", @"/Views/Producto/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d357e76891340c090ce61bd598c413da697f830", @"/Views/_ViewImports.cshtml")]
    public class Views_Producto_Detalle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompraloTodo.Models.Producto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:460px; width:480px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row contact_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("contact_process.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contactForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString("novalidate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-contact form-review mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Detalle.cshtml"
  
    ViewData["Title"] = "Detalle";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817c984f608aef4890d5b98d2bb70b3326933a566920", async() => {
                WriteLiteral("\r\n        <script defer src=\"https://use.fontawesome.com/releases/v5.0.8/js/all.js\" integrity=\"sha384-SlE991lGASHoBfWbelyBPLsUlwY1GwNDJo3jSJO04KZ33K2bwfV9YBauFfnzvynJ\" crossorigin=\"anonymous\"></script>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h1>Detalle</h1>

<div class=""product_image_area"">
    <div class="" container"">
        <div class=""row s_Product_inner"">

            <div class=""col-lg-6"">
                <div class=""owl-carousel owl-theme s_Product_carousel owl-loaded owl-drag"">
                    <div class=""card-product__img"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "817c984f608aef4890d5b98d2bb70b3326933a568447", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 670, "~/imagen/", 670, 9, true);
#nullable restore
#line 18 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Detalle.cshtml"
AddHtmlAttributeValue("", 679, Model.imagen, 679, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-5 offset-lg-1\">\r\n                <div class=\"s_product_text\">\r\n                    <h3>");
#nullable restore
#line 24 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Detalle.cshtml"
                   Write(Model.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                    <h2>S/ ");
#nullable restore
#line 25 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Detalle.cshtml"
                      Write(Model.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <ul class=\"list\">\r\n");
#nullable restore
#line 27 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Detalle.cshtml"
                         if (@Model.estado == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a>Estado: Disponible</a></li>\r\n");
#nullable restore
#line 30 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Detalle.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a><span>Disponible: No Disponible</span></a></li>\r\n");
#nullable restore
#line 34 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Detalle.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </ul>
                    <p></p>
                    <div class=""product_count"">
                        <a class=""button primary-btn"" href=""/Venta/Compras"">Comprar</a>
                    </div>
                </div>
            </div>


        </div>
    </div>
</div>


<section class=""product_description_area"">
    <div class=""container"">
        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
            <li class=""nav-item"">
                <a class=""nav-link"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">Description</a>
            </li>

            <li class=""nav-item"">
                <a class=""nav-link"" id=""contact-tab"" data-toggle=""tab"" href=""#contact"" role=""tab"" aria-controls=""contact""
                   aria-selected=""false"">Comments</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link active"" id=""review-tab"" data-toggle=""tab"" href=""#review"" role=""tab"" a");
            WriteLiteral(@"ria-controls=""review""
                   aria-selected=""false"">Reviews</a>
            </li>
        </ul>
        <div class=""tab-content"" id=""myTabContent"">
            <div class=""tab-pane fade"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                <p>
                    ");
#nullable restore
#line 69 "D:\Visual_Proyecto\CALIDAD_PRO\CompraloTodo\CompraloTodo\Views\Producto\Detalle.cshtml"
               Write(Model.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>

            </div>

            <div class=""tab-pane fade"" id=""contact"" role=""tabpanel"" aria-labelledby=""contact-tab"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""comment_list"">
                            <div class=""review_item"">
                                <div class=""media"">
                                    <div class=""d-flex"">
                                        <img src=""img/product/review-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 3230, "\"", 3236, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""media-body"">
                                        <h4>Blake Ruiz</h4>
                                        <h5>12th Feb, 2018 at 05:56 pm</h5>

                                    </div>
                                </div>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et
                                    dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
                                    commodo
                                </p>
                            </div>

                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""review_box"">
                            <h4>Comentario</h4>
                            <div>
       ");
            WriteLiteral("                         <div>\r\n                                    <samp class=\"fa fa-star\" id=\"1es\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4362, "\"", 4372, 0);
            EndWriteAttribute();
            WriteLiteral(@"></samp>
                                    <samp class=""fa fa-star"" id=""2es""></samp>
                                    <samp class=""fa fa-star"" id=""3es""></samp>
                                    <samp class=""fa fa-star"" id=""4es""></samp>
                                    <samp class=""fa fa-star"" id=""5es""></samp>
                                </div>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817c984f608aef4890d5b98d2bb70b3326933a5615897", async() => {
                WriteLiteral(@"

                                    <div class=""col-md-12"">
                                        <div class=""form-group"">
                                            <textarea class=""form-control"" name=""message"" id=""message"" rows=""4"" placeholder=""comentario""></textarea>
                                        </div>
                                    </div>
                                    <div class=""col-md-12 text-right"">
                                        <button type=""submit"" class=""button button--active button-review "">Agregar Comentario</button>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
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
                    </div>
                </div>
            </div>
            <div class=""tab-pane fade show active"" id=""review"" role=""tabpanel"" aria-labelledby=""review-tab"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""row total_rate"">
                            <div class=""col-6"">
                                <div class=""box_total"">
                                    <h5>Overall</h5>
                                    <h4>4.0</h4>
                                    <h6>(03 Reviews)</h6>
                                </div>
                            </div>
                            <div class=""col-6"">
                                <div class=""rating_list"">
                                    <h3>Based on 3 Reviews</h3>
                                    <ul class=""list"">
                                        <li>
                  ");
            WriteLiteral(@"                          <a href=""#"">
                                                5 Star <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i> 01
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                4 Star <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i> 01
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                3 Star <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i> 01
            ");
            WriteLiteral(@"                                </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                2 Star <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i> 01
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                1 Star <i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i><i class=""fa fa-star""></i> 01
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
      ");
            WriteLiteral(@"                  <div class=""review_list"">
                            <div class=""review_item"">
                                <div class=""media"">
                                    <div class=""d-flex"">
                                        <img src=""img/product/review-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 8908, "\"", 8914, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""media-body"">
                                        <h4>Blake Ruiz</h4>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                    </div>
                                </div>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et
                                    dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
                                    commodo
                                </p>
                      ");
            WriteLiteral("      </div>\r\n                            <div class=\"review_item\">\r\n                                <div class=\"media\">\r\n                                    <div class=\"d-flex\">\r\n                                        <img src=\"img/product/review-2.png\"");
            BeginWriteAttribute("alt", " alt=\"", 10194, "\"", 10200, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""media-body"">
                                        <h4>Blake Ruiz</h4>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                    </div>
                                </div>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et
                                    dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
                                    commodo
                                </p>
                      ");
            WriteLiteral("      </div>\r\n                            <div class=\"review_item\">\r\n                                <div class=\"media\">\r\n                                    <div class=\"d-flex\">\r\n                                        <img src=\"img/product/review-3.png\"");
            BeginWriteAttribute("alt", " alt=\"", 11480, "\"", 11486, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""media-body"">
                                        <h4>Blake Ruiz</h4>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                        <i class=""fa fa-star""></i>
                                    </div>
                                </div>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et
                                    dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea
                                    commodo
                                </p>
                      ");
            WriteLiteral(@"      </div>
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""review_box"">
                            <h4>Add a Review</h4>
                            <p>Your Rating:</p>
                            <ul class=""list"">
                                <li><a href=""#""><i class=""fa fa-star""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-star""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-star""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-star""></i></a></li>
                                <li><a href=""#""><i class=""fa fa-star""></i></a></li>
                            </ul>
                            <p>Outstanding</p>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "817c984f608aef4890d5b98d2bb70b3326933a5626922", async() => {
                WriteLiteral(@"
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""name"" type=""text"" placeholder=""Enter your name"" required>
                                </div>
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""email"" type=""email"" placeholder=""Enter email address"" required>
                                </div>
                                <div class=""form-group"">
                                    <input class=""form-control"" name=""subject"" type=""text"" placeholder=""Enter Subject"">
                                </div>
                                <div class=""form-group"">
                                    <textarea class=""form-control different-control w-100"" name=""textarea"" id=""textarea"" cols=""30"" rows=""5"" placeholder=""Enter Message""></textarea>
                                </div>
                                <div class=""form-group text-cent");
                WriteLiteral("er text-md-right mt-3\">\r\n                                    <button type=\"submit\" class=\"button button--active button-review\">Submit Now</button>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompraloTodo.Models.Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591
