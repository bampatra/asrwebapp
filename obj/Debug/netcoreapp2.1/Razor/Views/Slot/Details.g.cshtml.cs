#pragma checksum "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Slot/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3faa640b9aeaec4d0a44c89d7e503e16858dcbc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Slot_Details), @"mvc.1.0.view", @"/Views/Slot/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Slot/Details.cshtml", typeof(AspNetCore.Views_Slot_Details))]
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
#line 1 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/_ViewImports.cshtml"
using ASRWebApp;

#line default
#line hidden
#line 2 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/_ViewImports.cshtml"
using ASRWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3faa640b9aeaec4d0a44c89d7e503e16858dcbc5", @"/Views/Slot/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6287d22294d75c405c693e82ea6885eb37ec648", @"/Views/_ViewImports.cshtml")]
    public class Views_Slot_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASRWebApp.Models.Slot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Slot/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(75, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Slot</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(194, 40, false);
#line 14 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Slot/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Room));

#line default
#line hidden
            EndContext();
            BeginContext(234, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(278, 43, false);
#line 17 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Slot/Details.cshtml"
       Write(Html.DisplayFor(model => model.Room.RoomID));

#line default
#line hidden
            EndContext();
            BeginContext(321, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(365, 41, false);
#line 20 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Slot/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Staff));

#line default
#line hidden
            EndContext();
            BeginContext(406, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(450, 45, false);
#line 23 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Slot/Details.cshtml"
       Write(Html.DisplayFor(model => model.Staff.StaffID));

#line default
#line hidden
            EndContext();
            BeginContext(495, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(539, 43, false);
#line 26 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Slot/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Student));

#line default
#line hidden
            EndContext();
            BeginContext(582, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(626, 49, false);
#line 29 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Slot/Details.cshtml"
       Write(Html.DisplayFor(model => model.Student.StudentID));

#line default
#line hidden
            EndContext();
            BeginContext(675, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(723, 68, false);
#line 34 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Slot/Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(791, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(799, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "788e53b54441493b889296b33dbc9e5e", async() => {
                BeginContext(821, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(837, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASRWebApp.Models.Slot> Html { get; private set; }
    }
}
#pragma warning restore 1591
