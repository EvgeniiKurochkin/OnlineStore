#pragma checksum "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e30e6f55d5799d5c0cb9bf3c8807f380b4d86e77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Products), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Products.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\_ViewImports.cshtml"
using OnlainStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\_ViewImports.cshtml"
using OlineStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\_ViewImports.cshtml"
using OnlainStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\_ViewImports.cshtml"
using OlineStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\_ViewImports.cshtml"
using Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\_ViewImports.cshtml"
using Store_Memory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e30e6f55d5799d5c0cb9bf3c8807f380b4d86e77", @"/Areas/Admin/Views/Product/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a11f5182d4a1088deeaa1c6e6a5ab5a9464da4d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Product_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("modal fade"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tabindex", new global::Microsoft.AspNetCore.Html.HtmlString("-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-labelledby", new global::Microsoft.AspNetCore.Html.HtmlString("asd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-hidden", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"text-center\">Список продуктов</h1>\r\n\r\n<button type=\"button\" class=\"btn btn-primary\" data-bs-toggle=\"modal\" data-bs-target=\"#AddNewProduct\">\r\n    Добавить новый продукт\r\n</button>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
  
    var addProduct = new OnlineStore.Areas.Admin.Modals.AddNewProduct();

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
Write(await Html.PartialAsync("AddProduct", addProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<table class=""table table-sm table-striped"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">№</th>
            <th scope=""col"">Название</th>
            <th scope=""col"">Цена</th>
            <th scope=""col""></th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 27 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
         for(int i = 0; i<Model.Count; i++)
        {
            
            string nameModal = "EditProduct" + i;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 33 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
               Write(Model[i].Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 34 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
                                 Write(Model[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 35 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
                                 Write(Model[i].Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">\r\n                    <button type=\"button\" class=\"btn btn-primary\" data-bs-toggle=\"modal\" data-bs-target=\"#");
#nullable restore
#line 37 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
                                                                                                     Write(nameModal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        Редактировать\r\n                    </button>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30e6f55d5799d5c0cb9bf3c8807f380b4d86e7711805", async() => {
                WriteLiteral("\r\n                        <div class=\"modal-dialog\">\r\n                            <div class=\"modal-content\">\r\n                                <div class=\"modal-header\">\r\n                                    <h5 class=\"modal-title\"");
                BeginWriteAttribute("id", " id=\"", 1568, "\"", 1583, 1);
#nullable restore
#line 44 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
WriteAttributeValue("", 1573, nameModal, 1573, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Редактировать</h5>\r\n                                </div>\r\n                                <div class=\"modal-body\">\r\n");
#nullable restore
#line 47 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
                                      
                                        var editProduct = new OnlineStore.Areas.Admin.Modals.EditProduct();
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
#nullable restore
#line 50 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
                               Write(await Html.PartialAsync("EditProduct", editProduct));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n                                </div>\r\n                                <div class=\"modal-footer\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30e6f55d5799d5c0cb9bf3c8807f380b4d86e7713732", async() => {
                    WriteLiteral("Внести изменения");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Editid", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
                                                                                                                                                           WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["Editid"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Editid", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["Editid"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 40 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
AddHtmlAttributeValue("", 1271, nameModal, 1271, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e30e6f55d5799d5c0cb9bf3c8807f380b4d86e7718995", async() => {
                WriteLiteral("Удалить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
                                                                                                                     WriteLiteral(Model[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Areas\Admin\Views\Product\Products.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591