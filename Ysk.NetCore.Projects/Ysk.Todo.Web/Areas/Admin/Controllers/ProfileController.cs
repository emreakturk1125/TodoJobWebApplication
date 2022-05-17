using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ysk.Todo.Dto.DTOs.AppUserDto;
using Ysk.Todo.Entities.Concrete;
using Ysk.Todo.Web.BaseController;
using Ysk.Todo.Web.StringInfo;

namespace Ysk.Todo.Web.Areas.Admin.Controllers
{
    [Area(AreaInfo.Admin)]
    [Authorize(Roles = RoleInfo.Admin)]
    public class ProfileController : BaseIdentityController
    { 
        private readonly IMapper _mapper;
        public ProfileController(UserManager<AppUser> userManager, IMapper mapper) : base(userManager)
        { 
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            TempData["activePage"] = TempdataInfo.Profile;
            var appUser = await GetActiveUser();   // BaseControllerdan geliyor

            var model = _mapper.Map<AppUserListDto>(appUser);
             
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserListDto model, IFormFile picture)
        {
            if (ModelState.IsValid)
            {
                var updateUser = _userManager.Users.FirstOrDefault(I => I.Id == model.Id);
                if (picture != null)
                {
                    string extension = Path.GetExtension(picture.FileName);
                    string pictureName = Guid.NewGuid() + extension;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + pictureName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await picture.CopyToAsync(stream);
                    }

                    updateUser.Picture = pictureName;
                }

                updateUser.Name = model.Name;
                updateUser.Surname = model.Surname;
                updateUser.Email = model.Email;

                var result = await _userManager.UpdateAsync(updateUser);
                if (result.Succeeded)
                {
                    TempData["message"] = "Güncelleme işleminiz başarı ile gerçekleşti";
                    return RedirectToAction("Index");
                }

                AddError(result.Errors);    // BaseControllerdan geliyor
                 
            }
            return View(model);
        }
    }
}
