#pragma checksum "/Users/mackenzieslattery/Desktop/coding/coding-dojo/c#_stack/ProdCat/Views/Home/_Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfc21fba84bf5358c32bcb86fc71e0f6db33f330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__Products), @"mvc.1.0.view", @"/Views/Home/_Products.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_Products.cshtml", typeof(AspNetCore.Views_Home__Products))]
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
#line 1 "/Users/mackenzieslattery/Desktop/coding/coding-dojo/c#_stack/ProdCat/Views/_ViewImports.cshtml"
using ProdCat;

#line default
#line hidden
#line 2 "/Users/mackenzieslattery/Desktop/coding/coding-dojo/c#_stack/ProdCat/Views/_ViewImports.cshtml"
using ProdCat.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfc21fba84bf5358c32bcb86fc71e0f6db33f330", @"/Views/Home/_Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"548b9f04cec26944dfc7fa374e0037ba7cfc19c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 75, true);
            WriteLiteral("<h3 class=\"text-center\">Existing Products</h3>\n\n\n\n\n<ul class=\"list-group\">\n");
            EndContext();
#line 7 "/Users/mackenzieslattery/Desktop/coding/coding-dojo/c#_stack/ProdCat/Views/Home/_Products.cshtml"
   foreach (Product prod in ViewBag.AllProds)
{

#line default
#line hidden
            BeginContext(123, 32, true);
            WriteLiteral("  <li class=\"list-group-item\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 155, "\"", 178, 2);
            WriteAttributeValue("", 162, "/", 162, 1, true);
#line 9 "/Users/mackenzieslattery/Desktop/coding/coding-dojo/c#_stack/ProdCat/Views/Home/_Products.cshtml"
WriteAttributeValue("", 163, prod.ProductId, 163, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(179, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(181, 9, false);
#line 9 "/Users/mackenzieslattery/Desktop/coding/coding-dojo/c#_stack/ProdCat/Views/Home/_Products.cshtml"
                                                    Write(prod.Name);

#line default
#line hidden
            EndContext();
            BeginContext(190, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 10 "/Users/mackenzieslattery/Desktop/coding/coding-dojo/c#_stack/ProdCat/Views/Home/_Products.cshtml"
  
}

#line default
#line hidden
            BeginContext(205, 9, true);
            WriteLiteral("\n</ul>\n\n\n");
            EndContext();
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
