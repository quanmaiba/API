#pragma checksum "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e310474a6a0a165cc09d09143c684907b3e432c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GroupMeeting_GroupMeetingDetails), @"mvc.1.0.view", @"/Views/GroupMeeting/GroupMeetingDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GroupMeeting/GroupMeetingDetails.cshtml", typeof(AspNetCore.Views_GroupMeeting_GroupMeetingDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e310474a6a0a165cc09d09143c684907b3e432c6", @"/Views/GroupMeeting/GroupMeetingDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89dd24a8bddd5a1a82d7908fd3d79ec154adb751", @"/Views/_ViewImports.cshtml")]
    public class Views_GroupMeeting_GroupMeetingDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupMeetingASP.NETCoreWebAp.Models.GroupMeeting>
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
  
    ViewData["Title"] = "GroupMeetingDetails";

#line default
#line hidden
            BeginContext(114, 147, true);
            WriteLiteral("\r\n<h1>GroupMeetingDetails</h1>\r\n\r\n<div>\r\n    <h4>GroupMeeting</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(262, 38, false);
#line 14 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(300, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(364, 34, false);
#line 17 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(398, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(461, 47, false);
#line 20 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(508, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(572, 43, false);
#line 23 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(615, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(678, 56, false);
#line 26 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.GroupMeetingLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(734, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(798, 52, false);
#line 29 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayFor(model => model.GroupMeetingLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(850, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(913, 48, false);
#line 32 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.TeamLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(961, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1025, 44, false);
#line 35 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayFor(model => model.TeamLeadName));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1132, 47, false);
#line 38 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1243, 43, false);
#line 41 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1286, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1349, 52, false);
#line 44 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.GroupMeetingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1401, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1465, 48, false);
#line 47 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
       Write(Html.DisplayFor(model => model.GroupMeetingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1513, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1561, 84, false);
#line 52 "D:\Module 2\API\GroupMeetingASP.NETCoreWebAp\GroupMeetingASP.NETCoreWebAp\Views\GroupMeeting\GroupMeetingDetails.cshtml"
Write(Html.ActionLink("Edit", "UpdateGroupMeeting", "GroupMeeting", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 7, true);
            WriteLiteral("|\r\n    ");
            EndContext();
            BeginContext(1652, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e310474a6a0a165cc09d09143c684907b3e432c610273", async() => {
                BeginContext(1674, 12, true);
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
            BeginContext(1690, 10, true);
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