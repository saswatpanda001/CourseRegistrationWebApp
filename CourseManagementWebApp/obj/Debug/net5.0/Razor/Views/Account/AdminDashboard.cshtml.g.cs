#pragma checksum "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\AdminDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "479d513fa6e9dd20905dc13f7b43dc7c71a6e9ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AdminDashboard), @"mvc.1.0.view", @"/Views/Account/AdminDashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"479d513fa6e9dd20905dc13f7b43dc7c71a6e9ae", @"/Views/Account/AdminDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edeafb549ef09d235b1f4e64b1768aeb93b5494e", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AdminDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\AdminDashboard.cshtml"
  
    ViewData["Title"] = "AdminDashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""min-h-screen bg-gradient-to-r from-blue-500 to-teal-500 p-6"">
    <div class=""max-w-7xl mx-auto px-6 py-12 space-y-12"">
        <!-- Page Header -->
        <div class=""text-center mb-8"">
            <h1 class=""text-4xl font-extrabold text-white"">Admin Dashboard</h1>
            <p class=""text-xl text-gray-200 mt-2"">Manage your platform with ease and insight</p>
        </div>

        <!-- Dashboard Statistics Cards -->
        <div class=""grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 gap-8"">
            <!-- Total Users Card -->
            <div class=""bg-white p-8 rounded-xl shadow-2xl transform hover:scale-105 transition-all"">
                <h2 class=""text-2xl font-semibold text-gray-800"">Total Users</h2>
                <p class=""text-4xl font-extrabold text-indigo-600 mt-4"">");
#nullable restore
#line 18 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\AdminDashboard.cshtml"
                                                                   Write(ViewBag.TotalUsers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <p class=""text-gray-500 mt-2"">Total number of registered users.</p>
            </div>

            <!-- Total Services Card -->
            <div class=""bg-white p-8 rounded-xl shadow-2xl transform hover:scale-105 transition-all"">
                <h2 class=""text-2xl font-semibold text-gray-800"">Total Services</h2>
                <p class=""text-4xl font-extrabold text-teal-600 mt-4"">");
#nullable restore
#line 25 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\AdminDashboard.cshtml"
                                                                 Write(ViewBag.TotalCourses);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <p class=""text-gray-500 mt-2"">Total services offered by the platform.</p>
            </div>

            <!-- Total Appointments Card -->
            <div class=""bg-white p-8 rounded-xl shadow-2xl transform hover:scale-105 transition-all"">
                <h2 class=""text-2xl font-semibold text-gray-800"">Total Appointments</h2>
                <p class=""text-4xl font-extrabold text-purple-600 mt-4"">");
#nullable restore
#line 32 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\AdminDashboard.cshtml"
                                                                   Write(ViewBag.TotalEnrollments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"text-gray-500 mt-2\">Number of appointments booked by users.</p>\r\n            </div>\r\n        </div>\r\n\r\n        \r\n    </div>\r\n</div>\r\n");
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
