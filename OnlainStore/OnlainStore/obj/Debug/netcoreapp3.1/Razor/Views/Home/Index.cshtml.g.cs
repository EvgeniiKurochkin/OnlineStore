#pragma checksum "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99cc1f05f56e028cabb465b4df9ade888de6b259"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 5 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using Store_Memory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Home\Index.cshtml"
using Store;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Home\Index.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99cc1f05f56e028cabb465b4df9ade888de6b259", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21acfd4f1cceb25e8af64608522c202f3f33ce81", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n</div>\r\n\r\n<div class=\"row\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Home\Index.cshtml"
     foreach (var product in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-4 card shadow\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 277, "\"", 296, 1);
#nullable restore
#line 15 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 283, product.Link, 283, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div class=\"card-body\">\r\n                <a style=\"color: black\"");
            BeginWriteAttribute("href", " href=\"", 378, "\"", 411, 2);
            WriteAttributeValue("", 385, "/product/index/", 385, 15, true);
#nullable restore
#line 17 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 400, product.Id, 400, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h5>");
#nullable restore
#line 18 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Home\Index.cshtml"
                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                </a>\r\n                <h5>");
#nullable restore
#line 20 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Home\Index.cshtml"
               Write(product.Cost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" руб </h5>\r\n                <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 568, "\"", 600, 2);
            WriteAttributeValue("", 575, "/Cart/AddItem/", 575, 14, true);
#nullable restore
#line 21 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 589, product.Id, 589, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">В корзину</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\ek\source\repos\OnlineStore\OnlainStore\OnlainStore\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
