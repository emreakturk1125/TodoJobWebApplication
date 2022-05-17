using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.Dto.DTOs.AppUserDto;
using Ysk.Todo.Entities.Concrete; 

namespace Ysk.Todo.Web.ViewComponents
{
    public class Wrapper : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly INotificationService  _notificationService;
        private readonly IMapper _mapper;
        public Wrapper(UserManager<AppUser> userManager, INotificationService notificationService, IMapper mapper)
        {
            _userManager = userManager;
            _notificationService = notificationService;
            _mapper = mapper;
        }
        public IViewComponentResult Invoke()
        {
            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;

            var model = _mapper.Map<AppUserListDto>(user);
              
            ViewBag.NotificationCount = _notificationService.GetAllUnRead(user.Id).Count();

            var roles = _userManager.GetRolesAsync(user).Result;

            if (roles.Contains("Admin"))
            {
                return View(model);
            }
            return View("Member", model);
           
        }
    }
}
