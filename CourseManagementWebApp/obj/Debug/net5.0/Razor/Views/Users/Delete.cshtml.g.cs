#pragma checksum "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Users\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a089149d7cd4b4a363257e0d2c4dc29f3802289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Delete), @"mvc.1.0.view", @"/Views/Users/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a089149d7cd4b4a363257e0d2c4dc29f3802289", @"/Views/Users/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edeafb549ef09d235b1f4e64b1768aeb93b5494e", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseManagementWebApp.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-blue-500 hover:text-blue-600"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Users\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""min-h-screen bg-gray-100 p-8"">
    <h1 class=""text-4xl font-bold text-red-600 mb-6"">Delete User</h1>

    <div class=""bg-white p-6 rounded-lg shadow-lg max-w-2xl mx-auto"">
        <h3 class=""text-xl font-semibold text-gray-800 mb-4"">Are you sure you want to delete this?</h3>

        <h4 class=""text-lg font-medium text-gray-800 mb-4"">User Information</h4>
        <hr class=""mb-6"" />

        <!-- User Information Display -->
        <dl class=""grid grid-cols-1 md:grid-cols-2 gap-4"">
            <div>
            <dt class=""font-medium text-gray-700"">Name</dt>
            <dd class=""text-gray-900"">");
#nullable restore
#line 20 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Users\Delete.cshtml"
                                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </div>\r\n    <div>\r\n        <dt class=\"font-medium text-gray-700\">Email</dt>\r\n        <dd class=\"text-gray-900\">");
#nullable restore
#line 24 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Users\Delete.cshtml"
                             Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </div>\r\n    <div>\r\n        <dt class=\"font-medium text-gray-700\">Password</dt>\r\n        <dd class=\"text-gray-900\">");
#nullable restore
#line 28 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Users\Delete.cshtml"
                             Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </div>\r\n    <div>\r\n        <dt class=\"font-medium text-gray-700\">Role</dt>\r\n        <dd class=\"text-gray-900\">");
#nullable restore
#line 32 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Users\Delete.cshtml"
                             Write(Html.DisplayFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </div>\r\n    <div>\r\n        <dt class=\"font-medium text-gray-700\">Phone</dt>\r\n        <dd class=\"text-gray-900\">");
#nullable restore
#line 36 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Users\Delete.cshtml"
                             Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </div>\r\n    <div>\r\n        <dt class=\"font-medium text-gray-700\">Address</dt>\r\n        <dd class=\"text-gray-900\">");
#nullable restore
#line 40 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Users\Delete.cshtml"
                             Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </div>\r\n    </dl>\r\n\r\n    <!-- Delete Form -->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a089149d7cd4b4a363257e0d2c4dc29f38022898588", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a089149d7cd4b4a363257e0d2c4dc29f38022898854", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 46 "C:\Users\saswa\source\repos\CourseManagementWebApp\CourseManagementWebApp\Views\Users\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        <div class=""flex justify-between items-center"">
            <input type=""submit"" value=""Delete"" class=""bg-red-600 text-white px-6 py-2 rounded-md hover:bg-red-700 focus:outline-none focus:ring-2 focus:ring-red-500 cursor-pointer"" />
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a089149d7cd4b4a363257e0d2c4dc29f380228910837", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseManagementWebApp.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
