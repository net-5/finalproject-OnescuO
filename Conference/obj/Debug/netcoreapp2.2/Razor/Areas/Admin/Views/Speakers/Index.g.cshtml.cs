#pragma checksum "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "628261e48bc3b152c91d29c6a0f30c8dd7a6a95c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Speakers_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Speakers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Speakers/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Speakers_Index))]
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
#line 1 "D:\visual studio\Conference\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "D:\visual studio\Conference\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"628261e48bc3b152c91d29c6a0f30c8dd7a6a95c", @"/Areas/Admin/Views/Speakers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aba23b7bcde9ad4e5a8f26a94a35a59dc059ad2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Speakers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Speakers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(176, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "628261e48bc3b152c91d29c6a0f30c8dd7a6a95c3955", async() => {
                BeginContext(199, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(213, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(306, 44, false);
#line 17 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(350, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(406, 38, false);
#line 20 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(444, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(500, 45, false);
#line 23 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(545, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(601, 44, false);
#line 26 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(645, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(701, 44, false);
#line 29 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(745, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(801, 43, false);
#line 32 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(844, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(900, 44, false);
#line 35 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(944, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1000, 41, false);
#line 38 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1097, 44, false);
#line 41 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LinkedIn));

#line default
#line hidden
            EndContext();
            BeginContext(1141, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1197, 41, false);
#line 44 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Skype));

#line default
#line hidden
            EndContext();
            BeginContext(1238, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1294, 42, false);
#line 47 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GitHub));

#line default
#line hidden
            EndContext();
            BeginContext(1336, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1392, 43, false);
#line 50 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(1435, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1491, 47, false);
#line 53 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1594, 50, false);
#line 56 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyWebsite));

#line default
#line hidden
            EndContext();
            BeginContext(1644, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1700, 47, false);
#line 59 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1803, 44, false);
#line 62 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(1847, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1903, 43, false);
#line 65 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1946, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 71 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(2064, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2113, 43, false);
#line 74 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(2156, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2212, 37, false);
#line 77 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2249, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2305, 44, false);
#line 80 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2349, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2405, 43, false);
#line 83 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2448, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2504, 43, false);
#line 86 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
            EndContext();
            BeginContext(2547, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2603, 42, false);
#line 89 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Website));

#line default
#line hidden
            EndContext();
            BeginContext(2645, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2701, 43, false);
#line 92 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(2744, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2800, 40, false);
#line 95 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2840, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2896, 43, false);
#line 98 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LinkedIn));

#line default
#line hidden
            EndContext();
            BeginContext(2939, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2995, 40, false);
#line 101 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Skype));

#line default
#line hidden
            EndContext();
            BeginContext(3035, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3091, 41, false);
#line 104 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GitHub));

#line default
#line hidden
            EndContext();
            BeginContext(3132, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3188, 42, false);
#line 107 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(3230, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3286, 46, false);
#line 110 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(3332, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3388, 49, false);
#line 113 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompanyWebsite));

#line default
#line hidden
            EndContext();
            BeginContext(3437, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3493, 46, false);
#line 116 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3539, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3595, 43, false);
#line 119 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(3638, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3694, 42, false);
#line 122 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(3736, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3792, 51, false);
#line 125 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3843, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3864, 57, false);
#line 126 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3921, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3942, 55, false);
#line 127 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id=item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(3997, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 130 "D:\visual studio\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4036, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference.Domain.Entities.Speakers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
