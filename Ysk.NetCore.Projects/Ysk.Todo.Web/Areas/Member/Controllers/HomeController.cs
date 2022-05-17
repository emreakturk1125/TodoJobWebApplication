using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Web.BaseController;

namespace Ysk.Todo.Web.Areas.Member.Controllers
{
    [Authorize(Roles = "Member")]
    [Area("Member")]
    public class HomeController : BaseIdentityController
    {
        private readonly IReportService _reportService;
        private readonly ITaskService _taskService; 
        private readonly INotificationService _notificationService;
        public HomeController(IReportService reportService, ITaskService taskService, INotificationService notificationService, UserManager<AppUser> userManager) : base(userManager)
        {
            _reportService = reportService;
            _taskService = taskService;
            _notificationService = notificationService; 
        }

        public async Task<IActionResult> Index()
        {
            TempData["activePage"] = "home";
            var user = await GetActiveUser();

            ViewBag.ReportCount = _reportService.GetReportCountByAppUserId(user.Id);
            ViewBag.CompletedTaskCount = _taskService.GetCompletedTaskByAppUserId(user.Id);
            ViewBag.RequiredCompleteTaskCount = _taskService.GetRequiredCompleteTaskByAppUserId(user.Id);
            ViewBag.UnreadNotificationCount = _notificationService.GetUnreadCountByAppuserId(user.Id);


            return View();
        }
    }
 
}
