using AutoMapper;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.ViewComponents
{
    public class DashboardHeaderViewComponent :ViewComponent
    {
        private readonly UserManager<AppUser> userManager;
        private readonly IMapper mapper;

        public DashboardHeaderViewComponent(UserManager<AppUser> userManager,IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync() //Controllerdaki index gibi burada da ilk InvokeAsync veriyorsun
        {
            var loggedInUser = await userManager.GetUserAsync(HttpContext.User);
            var map=mapper.Map<UserDto>(loggedInUser);  //UserDto role kısmını içerdiği için aldık

            var role=string.Join("",await userManager.GetRolesAsync(loggedInUser)); //eşleştirilmeyen boşta kalan rol değerimizi kendimiz veriyoruz
            map.Role = role;

            return View(map); 
        }
    }
}
