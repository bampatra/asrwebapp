#pragma checksum "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57cf82f5249eaf170aebd0be43abf2a9850f7708"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_MyBookings), @"mvc.1.0.view", @"/Views/Student/MyBookings.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/MyBookings.cshtml", typeof(AspNetCore.Views_Student_MyBookings))]
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
#line 1 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57cf82f5249eaf170aebd0be43abf2a9850f7708", @"/Views/Student/MyBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6287d22294d75c405c693e82ea6885eb37ec648", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_MyBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASRWebApp.Models.Slot>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(144, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
  
    ViewData["Title"] = "My Bookings";

#line default
#line hidden
            BeginContext(238, 26, true);
            WriteLiteral("\r\n<h2>My Bookings</h2>\r\n\r\n");
            EndContext();
#line 14 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
   if (ViewData["ErrorMessage"] != null)
    {

#line default
#line hidden
            BeginContext(313, 67, true);
            WriteLiteral("        <div class=\"alert alert-danger\" role=\"alert\">\r\n            ");
            EndContext();
            BeginContext(381, 24, false);
#line 17 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
       Write(ViewData["ErrorMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(405, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 19 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
    }
    if (ViewData["SuccessMessage"] != null)
    {

#line default
#line hidden
            BeginContext(482, 68, true);
            WriteLiteral("        <div class=\"alert alert-success\" role=\"alert\">\r\n            ");
            EndContext();
            BeginContext(551, 26, false);
#line 23 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
       Write(ViewData["SuccessMessage"]);

#line default
#line hidden
            EndContext();
            BeginContext(577, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 25 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
    }

#line default
#line hidden
            BeginContext(605, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(692, 40, false);
#line 32 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Room));

#line default
#line hidden
            EndContext();
            BeginContext(732, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(788, 41, false);
#line 35 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Staff));

#line default
#line hidden
            EndContext();
            BeginContext(829, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(885, 43, false);
#line 38 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.Student));

#line default
#line hidden
            EndContext();
            BeginContext(928, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(984, 45, false);
#line 41 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
           Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 88, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
            EndContext();
#line 48 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
         foreach (var item in Model)
        {
            if (item.StudentID == @UserManager.GetUserAsync(User).Result.StudentID)
            {

#line default
#line hidden
            BeginContext(1266, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1339, 46, false);
#line 54 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Room.RoomID));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1465, 48, false);
#line 57 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Staff.StaffID));

#line default
#line hidden
            EndContext();
            BeginContext(1513, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1593, 52, false);
#line 60 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Student.StudentID));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1725, 44, false);
#line 63 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(1769, 158, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n\r\n                        <button type=\"button\" class=\"btn btn-danger\">\r\n                            ");
            EndContext();
            BeginContext(1928, 139, false);
#line 69 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
                       Write(Html.ActionLink("Cancel Booking", "MyBookings", new { roomID = item.Room.RoomID, time = item.StartTime}, new { @style = "color:#ffffff;" }));

#line default
#line hidden
            EndContext();
            BeginContext(2067, 91, true);
            WriteLiteral("\r\n                        </button>\r\n\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 75 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Student/MyBookings.cshtml"
            }

        }

#line default
#line hidden
            BeginContext(2186, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASRWebApp.Models.Slot>> Html { get; private set; }
    }
}
#pragma warning restore 1591
