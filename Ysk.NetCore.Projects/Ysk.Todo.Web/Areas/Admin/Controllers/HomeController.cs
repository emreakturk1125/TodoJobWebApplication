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
using Ysk.Todo.Web.StringInfo;

namespace Ysk.Todo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class HomeController : BaseIdentityController
    {
        private readonly ITaskService _taskService;
        private readonly INotificationService _notificationService;
        private readonly IReportService _reportService; 

        public HomeController(ITaskService taskService, INotificationService notificationService, IReportService reportService, UserManager<AppUser> userManager) : base(userManager)
        {
            _taskService = taskService;
            _notificationService = notificationService;
            _reportService = reportService; 
        }

        public IActionResult Index()
        {
            TempData["activePage"] = TempdataInfo.Home;
            var user = GetActiveUser();

            ViewBag.PendingAssignmentTaskCount = _taskService.GetPendingAssignmentTask();
            ViewBag.CompletedTaskCount = _taskService.GetCompletedTask();
            ViewBag.UnreadNotificationCount = _notificationService.GetUnreadCountByAppuserId(user.Id);
            ViewBag.TotalReportsCount = _reportService.GetReportCount();
            return View();
        }
    }
}
