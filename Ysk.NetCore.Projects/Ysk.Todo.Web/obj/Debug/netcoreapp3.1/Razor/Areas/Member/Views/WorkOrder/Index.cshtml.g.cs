#pragma checksum "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99a0d79ae5e662a36438ae2ddabdd694fb8dc305"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_WorkOrder_Index), @"mvc.1.0.view", @"/Areas/Member/Views/WorkOrder/Index.cshtml")]
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
#line 3 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.UrgencyDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.AppUserDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.NotificationDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.PersonalDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.ReportDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.TaskDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99a0d79ae5e662a36438ae2ddabdd694fb8dc305", @"/Areas/Member/Views/WorkOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67b5286b5200917973d1fe62cca56240ae8136e0", @"/Areas/Member/Views/_ViewImports.cshtml")]
    public class Areas_Member_Views_WorkOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TaskListAllDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light btn-sm mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateReport", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(" \r\n");
#nullable restore
#line 3 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Member/Views/Shared/_MemberLayout.cshtml";
    int index = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
 foreach (var task in Model)
{
    index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card my-1\">\r\n        <h5 class=\"card-header\">");
#nullable restore
#line 14 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                           Write(task.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\"> <span class=\"text-danger\">Aciliyet Durumu :</span> ");
#nullable restore
#line 16 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                                                                                  Write(task.Urgency.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 17 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                            Write(task.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n            <p class=\"text-right\">\r\n");
#nullable restore
#line 21 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                 if (task.Reports.Count > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a class=\"btn btn-light btn-sm\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 675, "\"", 705, 2);
            WriteAttributeValue("", 682, "#collapseExample-", 682, 17, true);
#nullable restore
#line 23 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
WriteAttributeValue("", 699, index, 699, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\" aria-expanded=\"false\" aria-controls=\"collapseExample\">\r\n\r\n                        Raporlara Git <i class=\"fas fa-caret-down ml-2\"></i>\r\n                        <span class=\"badge badge-dark\">");
#nullable restore
#line 26 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                                                  Write(task.Reports.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n");
#nullable restore
#line 28 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span class=\"lead font-weight-bold font-italic d-block text-left mb-1\">\r\n                        Hiç rapor yazmamışsınız, görevinizdeki ilerlemelerinizden bahsedin.\r\n\r\n                    </span>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99a0d79ae5e662a36438ae2ddabdd694fb8dc3059913", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle mr-2\"></i> Rapor Yaz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                                                WriteLiteral(task.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                <a href=\"#\" class=\"btn btn-dark btn-sm\" data-toggle=\"modal\" data-target=\"#exampleModal\" data-id=\"");
#nullable restore
#line 39 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                                                                                                            Write(task.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    Tamamlandı olarak işaretle\r\n                </a>\r\n            </p>\r\n            <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1666, "\"", 1693, 2);
            WriteAttributeValue("", 1671, "collapseExample-", 1671, 16, true);
#nullable restore
#line 43 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
WriteAttributeValue("", 1687, index, 1687, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99a0d79ae5e662a36438ae2ddabdd694fb8dc30513646", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle mr-2\"></i> Rapor Yaz");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                                            WriteLiteral(task.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <table class=\"table table-hover table-bordered table-sm\">\r\n                    <tr>\r\n                        <th>Tanım</th>\r\n                        <th>Detay</th>\r\n                        <th>İşlem</th>\r\n                    </tr>\r\n");
#nullable restore
#line 51 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                     foreach (var report in task.Reports)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 54 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                           Write(report.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                           Write(report.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99a0d79ae5e662a36438ae2ddabdd694fb8dc30517336", async() => {
                WriteLiteral("<i class=\"far fa-edit mr-2\"></i> Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                                                               WriteLiteral(report.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 65 "C:\Users\aktur\Documents\GitHub\TodoJobWebApplication\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Member\Views\WorkOrder\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Modal -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">UYARI</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body text-center  lead"">
                Bu işlemi gerçekleştirmek istediğinizden emin misiniz?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Vazgeç</button>
                <button id=""btnSave"" type=""button"" class=""btn btn-primary"">Evet </button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#exampleModal"").on(""show.bs.modal"", function (event) {
                let tetikleyenElement = $(event.relatedTarget);
                let data = tetikleyenElement.data(""id"");
                $(""#btnSave"").click(function () {
                    $.ajax({
                        type: ""GET"",
                        contentType: ""application/json; charset=utf-8"",
                        url: ""./WorkOrder/CompleteTask"",
                        data: { taskId: data },
                        success: function () {
                            window.location.reload();
                        },
                        error: function (error) {
                            alert(error.responseText);
                        }
                    })
                })
            });
        });
    </script>

");
            }
            );
            WriteLiteral("\r\n");
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
