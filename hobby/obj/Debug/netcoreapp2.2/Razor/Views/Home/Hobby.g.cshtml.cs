#pragma checksum "D:\coding_dojo\c_stack\hobby\Views\Home\Hobby.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "319fc8264844171a307f4b3d9e9cd08f09f8d729"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Hobby), @"mvc.1.0.view", @"/Views/Home/Hobby.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Hobby.cshtml", typeof(AspNetCore.Views_Home_Hobby))]
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
#line 1 "D:\coding_dojo\c_stack\hobby\Views\_ViewImports.cshtml"
using hobby;

#line default
#line hidden
#line 2 "D:\coding_dojo\c_stack\hobby\Views\_ViewImports.cshtml"
using hobby.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"319fc8264844171a307f4b3d9e9cd08f09f8d729", @"/Views/Home/Hobby.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87fb2f29b35343b41ca9c12802504d959011cdf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Hobby : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\coding_dojo\c_stack\hobby\Views\Home\Hobby.cshtml"
  
    ViewData["Title"] = "Hobby Hub";

#line default
#line hidden
            BeginContext(45, 233, true);
            WriteLiteral("\r\n\r\n\r\n<h1 class=\"text-center mt-5\">Hobbies</h1>\r\n<table class=\"table table-bordered mt-5\">\r\n   <thead>\r\n      <tr>\r\n         <th scope=\"col\">Name</th>\r\n         <th scope=\"col\">Enthusiasts</th>\r\n      </tr>\r\n   </thead>\r\n   <tbody>\r\n");
            EndContext();
#line 16 "D:\coding_dojo\c_stack\hobby\Views\Home\Hobby.cshtml"
       foreach(var hob in ViewBag.hobList)
      {

#line default
#line hidden
            BeginContext(331, 33, true);
            WriteLiteral("         <tr>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 364, "\"", 390, 2);
            WriteAttributeValue("", 371, "/Hobby/", 371, 7, true);
#line 19 "D:\coding_dojo\c_stack\hobby\Views\Home\Hobby.cshtml"
WriteAttributeValue("", 378, hob.HobbyId, 378, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(391, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(393, 8, false);
#line 19 "D:\coding_dojo\c_stack\hobby\Views\Home\Hobby.cshtml"
                                         Write(hob.Name);

#line default
#line hidden
            EndContext();
            BeginContext(401, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(425, 18, false);
#line 20 "D:\coding_dojo\c_stack\hobby\Views\Home\Hobby.cshtml"
           Write(hob.joinList.Count);

#line default
#line hidden
            EndContext();
            BeginContext(443, 23, true);
            WriteLiteral("</td>\r\n         </tr>\r\n");
            EndContext();
#line 22 "D:\coding_dojo\c_stack\hobby\Views\Home\Hobby.cshtml"
      }  

#line default
#line hidden
            BeginContext(477, 87, true);
            WriteLiteral("   </tbody>\r\n</table>\r\n<div>\r\n   <a href=\"/Hobby/New\"><u>Create a Hobby</u></a>\r\n</div>");
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
