using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.Dto.DTOs.AppUserDto;
using Ysk.Todo.Dto.DTOs.PersonalDto;
using Ysk.Todo.Dto.DTOs.ReportDto;
using Ysk.Todo.Dto.DTOs.TaskDto;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Web.BaseController;
using Ysk.Todo.Web.StringInfo;

namespace Ysk.Todo.Web.Areas.Admin.Controllers
{
    // Excel için  => Manage Nuget Package dan,  ""EPPlus""  kütüphanesini yükle
    // PDF   için  => Manage Nuget Package dan,  ""ITextSharp.LGPLv2.Core"" ve ""FastMember""  kütüphanelerini yükle
     
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class WorkOrderController : BaseIdentityController
    {
        private readonly IAppUserService _appUserService;
        private readonly ITaskService _taskService;
        private readonly IFileService _fileService; 
        private readonly INotificationService _notificationService;
        private readonly IMapper _mapper;
        public WorkOrderController(IAppUserService appUserService, ITaskService taskService, IFileService fileService, UserManager<AppUser> userManager, INotificationService notificationService, IMapper mapper) : base(userManager)
        {
            _appUserService = appUserService;
            _taskService = taskService;
            _fileService = fileService; 
            _notificationService = notificationService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            TempData["activePage"] = TempdataInfo.WorkOrder; 
             
            var models = _mapper.Map<List<TaskListAllDto>>(_taskService.GetAllWithAllTable(x => !x.Status));
              
            return View(models);
        }

        public IActionResult Details(int id)
        {
            TempData["activePage"] = TempdataInfo.WorkOrder;

            var model = _mapper.Map<TaskListAllDto>(_taskService.GetReportsById(id));
             
            return View(model); 
        }

        public IActionResult GetExcel(int id)
        {
            var list = _mapper.Map<List<ReportFileDto>>(_taskService.GetReportsById(id).Reports);

            var content = _fileService.ToExcel(list);

            return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", Guid.NewGuid() + ".xlsx");
        }
        public IActionResult GetPdf(int id)
        {
            var list = _mapper.Map<List<ReportFileDto>>(_taskService.GetReportsById(id).Reports);

            var virtualPath = _fileService.ToPdf(list);
             
            return File(virtualPath, "application/pdf", Guid.NewGuid() + ".pdf");
        }
        public IActionResult AssignPersonal(int id, string s, int page = 1)
        {
            TempData["activePage"] = TempdataInfo.WorkOrder;

            ViewBag.ActivePage = page;
            ViewBag.Searched = s;

            int totalPage; 
            var personals = _appUserService.GetAllWithoutAdmin(out totalPage,s, page);

            ViewBag.TotalPage = totalPage;

            var appUserListModel = _mapper.Map<List<AppUserListDto>>(personals);
            ViewBag.Personels = appUserListModel;
             
            var taskModel = _mapper.Map<TaskListDto>(_taskService.GetUrgencyById(id));
             
            return View(taskModel); 
        }

        // Bildirim Gönderilecek
        [HttpPost]
        public IActionResult AssignPersonal(PersonalEntrustDto model)
        {
            var task = _taskService.GetById(model.TaskId);
            task.AppUserId = model.PersonalId;

            _taskService.Update(task);

            _notificationService.Save(new Notification
            {
                AppUserId = model.PersonalId,
                Description = $"{task.Name} işi için görevlendirildiniz."
            });

            return RedirectToAction("Index");
        }
        public IActionResult EntrustPersonal(PersonalEntrustDto model)
        {

            TempData["activePage"] = TempdataInfo.WorkOrder; 
              
            var userModel = _mapper.Map<AppUserListDto>(_userManager.Users.FirstOrDefault(I => I.Id == model.PersonalId));

            var taskModel = _mapper.Map<TaskListDto>(_taskService.GetUrgencyById(model.TaskId));

            PersonalEntrustListDto listModel = new PersonalEntrustListDto();
              
            listModel.AppUser = userModel;
            listModel.Task = taskModel;

            return View(listModel);
        }

       
 
    }
}
