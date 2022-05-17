using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Ysk.Ajax.Web.Models;

namespace Ysk.Ajax.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            Thread.Sleep(3000);
            var jsonKullanicilar = JsonConvert.SerializeObject(UserProcess.GetirHepsi());
            return Json(jsonKullanicilar);
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            UserProcess.Ekle(user);
            var jsonKullanici = JsonConvert.SerializeObject(user);
            return Json(jsonKullanici);
        }

        public IActionResult GetById(int kullaniciId)
        {
            var bulunanKullanici = UserProcess.GetirIdile(kullaniciId);
            var jsonKullanici = JsonConvert.SerializeObject(bulunanKullanici);
            return Json(jsonKullanici);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
