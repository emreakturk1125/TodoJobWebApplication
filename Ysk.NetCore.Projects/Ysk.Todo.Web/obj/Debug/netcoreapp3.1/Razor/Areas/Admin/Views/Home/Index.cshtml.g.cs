#pragma checksum "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51d147416a07ba5338f808990da7de885ecb73f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51d147416a07ba5338f808990da7de885ecb73f", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aae44e06c044bee3df3805919b41d2accdbd09f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Notification", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WorkOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-3"">

    <div class=""col-md-3"">
        <div class=""card border-success mb-3"" style=""max-width: 18rem;"">
            <div class=""card-body text-center text-success"">
                <h5 class=""card-title"">Tamamlanmış Görev Sayısı</h5>
");
#nullable restore
#line 13 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                 if (ViewBag.CompletedTaskCount > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-5\">");
#nullable restore
#line 15 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                                              Write(ViewBag.CompletedTaskCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-5\">\r\n                        Görev tamamlanmamıştır.\r\n                    </p>\r\n");
#nullable restore
#line 23 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>


    <div class=""col-md-3"">
        <div class=""card border-danger mb-3"" style=""max-width: 18rem;"">
            <div class=""card-body text-center text-danger"">
                <h5 class=""card-title"">Okunmamış Bildirim Sayısı</h5>
");
#nullable restore
#line 33 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                 if (ViewBag.UnreadNotificationCount > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-5\">");
#nullable restore
#line 35 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                                              Write(ViewBag.UnreadNotificationCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p");
            BeginWriteAttribute("class", " class=\"", 1209, "\"", 1217, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b51d147416a07ba5338f808990da7de885ecb73f9007", async() => {
                WriteLiteral("<i class=\"fas fa-chevron-circle-right\"></i> İncele");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 39 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-5\">\r\n                        Bildirimler görüldü.\r\n                    </p>\r\n");
#nullable restore
#line 45 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>

    <div class=""col-md-3"">
        <div class=""card border-warning mb-3"" style=""max-width: 18rem;"">
            <div class=""card-body text-center"">
                <h5 class=""card-title"">Toplam Rapor Sayısı</h5>
");
#nullable restore
#line 54 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                 if (ViewBag.TotalReportsCount > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-5\">");
#nullable restore
#line 56 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                                              Write(ViewBag.TotalReportsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 57 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-5\">\r\n                        Rapor yazılmamıştır.\r\n                    </p>\r\n");
#nullable restore
#line 63 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>

    <div class=""col-md-3"">
        <div class=""card border-info mb-3"" style=""max-width: 18rem;"">
            <div class=""card-body text-center text-info"">
                <h5 class=""card-title"">Atanmayı Bekleyen Görev Sayısı</h5>
");
#nullable restore
#line 72 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                 if (ViewBag.PendingAssignmentTaskCount > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-5\">");
#nullable restore
#line 74 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                                              Write(ViewBag.PendingAssignmentTaskCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p");
            BeginWriteAttribute("class", " class=\"", 2717, "\"", 2725, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b51d147416a07ba5338f808990da7de885ecb73f14008", async() => {
                WriteLiteral("<i class=\"fas fa-chevron-circle-right\"></i> İncele");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </p>\r\n");
#nullable restore
#line 78 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"card-text display-5\">\r\n                        Görev bulunmamaktadır.\r\n                    </p>\r\n");
#nullable restore
#line 84 "C:\Users\aktur\source\repos\Ysk.NetCore.Projects\Ysk.NetCore.Projects\Ysk.Todo.Web\Areas\Admin\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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