#pragma checksum "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Room/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e871b1d34b84af052cb14dde642e52e3d521d92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Room_Index), @"mvc.1.0.view", @"/Views/Room/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Room/Index.cshtml", typeof(AspNetCore.Views_Room_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e871b1d34b84af052cb14dde642e52e3d521d92", @"/Views/Room/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6287d22294d75c405c693e82ea6885eb37ec648", @"/Views/_ViewImports.cshtml")]
    public class Views_Room_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASRWebApp.Models.SlotAndRoom>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Room", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Room/Index.cshtml"
  
    ViewData["Title"] = "List of Rooms";

#line default
#line hidden
            BeginContext(137, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(166, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0952c0848a074fff84e73bd441dd2311", async() => {
                BeginContext(189, 10, true);
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
            BeginContext(203, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
            BeginContext(213, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b9bc0296eae4e19a25a22ca995f69c4", async() => {
                BeginContext(260, 124, true);
                WriteLiteral("\r\n    <p>\r\n        Date: <input type=\"date\" name=\"SearchString\">\r\n        <input type=\"submit\" value=\"Search\" />\r\n    </p>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(391, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 22 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Room/Index.cshtml"
  
    if(ViewData["FromDate"] != null)
    {

#line default
#line hidden
            BeginContext(444, 40, true);
            WriteLiteral("        <h2> List of Available Rooms on ");
            EndContext();
            BeginContext(486, 52, false);
#line 25 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Room/Index.cshtml"
                                    Write(((DateTime)ViewData["FromDate"]).ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(539, 6, true);
            WriteLiteral("</h2>\n");
            EndContext();
#line 26 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Room/Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(568, 54, true);
            WriteLiteral("        <h2> Pick a date to see available rooms </h2>\n");
            EndContext();
#line 30 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Room/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(632, 74, true);
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n");
            EndContext();
            BeginContext(770, 87, true);
            WriteLiteral("                RoomID\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
            EndContext();
#line 46 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Room/Index.cshtml"
           if (ViewData["FromDate"] != null)
            {
                int roomCount = 0;
                foreach (var room in Model.Rooms)
                {
                    foreach (var slot in Model.Slots)
                    {
                        if ((DateTime)ViewData["FromDate"] <= slot.StartTime &&
                            slot.StartTime <= (DateTime)ViewData["ToDate"] &&
                            room.RoomID == slot.RoomID)
                        {
                            roomCount += 1;
                        }

                    }

                    if (roomCount < 2)
                    {

#line default
#line hidden
            BeginContext(1508, 98, true);
            WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1607, 41, false);
#line 67 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Room/Index.cshtml"
                           Write(Html.DisplayFor(modelItem => room.RoomID));

#line default
#line hidden
            EndContext();
            BeginContext(1648, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 70 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Room/Index.cshtml"
                    }

                    roomCount = 0;
                }
            }
        

#line default
#line hidden
            BeginContext(1822, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASRWebApp.Models.SlotAndRoom> Html { get; private set; }
    }
}
#pragma warning restore 1591
