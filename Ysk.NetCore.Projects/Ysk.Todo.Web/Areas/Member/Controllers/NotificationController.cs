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

namespace Ysk.Todo.Web.Areas.Member.Controllers
{
    [Authorize(Roles ="Member")]
    [Area("Member")]
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
            TempData["activePage"] = "notification";
            var user = await GetActiveUser(); 
             
            var models = _mapper.Map<List<NotificationListDto>>(_notificationService.GetAllUnRead(user.Id));
             
            return View(models);
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
