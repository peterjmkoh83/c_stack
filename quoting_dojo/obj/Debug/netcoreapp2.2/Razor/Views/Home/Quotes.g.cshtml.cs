#pragma checksum "D:\coding_dojo\c_stack\quoting_dojo\Views\Home\Quotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d831f35b60fd9f91880d94c408379f330ab385a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Quotes), @"mvc.1.0.view", @"/Views/Home/Quotes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Quotes.cshtml", typeof(AspNetCore.Views_Home_Quotes))]
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
#line 1 "D:\coding_dojo\c_stack\quoting_dojo\Views\_ViewImports.cshtml"
using quoting_dojo;

#line default
#line hidden
#line 2 "D:\coding_dojo\c_stack\quoting_dojo\Views\_ViewImports.cshtml"
using quoting_dojo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d831f35b60fd9f91880d94c408379f330ab385a8", @"/Views/Home/Quotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8befaa81ee46489c12f9a4c1c5bac316dfc787f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Quotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 41, true);
            WriteLiteral("<h1>Here are the awesome quotes!</h1>\r\n\r\n");
            EndContext();
#line 3 "D:\coding_dojo\c_stack\quoting_dojo\Views\Home\Quotes.cshtml"
 foreach(var quote in ViewBag.Quotes){

#line default
#line hidden
            BeginContext(81, 23, true);
            WriteLiteral("    <div>\r\n        <p>\"");
            EndContext();
            BeginContext(105, 14, false);
#line 5 "D:\coding_dojo\c_stack\quoting_dojo\Views\Home\Quotes.cshtml"
       Write(quote["Quote"]);

#line default
#line hidden
            EndContext();
            BeginContext(119, 22, true);
            WriteLiteral("\"</p>\r\n        <cite>-");
            EndContext();
            BeginContext(142, 13, false);
#line 6 "D:\coding_dojo\c_stack\quoting_dojo\Views\Home\Quotes.cshtml"
          Write(quote["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(155, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(160, 19, false);
#line 6 "D:\coding_dojo\c_stack\quoting_dojo\Views\Home\Quotes.cshtml"
                            Write(quote["created_at"]);

#line default
#line hidden
            EndContext();
            BeginContext(179, 31, true);
            WriteLiteral("</cite>\r\n    </div>\r\n    <hr>\r\n");
            EndContext();
#line 9 "D:\coding_dojo\c_stack\quoting_dojo\Views\Home\Quotes.cshtml"
}

#line default
#line hidden
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
