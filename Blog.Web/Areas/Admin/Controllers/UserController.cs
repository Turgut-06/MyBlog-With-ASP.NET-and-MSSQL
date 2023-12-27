using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Blog.Entity.Enums;
using Blog.Service.Helpers.Images;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Extensions;
using Blog.Web.ResultMessages;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using static Blog.Web.ResultMessages.Message;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class UserController : Controller
    {
        private readonly IMapper mapper;
        private readonly IUserService userService;
        private readonly IToastNotification toast;
        private readonly IValidator<AppUser> validator;

        public UserController(IMapper mapper, IUserService userService,IToastNotification toast, IValidator<AppUser> validator)
        {
            this.mapper = mapper;
            this.userService = userService;
            this.toast = toast;
            this.validator = validator;
        }
        public async Task<IActionResult> Index()
        {
            var result = await userService.GetAllUsersWithRoleAsync();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var roles = await userService.GetAllRolesAsync();
            return View(new UserAddDto { Roles = roles });

        }

        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            var map = mapper.Map<AppUser>(userAddDto); //userAddDto dan gelen değrler AppUser tipine dönüştürülüp işlenecek
            var validation = await validator.ValidateAsync(map);
            var roles = await userService.GetAllRolesAsync();


            if (ModelState.IsValid)
            {
                var result = await userService.CreateUserAsync(userAddDto);

                if (result.Succeeded)
                {

                    toast.AddSuccessToastMessage(Message.User.Add(userAddDto.Email), new ToastrOptions { Title = "başarılı" });
                    return RedirectToAction("Index", "User", new { Area = "Admin" });

                }
                else
                {
                    result.AddToIdentityModelState(this.ModelState); //identity den direk geren kuralları göstermek için
                    validation.AddToModelState(this.ModelState); //kendi oluşturduğum kuralları vermek için
                    return View(new UserAddDto { Roles = roles });

                }
            }
            return View(new UserAddDto { Roles = roles });

        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid userId)
        {
            var user = await userService.GetAppUserByIdAsync(userId);

            var roles = await userService.GetAllRolesAsync();

            var map = mapper.Map<UserUpdateDto>(user);
            map.Roles = roles;

            return View(map);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            var user = await userService.GetAppUserByIdAsync(userUpdateDto.Id);

            if (user != null)
            {
                var roles = await userService.GetAllRolesAsync();
                if (ModelState.IsValid)
                {
                    var map = mapper.Map(userUpdateDto, user); //userUpdateDto nun içindeki aynı isimli alanları userdaki aynı alanlara aktarıyor 
                    var validation = await validator.ValidateAsync(map); //kendi validation işlemlerimi eklemek için

                    if (validation.IsValid)
                    {
                        user.UserName = userUpdateDto.Email;
                        user.SecurityStamp = Guid.NewGuid().ToString();
                        var result = await userService.UpdateUserAsync(userUpdateDto);
                        if (result.Succeeded)
                        {

                            toast.AddSuccessToastMessage(Message.User.Update(userUpdateDto.Email), new ToastrOptions { Title = "başarılı" });
                            return RedirectToAction("Index", "User", new { Area = "Admin" });
                        }
                        else
                        {
                            result.AddToIdentityModelState(this.ModelState); //identity den direk geren kuralları göstermek için
                            return View(new UserUpdateDto { Roles = roles });

                        }

                    }
                    else
                    {
                        validation.AddToModelState(this.ModelState);
                        return View(new UserUpdateDto { Roles = roles });

                    }

                }

            }

            return NotFound();
        }

        public async Task<IActionResult> Delete(Guid userId)
        {
            var result = await userService.DeleteUserAsync(userId);
            if (result.identityResult.Succeeded)
            {
                toast.AddSuccessToastMessage(Message.User.Delete(result.email), new ToastrOptions { Title = "başarılı" });
                return RedirectToAction("Index", "User", new { Area = "Admin" });
            }
            else
            {
                result.identityResult.AddToIdentityModelState(this.ModelState); //identity den direk geren kuralları göstermek için

            }
            return NotFound();

        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {

            var profile = await userService.GetUserProfileAsync();
            return View(profile);

        }
        [HttpPost]
        public async Task<IActionResult> Profile(UserProfileDto userProfileDto)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.UserProfileUpdateAsync(userProfileDto);
                if (result)
                {
                    toast.AddSuccessToastMessage("Profil güncelleme işlemi tamamlandı", new ToastrOptions { Title = "İşlem başarılı" });
                    return RedirectToAction("Index", "Home", new { Area = "Admin" });
                }
                else
                {
                    var profile = await userService.GetUserProfileAsync();
                    toast.AddErrorToastMessage("Profil güncelleme işlemi tamamlanamadı", new ToastrOptions { Title = "İşlem başarısız" });
                    return View(profile);
                }


            }
            else
                return NotFound();


        }

    }
}

