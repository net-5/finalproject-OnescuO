#pragma checksum "D:\visual studio\Conference\Conference\Views\Workshop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97c44abf269d13a17fac2b57d5dd3382cd3988c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Workshop_Index), @"mvc.1.0.view", @"/Views/Workshop/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Workshop/Index.cshtml", typeof(AspNetCore.Views_Workshop_Index))]
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
#line 1 "D:\visual studio\Conference\Conference\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "D:\visual studio\Conference\Conference\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97c44abf269d13a17fac2b57d5dd3382cd3988c8", @"/Views/Workshop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cbfddc5984994e8dad86012996c8394c90c1314", @"/Views/_ViewImports.cshtml")]
    public class Views_Workshop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Workshops>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\visual studio\Conference\Conference\Views\Workshop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 249, true);
            WriteLiteral("\r\n<div>\r\n    <section class=\"container\">\r\n        <div>\r\n            <h1 class=\"title mv container\">Workshops</h1>\r\n        </div>\r\n        <h1 class=\"text-center mv title\">Stay tuned! Workshops will be announced soon.</h1>\r\n    </section>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference.Domain.Entities.Workshops>> Html { get; private set; }
    }
}
#pragma warning restore 1591
