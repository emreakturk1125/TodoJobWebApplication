#pragma checksum "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cd6024059af649275af83d611783518d23e79d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Task_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Task/Index.cshtml")]
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
#line 3 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.UrgencyDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.AppUserDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.NotificationDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.PersonalDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.ReportDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.TaskDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cd6024059af649275af83d611783518d23e79d6", @"/Areas/Member/Views/Task/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67b5286b5200917973d1fe62cca56240ae8136e0", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_Task_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TaskListAllDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;
    int activepage = ViewBag.ActivePage;
    int totalpage = ViewBag.TotalPage;
    int next = activepage + 1;
    int previous = activepage - 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n");
#nullable restore
#line 12 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
 foreach (var task in Model)
{
    index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card my-1\">\r\n        <h5 class=\"card-header\">");
#nullable restore
#line 16 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                           Write(task.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\"> <span class=\"text-danger\">Aciliyet Durumu :</span> ");
#nullable restore
#line 18 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                                                                                  Write(task.Urgency.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                            Write(task.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n            <p class=\"text-right\">\r\n");
#nullable restore
#line 23 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                 if (task.Reports.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-light btn-sm\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 821, "\"", 851, 2);
            WriteAttributeValue("", 828, "#collapseExample-", 828, 17, true);
#nullable restore
#line 25 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
WriteAttributeValue("", 845, index, 845, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n\r\n                        Raporlara Git <i class=\"fas fa-caret-down ml-2\"></i>\r\n                        <span class=\"badge badge-dark\">");
#nullable restore
#line 28 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                                                  Write(task.Reports.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n");
#nullable restore
#line 30 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  \r\n            </p>\r\n            <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1202, "\"", 1229, 2);
            WriteAttributeValue("", 1207, "collapseExample-", 1207, 16, true);
#nullable restore
#line 33 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
WriteAttributeValue("", 1223, index, 1223, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> \r\n                <table class=\"table table-hover table-bordered table-sm\">\r\n                    <tr>\r\n                        <th>Tanım</th>\r\n                        <th>Detay</th> \r\n                    </tr>\r\n");
#nullable restore
#line 39 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                     foreach (var report in task.Reports)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                           Write(report.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                           Write(report.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n<nav aria-label=\"Page navigation example\" class=\"float-right\">\r\n    <ul class=\"pagination\">\r\n");
#nullable restore
#line 56 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
         if (previous > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cd6024059af649275af83d611783518d23e79d611359", async() => {
                WriteLiteral("\r\n                    <span aria-hidden=\"true\">&laquo;</span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activePage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                                                                  WriteLiteral(previous);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activePage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 63 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
         for (int i = 1; i <= ViewBag.TotalPage; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 2260, "\"", 2314, 2);
            WriteAttributeValue("", 2268, "page-item", 2268, 9, true);
#nullable restore
#line 67 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
WriteAttributeValue(" ", 2277, ViewBag.ActivePage==i?"active":"", 2278, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cd6024059af649275af83d611783518d23e79d614873", async() => {
#nullable restore
#line 68 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                                                                             Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activePage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 68 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                                                                  WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activePage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 70 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 72 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
         if (next <= totalpage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cd6024059af649275af83d611783518d23e79d618047", async() => {
                WriteLiteral("\r\n                    <span aria-hidden=\"true\">&raquo;</span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-activePage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
                                                                  WriteLiteral(next);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-activePage", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["activePage"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 79 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\Task\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TaskListAllDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591