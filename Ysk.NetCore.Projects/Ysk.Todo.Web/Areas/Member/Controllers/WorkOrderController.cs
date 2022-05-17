using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.Dto.DTOs.ReportDto;
using Ysk.Todo.Dto.DTOs.TaskDto;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Web.BaseController;

namespace Ysk.Todo.Web.Areas.Member.Controllers
{
    // Excel için  => Manage Nuget Package dan,  ""EPPlus""  kütüphanesini yükle
    // PDF   için  => Manage Nuget Package dan,  ""ITextSharp.LGPLv2.Core"" ve ""FastMember""  kütüphanelerini yükle
    [Authorize(Roles = "Member")]
    [Area("Member")]
    public class WorkOrderController : BaseIdentityController
    { 
        private readonly ITaskService _taskService;
        private readonly IReportService _reportService;
        private readonly INotificationService _notificationService;
        private readonly IMapper _mapper;
        public WorkOrderController(UserManager<AppUser> userManager, ITaskService taskService, IReportService reportService, INotificationService notificationService, IMapper mapper) : base(userManager)
        { 
            _taskService = taskService;
            _reportService = reportService;
            _notificationService = notificationService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
             
            TempData["activePage"] = "workorder";

            var user = await GetActiveUser();    //User.Identity.Name -> Identity Kütüphanesinden gelen özellik

            var taskList = _taskService.GetAllWithAllTable(x => x.AppUserId == user.Id && !x.Status);

            List<TaskListAllDto> modelList = new List<TaskListAllDto>();

            foreach (var item in taskList)
            {
                TaskListAllDto model = new TaskListAllDto();
                model.Id = item.Id;
                model.Description = item.Description;
                model.Urgency = item.Urgency;
                model.Name = item.Name;
                model.AppUser = item.AppUser;
                model.Reports = item.Reports;
                model.CreatedDate = item.CreatedDate;
                modelList.Add(model);
            }

            return View(modelList);
        }

        [HttpGet]
        public IActionResult AddReport(int id)
        {
            TempData["activePage"] = "workorder";
             
            var task = _taskService.GetUrgencyById(id);
              
            ReportAddDto model = new ReportAddDto();
            model.TaskId = id;
            model.Task = task;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddReport(ReportAddDto model)
        { 
            if (ModelState.IsValid)
            {
                _reportService.Save(new Report()
                {
                    TaskId = model.TaskId,
                    Detail = model.Detail,
                    Description = model.Description
                });

                var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");

                var activeUser = await GetActiveUser();

                foreach (var admin in adminUserList)
                {
                    _notificationService.Save(new Notification()
                    {
                        Description = $"{activeUser.Name} {activeUser.Surname} yeni bir rapor yazdı",
                        AppUserId = admin.Id
                    });
                }

                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult UpdateReport(int id)
        {
            TempData["activePage"] = "workorder";

            var model = _mapper.Map<ReportUpdateDto>(_reportService.GetWithTaskById(id));

            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateReport(ReportUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                var report = _reportService.GetWithTaskById(model.Id);
                report.TaskId = model.TaskId;
                report.Description = model.Description;
                report.Detail = model.Detail;

                _reportService.Update(report);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public async Task<IActionResult> CompleteTask(int taskId)
        {
            var task = _taskService.GetById(taskId);
            task.Status = true;
            _taskService.Update(task);

            var adminUserList = await _userManager.GetUsersInRoleAsync("Admin");

            var activeUser = await GetActiveUser();

            foreach (var admin in adminUserList)
            {
                _notificationService.Save(new Notification()
                {
                    Description = $"{activeUser.Name} {activeUser.Surname} vermiş olduğunuz bir görevi tamamladı",
                    AppUserId = admin.Id
                });
            }

            return Json(null);
        }
    }
}
