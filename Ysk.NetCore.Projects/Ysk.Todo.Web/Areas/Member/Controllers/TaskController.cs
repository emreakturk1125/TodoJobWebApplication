using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.Dto.DTOs.TaskDto;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Web.BaseController;

namespace Ysk.Todo.Web.Areas.Member.Controllers
{
    [Authorize(Roles = "Member")]
    [Area("Member")]
    public class TaskController : BaseIdentityController
    {
        private readonly ITaskService _taskService; 
        private readonly IMapper _mapper;
        public TaskController(ITaskService taskService, UserManager<AppUser> userManager, IMapper mapper) : base(userManager)
        {
            _taskService = taskService; 
            _mapper = mapper;
        }
        public async Task<IActionResult> Index(int activePage = 1)
        {
            if (activePage < 1)
                activePage = 1;

            TempData["activePage"] = "task";

            var user = await GetActiveUser();
            int totalPage;
            var tasks = _taskService.GetAllWithAllTableAndUncompleted(out totalPage, user.Id, activePage);

            ViewBag.TotalPage = totalPage;
            ViewBag.ActivePage = activePage;

            var models = _mapper.Map<List<TaskListAllDto>>(tasks);
             
            return View(models);
        }
    }
}
