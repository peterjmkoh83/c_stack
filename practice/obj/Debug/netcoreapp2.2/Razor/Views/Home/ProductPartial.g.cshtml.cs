#pragma checksum "C:\Users\heidi\Desktop\c#\practice\Views\Home\ProductPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96c5d517870d71faab09868a19319cf3dc58ac46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_ProductPartial), @"mvc.1.0.view", @"/Views/Home/ProductPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ProductPartial.cshtml", typeof(MyApp.Namespace.Home.Views_Home_ProductPartial))]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96c5d517870d71faab09868a19319cf3dc58ac46", @"/Views/Home/ProductPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1d1eb37dc6f0d82250bf784d7ea6a0b75ca51c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 12, true);
            WriteLiteral("\r\n<h1>Name: ");
            EndContext();
            BeginContext(29, 17, false);
#line 3 "C:\Users\heidi\Desktop\c#\practice\Views\Home\ProductPartial.cshtml"
     Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(46, 18, true);
            WriteLiteral("</h1>\r\n<h1>Price: ");
            EndContext();
            BeginContext(65, 11, false);
#line 4 "C:\Users\heidi\Desktop\c#\practice\Views\Home\ProductPartial.cshtml"
      Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(76, 5, true);
            WriteLiteral("</h1>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
