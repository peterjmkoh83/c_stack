#pragma checksum "C:\Users\heidi\Desktop\c#\chefs\Views\Home\DishList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e478dfdb94b6638afcf16add7ed5dd26a9c4f8de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DishList), @"mvc.1.0.view", @"/Views/Home/DishList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DishList.cshtml", typeof(AspNetCore.Views_Home_DishList))]
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
#line 1 "C:\Users\heidi\Desktop\c#\chefs\Views\_ViewImports.cshtml"
using chefs;

#line default
#line hidden
#line 2 "C:\Users\heidi\Desktop\c#\chefs\Views\_ViewImports.cshtml"
using chefs.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e478dfdb94b6638afcf16add7ed5dd26a9c4f8de", @"/Views/Home/DishList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e48cde6fe9d6b0166474b29ec00895602273412", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DishList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\heidi\Desktop\c#\chefs\Views\Home\DishList.cshtml"
  
    ViewData["Title"] = "Chef 'N Dishes'";

#line default
#line hidden
            BeginContext(51, 899, true);
            WriteLiteral(@"
<div class=""container mt-5"">
    <a class=""float-right mt-4"" href=""/dishes/new""><u>Add a Dish</u></a>
    <div class=""row"">
        <div class=""display-4 col-5 text-center""><a href=""/"">Chefs</a></div>
        <div class=""display-4 col-5 text-center"">Dishes</div>
    </div>
    <h1 class=""mt-5"">Yum, take a look at our tasty dishes!</h1>
    <hr>
    <div>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Chef</th>
                    <th>Tastiness</th>
                    <th>Calories</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </tbody>
        </table>
    </div>
</div>");
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
