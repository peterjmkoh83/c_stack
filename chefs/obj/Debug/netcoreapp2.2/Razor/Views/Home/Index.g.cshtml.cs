#pragma checksum "C:\Users\heidi\Desktop\c#\chefs\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef41467d70aa2bc2c83f57e99fb80054d3ec1124"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef41467d70aa2bc2c83f57e99fb80054d3ec1124", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e48cde6fe9d6b0166474b29ec00895602273412", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\heidi\Desktop\c#\chefs\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Chef 'N Dishes'";

#line default
#line hidden
            BeginContext(51, 628, true);
            WriteLiteral(@"

<div class=""container mt-5"">
    <a class=""float-right mt-4"" href=""/new""><u>Add a Chef</u></a>
    <div class=""row"">
        <div class=""display-4 col-5 text-center"">Chefs</div>
        <div class=""display-4 col-5 text-center""><a href=""/dishes"">Dishes</a></div>
    </div>
    <h1 class=""mt-5"">Check out our roster of Chefs!</h1>
    <hr>
    <div>
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Age</th>
                    <th># of Dishes</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 24 "C:\Users\heidi\Desktop\c#\chefs\Views\Home\Index.cshtml"
                 foreach(var i in ViewBag.chefs)
                {

#line default
#line hidden
            BeginContext(748, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(803, 11, false);
#line 27 "C:\Users\heidi\Desktop\c#\chefs\Views\Home\Index.cshtml"
                       Write(i.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(814, 104, true);
            WriteLiteral("</td>\r\n                        <td></td>\r\n                        <td></td>\r\n                    </tr>\r\n");
            EndContext();
#line 31 "C:\Users\heidi\Desktop\c#\chefs\Views\Home\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(939, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
