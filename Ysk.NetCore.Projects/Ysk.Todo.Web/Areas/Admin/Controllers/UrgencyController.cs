using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.Dto.DTOs.UrgencyDto;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Web.StringInfo;

namespace Ysk.Todo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = RoleInfo.Admin)] 
    [Area(AreaInfo.Admin)]
    public class UrgencyController : Controller
    {
        private readonly IUrgencyService _urgencyService;
        private readonly IMapper _mapper;
        public UrgencyController(IUrgencyService urgencyService, IMapper mapper)
        {
            _urgencyService = urgencyService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["activePage"] = TempdataInfo.Urgency;
             
            var list = _mapper.Map<List<UrgencyListDto>>(_urgencyService.GetAll());
            return View(list);
        }

        public IActionResult Add()
        { 
            return View(new UrgencyAddDto());
        }

        [HttpPost]
        public IActionResult Add(UrgencyAddDto model)
        {
            if (ModelState.IsValid)
            {
                var modelAdd = _mapper.Map<Urgency>(model);
                _urgencyService.Save(modelAdd);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Update(int id)
        {
            var model = _mapper.Map<UrgencyUpdateDto>(_urgencyService.GetById(id)); 
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(UrgencyUpdateDto model)
        {
            if (ModelState.IsValid)
            {
                var updateModel = _mapper.Map<Urgency>(model);
                _urgencyService.Update(updateModel);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
