using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AuthController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpGet] //veri gösterdiğimiz veri göndermediğimiz için post değil get
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous] //bunun sayesinde sayfa kitli olsada bU Login kısmın gösterilmesine izin veriliyor
        [HttpPost] //butona basıp veri gönderdiğimiz için post
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            if (ModelState.IsValid)  //modelstate de herhangi bir sorun yoksa
            {
                var user = await userManager.FindByEmailAsync(userLoginDto.Email);
                if (user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, userLoginDto.Password, userLoginDto.RememberMe, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home", new { Area = "Admin" }); //sırayla Index ve Controllerın ismini veriyoruz
                    }
                    else
                    {
                        ModelState.AddModelError("", "E posta adresiniz veya şifreniz hatalıdır");
                        return View(); //yanlış girişte olsa tekrardan aynı giriş ekranına atacak bizi
                    }


                }
                else
                {
                    ModelState.AddModelError("", "E posta adresiniz veya şifreniz hatalıdır");
                    return View();
                }
            }
            else
            {
                return View(); //buraya ulaşmasını beklemiyoruz

            }

            }
        [Authorize] //bir kişinin oturumunu sonlandırabilmesi için önce login olması gerekiyor
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" }); //logout yaptıktan sonra direk ana sayfaya yönlendiriyorum
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AccessDenied()
        {
            return View();
        }

    }

        
    }


