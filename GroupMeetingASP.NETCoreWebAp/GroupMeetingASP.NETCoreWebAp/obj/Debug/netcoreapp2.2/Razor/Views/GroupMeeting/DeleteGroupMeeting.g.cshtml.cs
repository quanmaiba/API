#pragma checksum "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e0106dee8c5009c2281bf0f623975b48cfe05d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GroupMeeting_DeleteGroupMeeting), @"mvc.1.0.view", @"/Views/GroupMeeting/DeleteGroupMeeting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GroupMeeting/DeleteGroupMeeting.cshtml", typeof(AspNetCore.Views_GroupMeeting_DeleteGroupMeeting))]
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
#line 1 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\_ViewImports.cshtml"
using GroupMeetingASP.NETCoreWebAp;

#line default
#line hidden
#line 2 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\_ViewImports.cshtml"
using GroupMeetingASP.NETCoreWebAp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e0106dee8c5009c2281bf0f623975b48cfe05d7", @"/Views/GroupMeeting/DeleteGroupMeeting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89dd24a8bddd5a1a82d7908fd3d79ec154adb751", @"/Views/_ViewImports.cshtml")]
    public class Views_GroupMeeting_DeleteGroupMeeting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupMeetingASP.NETCoreWebAp.Models.GroupMeeting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteGroupMeeting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
  
    ViewData["Title"] = "DeleteGroupMeeting";

#line default
#line hidden
            BeginContext(113, 194, true);
            WriteLiteral("\r\n<h1>DeleteGroupMeeting</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>GroupMeeting</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(308, 38, false);
#line 15 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(346, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(410, 34, false);
#line 18 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(444, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(507, 47, false);
#line 21 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(554, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(618, 43, false);
#line 24 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(661, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(724, 56, false);
#line 27 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.GroupMeetingLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(780, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(844, 52, false);
#line 30 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayFor(model => model.GroupMeetingLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(896, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(959, 48, false);
#line 33 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.TeamLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1071, 44, false);
#line 36 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayFor(model => model.TeamLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1178, 47, false);
#line 39 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1289, 43, false);
#line 42 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1395, 52, false);
#line 45 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayNameFor(model => model.GroupMeetingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1511, 48, false);
#line 48 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\DeleteGroupMeeting.cshtml"
       Write(Html.DisplayFor(model => model.GroupMeetingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1597, 172, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0106dee8c5009c2281bf0f623975b48cfe05d710450", async() => {
                BeginContext(1635, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1718, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e0106dee8c5009c2281bf0f623975b48cfe05d710924", async() => {
                    BeginContext(1740, 12, true);
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
                BeginContext(1756, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1769, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupMeetingASP.NETCoreWebAp.Models.GroupMeeting> Html { get; private set; }
    }
}
#pragma warning restore 1591
