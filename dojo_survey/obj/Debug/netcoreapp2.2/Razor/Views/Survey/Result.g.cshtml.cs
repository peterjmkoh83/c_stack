#pragma checksum "C:\Users\heidi\Desktop\c#\dojo_survey\Views\Survey\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be52a48ccfea52f559d0e478fe44b60d49a75a4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_Result), @"mvc.1.0.view", @"/Views/Survey/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Survey/Result.cshtml", typeof(AspNetCore.Views_Survey_Result))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be52a48ccfea52f559d0e478fe44b60d49a75a4f", @"/Views/Survey/Result.cshtml")]
    public class Views_Survey_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 428, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be52a48ccfea52f559d0e478fe44b60d49a75a4f2904", async() => {
                BeginContext(41, 415, true);
                WriteLiteral(@"
   <meta charset=""UTF-8"">
   <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
   <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
   <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
   <title>Dojo Survey Index</title>
");
                EndContext();
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
            EndContext();
            BeginContext(463, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(465, 832, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be52a48ccfea52f559d0e478fe44b60d49a75a4f4516", async() => {
                BeginContext(471, 212, true);
                WriteLiteral("\r\n   <div class=\"container\">\r\n      <h1 class=\"\"><u>Submitted Info</u></h1>\r\n      <div class=\"info\">\r\n         <div class=\"row\">\r\n            <div class=\"col-sm-4\">Name:</div>\r\n            <div class=\"col-sm-4\">");
                EndContext();
                BeginContext(684, 12, false);
#line 16 "C:\Users\heidi\Desktop\c#\dojo_survey\Views\Survey\Result.cshtml"
                             Write(ViewBag.name);

#line default
#line hidden
                EndContext();
                BeginContext(696, 143, true);
                WriteLiteral("</div>\r\n         </div>\r\n         <div class=\"row\">\r\n            <div class=\"col-sm-4\">Dojo Location:</div>\r\n            <div class=\"col-sm-4\">");
                EndContext();
                BeginContext(840, 16, false);
#line 20 "C:\Users\heidi\Desktop\c#\dojo_survey\Views\Survey\Result.cshtml"
                             Write(ViewBag.location);

#line default
#line hidden
                EndContext();
                BeginContext(856, 147, true);
                WriteLiteral("</div>\r\n         </div>\r\n         <div class=\"row\">\r\n            <div class=\"col-sm-4\">Favorite Language:</div>\r\n            <div class=\"col-sm-4\">");
                EndContext();
                BeginContext(1004, 16, false);
#line 24 "C:\Users\heidi\Desktop\c#\dojo_survey\Views\Survey\Result.cshtml"
                             Write(ViewBag.language);

#line default
#line hidden
                EndContext();
                BeginContext(1020, 137, true);
                WriteLiteral("</div>\r\n         </div>\r\n         <div class=\"row\">\r\n            <div class=\"col-sm-4\">Comment:</div>\r\n            <div class=\"col-sm-4\">");
                EndContext();
                BeginContext(1158, 15, false);
#line 28 "C:\Users\heidi\Desktop\c#\dojo_survey\Views\Survey\Result.cshtml"
                             Write(ViewBag.comment);

#line default
#line hidden
                EndContext();
                BeginContext(1173, 117, true);
                WriteLiteral("</div>\r\n         </div>\r\n      </div>\r\n      <br>\r\n      <a href=\"/\" class=\"btn btn-primary\">Go Back</a>\r\n   </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1297, 9, true);
            WriteLiteral("\r\n</html>");
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
