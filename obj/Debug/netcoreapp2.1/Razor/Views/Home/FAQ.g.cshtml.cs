#pragma checksum "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Home/FAQ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c41442f57f6f61261c0bd4f0574691a9e124255e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FAQ), @"mvc.1.0.view", @"/Views/Home/FAQ.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/FAQ.cshtml", typeof(AspNetCore.Views_Home_FAQ))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c41442f57f6f61261c0bd4f0574691a9e124255e", @"/Views/Home/FAQ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6287d22294d75c405c693e82ea6885eb37ec648", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FAQ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Home/FAQ.cshtml"
  
    ViewData["Title"] = "Frequently Asked Questions";

#line default
#line hidden
            BeginContext(62, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(69, 17, false);
#line 5 "/Users/BramanthaPatra/Documents/Google Drive/Uni/Year 3, Semester 2/WDT/Projects/ASRWebApp/ASRWebApp/Views/Home/FAQ.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(86, 8422, true);
            WriteLiteral(@"</h2>
<br />
<div class=""container"" style=""border:1px solid #cecece;"">
    <h3> Staff FAQ </h3>
    <div class=""panel-group"" id=""faqAccordion"">
        <div class=""panel panel-default "">
            <div class=""panel-heading accordion-toggle question-toggle collapsed"" data-toggle=""collapse"" data-parent=""#faqAccordion"" data-target=""#question0"">
                <h4 class=""panel-title"">
                    <a href=""#"" class=""ing"">Q: How do I check the room availabilty?</a>
                </h4>

            </div>
            <div id=""question0"" class=""panel-collapse collapse"" style=""height: 0px;"">
                <div class=""panel-body"">
                    <h5><span class=""label label-primary"">Answer</span></h5>

                    <p>
                        <ol>
                            <li>Click the <a href=""/room/"" class=""label label-success"">Room Availability</a> button from the main menu</li>
                            <li>Specify the date for availability from the drop down calen");
            WriteLiteral(@"dar</li>
                            <li>Click 'OK'</li>
                        </ol>
                    </p>
                </div>
            </div>
        </div>
        <div class=""panel panel-default "">
            <div class=""panel-heading accordion-toggle collapsed question-toggle"" data-toggle=""collapse"" data-parent=""#faqAccordion"" data-target=""#question1"">
                <h4 class=""panel-title"">
                    <a href=""#"" class=""ing"">Q: How do I create a slot?</a>
                </h4>

            </div>
            <div id=""question1"" class=""panel-collapse collapse"" style=""height: 0px;"">
                <div class=""panel-body"">
                    <h5><span class=""label label-primary"">Answer</span></h5>

                    <ol>
                        <li>Click the <a href=""/slot/create"" class=""label label-success"">Create a slot</a> button from the main menu</li>
                        <li>Pick a room from the drop down list</li>
                        <li>Enter the");
            WriteLiteral(@" date for the slot</li>
                        <li>Enter the time for the slot</li>
                        <li>Click 'OK'</li>
                    </ol>
                </div>
            </div>
        </div>
        <div class=""panel panel-default "">
            <div class=""panel-heading accordion-toggle collapsed question-toggle"" data-toggle=""collapse"" data-parent=""#faqAccordion"" data-target=""#question3"">
                <h4 class=""panel-title"">
                    <a href=""#"" class=""ing"">Q: Can I see the list of slots that I have created?</a>
                </h4>

            </div>
            <div id=""question3"" class=""panel-collapse collapse"" style=""height: 0px;"">
                <div class=""panel-body"">
                    <h5><span class=""label label-primary"">Answer</span></h5>
                    <ol>
                        <li>Click the <a href=""/slot/"" class=""label label-success"">My Booking Schedule</a> button from the main menu</li>
                        <li>You will be s");
            WriteLiteral(@"hown a list of slots that you have created</li>
                    </ol>
                    </div>
            </div>
        </div>
        <div class=""panel panel-default "">
            <div class=""panel-heading accordion-toggle collapsed question-toggle"" data-toggle=""collapse"" data-parent=""#faqAccordion"" data-target=""#question2"">
                <h4 class=""panel-title"">
                    <a href=""#"" class=""ing"">Q: How do I delete a slot?</a>
                </h4>

            </div>
            <div id=""question2"" class=""panel-collapse collapse"" style=""height: 0px;"">
                <div class=""panel-body"">
                    <h5><span class=""label label-primary"">Answer</span></h5>
                    <ol>
                        <li>Click the <a href=""/slot/"" class=""label label-success"">My Booking Schedule</a> button from the main menu</li>
                        <li>Select a slot</li>
                        <li>Click <a class=""label label-default"">Delete</a></li>
               ");
            WriteLiteral(@"     </ol>
                   </div>
            </div>
        </div>


    </div>
    </div>
<br />
    <div class=""container"" style=""border:1px solid #cecece;"">

    <h3> Student FAQ </h3>
    <div class=""panel-group"" id=""faqAccordion"">
        <div class=""panel panel-default "">
            <div class=""panel-heading accordion-toggle question-toggle collapsed"" data-toggle=""collapse"" data-parent=""#faqAccordion"" data-target=""#question4"">
                <h4 class=""panel-title"">
                    <a href=""#"" class=""ing"">Q: How do I check available slots?</a>
                </h4>

            </div>
            <div id=""question4"" class=""panel-collapse collapse"" style=""height: 0px;"">
                <div class=""panel-body"">
                    <h5><span class=""label label-primary"">Answer</span></h5>

                    <p>
                        <ol>
                            <li>Click the <a href=""/student/booking"" class=""label label-success"">Book a Slot</a> button from the mai");
            WriteLiteral(@"n menu</li>
                            <li>Select a slot</li>
                            <li>Click <a class=""label label-default"">Search</a></li>
                        </ol>
                    </p>
                </div>
            </div>
        </div>
        <div class=""panel panel-default "">
            <div class=""panel-heading accordion-toggle collapsed question-toggle"" data-toggle=""collapse"" data-parent=""#faqAccordion"" data-target=""#question5"">
                <h4 class=""panel-title"">
                    <a href=""#"" class=""ing"">Q: How do I book a slot?</a>
                </h4>

            </div>
            <div id=""question5"" class=""panel-collapse collapse"" style=""height: 0px;"">
                <div class=""panel-body"">
                    <h5><span class=""label label-primary"">Answer</span></h5>

                    <ol>
                        <li>Click the <a href=""/student/booking"" class=""label label-success"">Book a Slot</a> button from the main menu</li>
               ");
            WriteLiteral(@"         <li>Select a slot</li>
                        <li>Click <a class=""label label-default"">Search</a></li>
                        <li>Choose the slot you want to book, then click <a class=""label label-default"">Book Slot</a></li>
                    </ol>
                </div>
            </div>
        </div>
        <div class=""panel panel-default "">
            <div class=""panel-heading accordion-toggle collapsed question-toggle"" data-toggle=""collapse"" data-parent=""#faqAccordion"" data-target=""#question7"">
                <h4 class=""panel-title"">
                    <a href=""#"" class=""ing"">Q: Can I see the list of slots that I have booked?</a>
                </h4>

            </div>
            <div id=""question7"" class=""panel-collapse collapse"" style=""height: 0px;"">
                <div class=""panel-body"">
                    <h5><span class=""label label-primary"">Answer</span></h5>

                    <ol>
                        <li>Click the <a href=""/student/mybookings"" clas");
            WriteLiteral(@"s=""label label-success"">View My Bookings</a> button from the main menu</li>
                        <li>You will be shown a list of slots that you have booked</li>
                    </ol>
                   </div>
            </div>
        </div>
        <div class=""panel panel-default "">
            <div class=""panel-heading accordion-toggle collapsed question-toggle"" data-toggle=""collapse"" data-parent=""#faqAccordion"" data-target=""#question6"">
                <h4 class=""panel-title"">
                    <a href=""#"" class=""ing"">Q: How do I cancel a booking?</a>
                </h4>

            </div>
            <div id=""question6"" class=""panel-collapse collapse"" style=""height: 0px;"">
                <div class=""panel-body"">
                    <h5><span class=""label label-primary"">Answer</span></h5>

                    <ol>
                        <li>Click the <a href=""/student/mybookings"" class=""label label-success"">View My Bookings</a> button from the main menu</li>
              ");
            WriteLiteral("          <li>Choose the slot you want to book, then click <a class=\"label label-danger\">Cancel Booking</a></li>\r\n                    </ol>\r\n                     </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n</div>\r\n");
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
