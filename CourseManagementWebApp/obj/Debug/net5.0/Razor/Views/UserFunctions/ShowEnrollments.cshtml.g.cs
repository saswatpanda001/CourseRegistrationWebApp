#pragma checksum "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\UserFunctions\ShowEnrollments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b5146a549baff65394ea9155e231932731c9fb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserFunctions_ShowEnrollments), @"mvc.1.0.view", @"/Views/UserFunctions/ShowEnrollments.cshtml")]
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
#nullable restore
#line 1 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\_ViewImports.cshtml"
using CourseManagementWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\_ViewImports.cshtml"
using CourseManagementWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b5146a549baff65394ea9155e231932731c9fb7", @"/Views/UserFunctions/ShowEnrollments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edeafb549ef09d235b1f4e64b1768aeb93b5494e", @"/Views/_ViewImports.cshtml")]
    public class Views_UserFunctions_ShowEnrollments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseManagementWebApp.Models.Enrollment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete this enrollment?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\UserFunctions\ShowEnrollments.cshtml"
  
    ViewData["Title"] = "My Enrollments";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-4xl font-semibold text-center my-8 text-gray-800"">My Enrollments</h1>

<div class=""overflow-x-auto px-4"">
    <table class=""min-w-full table-auto border-collapse bg-white rounded-lg shadow-lg overflow-hidden"">
        <thead class=""bg-gradient-to-r from-indigo-500 to-purple-600 text-white"">
            <tr>
                <th class=""px-6 py-3 text-left text-sm font-medium uppercase tracking-wider"">Course Name</th>
                <th class=""px-6 py-3 text-left text-sm font-medium uppercase tracking-wider"">Enrollment Date</th>
                <th class=""px-6 py-3 text-left text-sm font-medium uppercase tracking-wider"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 19 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\UserFunctions\ShowEnrollments.cshtml"
             foreach (var enrollment in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"transition duration-200 hover:bg-gray-100\">\r\n                    <td class=\"px-6 py-4 text-sm font-medium text-gray-800 border-b border-gray-200\">");
#nullable restore
#line 22 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\UserFunctions\ShowEnrollments.cshtml"
                                                                                                Write(enrollment.Course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"px-6 py-4 text-sm text-gray-600 border-b border-gray-200\">");
#nullable restore
#line 23 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\UserFunctions\ShowEnrollments.cshtml"
                                                                                    Write(enrollment.EnrollmentDate.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"px-6 py-4 text-sm font-medium border-b border-gray-200\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b5146a549baff65394ea9155e231932731c9fb76888", async() => {
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"text-red-500 hover:text-red-700 transition duration-200 p-2 rounded-lg hover:bg-red-100\">Delete</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\UserFunctions\ShowEnrollments.cshtml"
                                                                  WriteLiteral(enrollment.EnrollmentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\UserFunctions\ShowEnrollments.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseManagementWebApp.Models.Enrollment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
