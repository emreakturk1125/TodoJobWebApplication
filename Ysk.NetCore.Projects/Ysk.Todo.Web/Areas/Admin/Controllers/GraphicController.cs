using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ysk.Todo.Business.Abstract;
using Ysk.Todo.Web.StringInfo;

namespace Ysk.Todo.Web.Areas.Admin.Controllers
{
    [Area(AreaInfo.Admin)]
    [Authorize(Roles = RoleInfo.Admin)]
    public class GraphicController : Controller
    {
        private readonly IAppUserService _appUserService;
        public GraphicController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }
        public IActionResult Index()
        {
            TempData["activePage"] = TempdataInfo.Graphic;
            return View();
        }

        public IActionResult GetMostTaskCompletedPersonel()
        {
            var jsonString = JsonConvert.SerializeObject(_appUserService.GetMostTaskCompletedPersonel());
            return Json(jsonString);
        }

        public IActionResult GetMostEmployedOnTask()
        {
            var jsonString = JsonConvert.SerializeObject(_appUserService.GetMostEmployedOnTask());
            return Json(jsonString);
        }
    }
}
