#pragma checksum "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f63a4465f7c0edf675bef7297b299235815aeeb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_WorkOrder_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/WorkOrder/Index.cshtml")]
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
#line 3 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.UrgencyDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.AppUserDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.NotificationDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.PersonalDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.ReportDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Ysk.Todo.Dto.DTOs.TaskDto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f63a4465f7c0edf675bef7297b299235815aeeb2", @"/Areas/Admin/Views/WorkOrder/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aae44e06c044bee3df3805919b41d2accdbd09f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_WorkOrder_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TaskListAllDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssignPersonal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-hover table-sm mt-2 table-striped"">
        <tr>
            <th>Ad</th>
            <th>Açıklama</th>
            <th>Oluşturma Tarihi</th>
            <th>Çalışan Personel</th>
            <th>Aciliyet</th>
            <th>Rapor Sayısı</th>
            <th>İşlem</th>
        </tr>
");
#nullable restore
#line 19 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
       Write(item.CreatedDate.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n  \r\n");
#nullable restore
#line 27 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
             if (item.AppUser == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-danger\">- Çalışan Personel Yok -</span>\r\n");
#nullable restore
#line 30 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-success\">");
#nullable restore
#line 33 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
                                             Write(item.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" çalışıyor</span>\r\n");
#nullable restore
#line 34 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
       Write(item.Urgency.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
       Write(item.Reports.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n");
#nullable restore
#line 40 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
             if (item.AppUser == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f63a4465f7c0edf675bef7297b299235815aeeb29912", async() => {
                WriteLiteral("<i class=\"fas fa-caret-right mr-2\"></i> Personal Ata");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f63a4465f7c0edf675bef7297b299235815aeeb212577", async() => {
                WriteLiteral("<i class=\"fas fa-info-circle mr-2\"></i> Detay Göster");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
                                                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n    </tr>\r\n");
#nullable restore
#line 50 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 52 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"my-2 text-center lead\">\r\n        Herhangi bir görev bulunmamaktadır.\r\n    </div>\r\n");
#nullable restore
#line 58 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\WorkOrder\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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