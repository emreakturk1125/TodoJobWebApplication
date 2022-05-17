using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.Dto.DTOs.NotificationDto;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Web.BaseController;
using Ysk.Todo.Web.StringInfo;

namespace Ysk.Todo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)]
    [Area(AreaInfo.Admin)]
    public class NotificationController : BaseIdentityController
    {
        private readonly INotificationService _notificationService; 
        private readonly IMapper _mapper;
        public NotificationController(INotificationService notificationService, UserManager<AppUser> userManager, IMapper mapper) : base(userManager)
        {
            _notificationService = notificationService; 
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            TempData["activePage"] = TempdataInfo.Notification;
            var user = await GetActiveUser();
             
            var list = _mapper.Map<List<NotificationListDto>>(_notificationService.GetAllUnRead(user.Id));

            return View(list);
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            var notification = _notificationService.GetById(id);
            notification.State = true;
            _notificationService.Update(notification);
            return RedirectToAction("Index");
        }
    }
}
