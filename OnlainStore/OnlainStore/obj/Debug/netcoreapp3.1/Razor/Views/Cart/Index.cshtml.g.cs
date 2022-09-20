#pragma checksum "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebdd8603f418e2f27f8c3c039947581bd5462798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using OnlainStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using OnlainStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using OlineStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using Store_Memory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebdd8603f418e2f27f8c3c039947581bd5462798", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21acfd4f1cceb25e8af64608522c202f3f33ce81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cart>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Корзина";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Корзина</h1>

<table class=""table table-sm table-striped"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Товар</th>
            <th scope=""col"">Цена</th>
            <th scope=""col"">Количество</th>
            <th scope=""col"">Стоимоить</th>
            <th scope=""col""></th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 21 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
         foreach (var item in Model.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n\r\n                <td>");
#nullable restore
#line 25 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 26 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
                                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 27 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
                                 Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-left\">");
#nullable restore
#line 28 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
                                 Write(item.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"text-center\">\r\n                    <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 832, "\"", 868, 2);
            WriteAttributeValue("", 839, "/Cart/AddItem/", 839, 14, true);
#nullable restore
#line 30 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 853, item.ProductId, 853, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">+</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 936, "\"", 975, 2);
            WriteAttributeValue("", 943, "/Cart/ReduceItem/", 943, 17, true);
#nullable restore
#line 31 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 960, item.ProductId, 960, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">-</a>\r\n                </td>\r\n                <td class=\"text-left\">\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1106, "\"", 1145, 2);
            WriteAttributeValue("", 1113, "/Cart/RemoveItem/", 1113, 17, true);
#nullable restore
#line 34 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1130, item.ProductId, 1130, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Удалить</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td></td>\r\n            <td class=\"text-right\">Итого </td>\r\n            <td class=\"text-left\">");
#nullable restore
#line 43 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
                             Write(Model.TotalCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-left\">");
#nullable restore
#line 44 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Cart\Index.cshtml"
                             Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>
    </tfoot>
</table>
<div class=""text-center"">
    <a class=""btn btn-primary"" href=""/Home/index"" role=""button"">Продолжить покупки</a>
    <a class=""btn btn-success"" href=""/Order/index"" role=""button"">Оформить заказ</a>
    <a class=""btn btn-danger"" href=""/Cart/clear"" role=""button"">Удалить</a>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cart> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591