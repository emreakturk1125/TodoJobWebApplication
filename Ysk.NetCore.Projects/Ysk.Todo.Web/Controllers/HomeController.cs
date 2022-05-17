using AutoMapper;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Ysk.Todo.Dto.DTOs.AppUserDto;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Web.BaseController;

namespace Ysk.Todo.Web.Controllers
{
    public class HomeController : BaseIdentityController
    { 
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IMapper mapper) : base(userManager)
        {
            _signInManager = signInManager;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(AppUserSignInDto model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);

                if (user != null)
                {
                   var identityResult = await _signInManager.PasswordSignInAsync(model.UserName, model.Password,model.RememberMe, false);
                    if (identityResult.Succeeded)
                    {
                        var roles = await _userManager.GetRolesAsync(user);

                        if (roles.Contains("Admin"))
                        {
                            return RedirectToAction("Index","Home", new { area = "Admin"});
                        }

                        return RedirectToAction("Index", "Home", new { area = "Member" });
                    }
                }

                ModelState.AddModelError("", "Kullanıcı adı veya şifre yanlış");
            }

            return View("Index",model);
        }
         
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(AppUserAddDto model)
        {
            if (ModelState.IsValid)
            {

                AppUser appUser = new AppUser
                {
                    UserName = model.UserName,
                    Email = model.Email,
                    Name = model.Name,
                    Surname = model.Surname
                };

               var result =  await _userManager.CreateAsync(appUser,model.Password);

                if (result.Succeeded)
                {
                    var addRoleResult = await _userManager.AddToRoleAsync(appUser, "Member");

                    if (addRoleResult.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }

                   AddError(result.Errors);
                }

                   AddError(result.Errors);

            }

            return View(model);
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

        public IActionResult StatusCode(int? code)
        {
            if (code == 404)
            {
                ViewBag.Code = code;
                ViewBag.Message = "Sayfa bulunamadı.";
            }

            return View();
        }


        public IActionResult Error()
        {
            var exceptionHandler = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

          //  _customLogger.LogError($"Hatanın oluştuğu yer :{exceptionHandler.Path}\nHatanın mesajı :{exceptionHandler.Error.Message}\nStack Trace :{exceptionHandler.Error.StackTrace}");

            ViewBag.Path = exceptionHandler.Path;
            ViewBag.Message = exceptionHandler.Error.Message;

            return View();
        }

        public IActionResult ErrorTesting()
        {
            throw new System.Exception("bu bir hatadır");
        }

    }
}
