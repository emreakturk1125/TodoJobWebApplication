using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq; 
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.Dto.DTOs.TaskDto;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Web.StringInfo;

namespace Ysk.Todo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)] 
    [Area(AreaInfo.Admin)]
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly IUrgencyService _urgencyService;
        private readonly IMapper _mapper;
        public TaskController(ITaskService taskService, IUrgencyService urgencyService, IMapper mapper)
        {
            _taskService = taskService;
            _urgencyService = urgencyService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            TempData["activePage"] = TempdataInfo.Task;  
            var list = _mapper.Map<List<TaskListDto>>(_taskService.GetAllTaskWithUncompleted());
             
            return View(list);
        }


        public IActionResult Add()
        {
            TempData["activePage"] = TempdataInfo.Task;
            ViewBag.Urgencys = new SelectList(_urgencyService.GetAll(),"Id","Description");
            return View(new TaskAddDto());
        }

        [HttpPost]
        public IActionResult Add(TaskAddDto model)
        {
            if (ModelState.IsValid)
            {
                var addModel = _mapper.Map<Task>(model);

                _taskService.Save(addModel);

                return RedirectToAction("Index");
            }

            ViewBag.Urgencys = new SelectList(_urgencyService.GetAll(), "Id", "Description");

            return View(model);
        }

        public IActionResult Update(int id)
        {
            var task = _taskService.GetById(id);

            var model = _mapper.Map<TaskUpdateDto>(_taskService.GetById(id));
             
            ViewBag.Urgencys = new SelectList(_taskService.GetAll(), "Id", "Description", task.UrgencyId);

            return View(model);
        }

        [HttpPost]
        public IActionResult Update(TaskUpdateDto model)
        {
            if (ModelState.IsValid)
            {

                var updateModel = _mapper.Map<Task>(model);

                _taskService.Update(updateModel);

                return RedirectToAction("Index");
            }

            ViewBag.Urgencys = new SelectList(_taskService.GetAll(), "Id", "Description", model.UrgencyId);

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            _taskService.Delete(new Task { Id = id });
            return Json(null);
        }

    }
}
;