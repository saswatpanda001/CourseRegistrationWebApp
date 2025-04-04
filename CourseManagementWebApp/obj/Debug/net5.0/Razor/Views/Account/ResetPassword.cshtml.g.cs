#pragma checksum "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\ResetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d221a58d1619bd9cc00ce4f41d6d731d3bf2ae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ResetPassword), @"mvc.1.0.view", @"/Views/Account/ResetPassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d221a58d1619bd9cc00ce4f41d6d731d3bf2ae0", @"/Views/Account/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edeafb549ef09d235b1f4e64b1768aeb93b5494e", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResetPassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("space-y-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\ResetPassword.cshtml"
  
    ViewData["Title"] = "Reset Password";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""min-h-screen flex items-center justify-center bg-gradient-to-r from-blue-600 via-indigo-500 to-purple-600 p-8"">
    <div class=""bg-white shadow-2xl rounded-lg p-10 max-w-md w-full"">
        <h2 class=""text-3xl font-semibold text-center text-gray-800 mb-6"">Reset Your Password</h2>
        <p class=""text-center text-gray-600 mb-8"">Enter your email to reset your password</p>

        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d221a58d1619bd9cc00ce4f41d6d731d3bf2ae04946", async() => {
                WriteLiteral(@"
            <!-- Email -->
            <div>
                <label for=""email"" class=""block text-gray-700 font-medium"">Email</label>
                <input type=""email"" name=""Email"" required
                       class=""w-full px-5 py-3 border border-gray-300 rounded-lg focus:ring-4 focus:ring-teal-300 focus:border-teal-500 outline-none"">
            </div>

            <!-- New Password -->
            <div>
                <label for=""password"" class=""block text-gray-700 font-medium"">New Password</label>
                <input type=""password"" id=""password"" name=""Password"" required
                       class=""w-full px-5 py-3 border border-gray-300 rounded-lg focus:ring-4 focus:ring-teal-300 focus:border-teal-500 outline-none"">
            </div>

            <!-- Confirm Password -->
            <div>
                <label for=""confirmPassword"" class=""block text-gray-700 font-medium"">Confirm Password</label>
                <input type=""password"" id=""confirmPassword"" required
      ");
                WriteLiteral(@"                 class=""w-full px-5 py-3 border border-gray-300 rounded-lg focus:ring-4 focus:ring-teal-300 focus:border-teal-500 outline-none"">
                <p id=""passwordError"" class=""text-red-500 text-sm hidden"">Passwords do not match!</p>
            </div>

");
#nullable restore
#line 33 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\ResetPassword.cshtml"
             if (ViewBag.ErrorMessage != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p class=\"text-red-500 text-sm text-center\">");
#nullable restore
#line 35 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\ResetPassword.cshtml"
                                                       Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 36 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\ResetPassword.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\ResetPassword.cshtml"
             if (ViewBag.SuccessMessage != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p class=\"text-green-500 text-sm text-center\">");
#nullable restore
#line 40 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\ResetPassword.cshtml"
                                                         Write(ViewBag.SuccessMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 41 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\ResetPassword.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <button type=""submit"" onclick=""return validatePassword()""
                    class=""w-full bg-gradient-to-r from-teal-400 to-cyan-400 text-white py-3 rounded-lg hover:from-teal-500 hover:to-cyan-500 transition duration-200"">
                Reset Password
            </button>

            <p class=""text-center text-gray-600 mt-6"">Remembered your password? <a");
                BeginWriteAttribute("href", " href=\"", 2532, "\"", 2570, 1);
#nullable restore
#line 48 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Account\ResetPassword.cshtml"
WriteAttributeValue("", 2539, Url.Action("Login", "Account"), 2539, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"text-teal-500 font-semibold hover:text-teal-600 transition duration-200\">Login here</a></p>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<!-- Password Validation Script -->
<script>
    function validatePassword() {
        var password = document.getElementById(""password"").value;
        var confirmPassword = document.getElementById(""confirmPassword"").value;
        var errorText = document.getElementById(""passwordError"");

        if (password !== confirmPassword) {
            errorText.classList.remove(""hidden"");
            return false;
        } else {
            errorText.classList.add(""hidden"");
            return true;
        }
    }
</script>
");
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
