using AutoMapper;
using Blog.Data.Context;
using Blog.Data.Extensions;
using Blog.Entity.Entities;
using Blog.Service.Describers;
using Blog.Service.Services.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

builder.Services.LoadDataLayerExtension(builder.Configuration);
builder.Services.LoadServiceLayerExtension();
// Add services to the container.
builder.Services.AddControllersWithViews()
	.AddNToastNotifyToastr(new ToastrOptions()   //Toast mesajýný controllerVithViews ile birlikte veriyorum
	{
		PositionClass=ToastPositions.TopRight,
		TimeOut=3000, //milisaniye cinsinden 3 sn yapar


	})
	.AddRazorRuntimeCompilation();
builder.Services.AddSession();




builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{

	//canlýya alýrken parolalarýn güçlü olmasý için bunlarý kaldýr,test olduðu için þimdi böyle
	opt.Password.RequireNonAlphanumeric = false;
	opt.Password.RequireUppercase = false;
	opt.Password.RequireLowercase = false;
})
	.AddRoleManager<RoleManager<AppRole>>()
	.AddErrorDescriber<CustomIdentityErrorDescriber>()
	.AddEntityFrameworkStores<AppDbContext>()
	.AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(config =>
{
	config.LoginPath = new PathString("/Admin/Auth/Login");
	config.LogoutPath = new PathString("/Admin/Auth/Logout");
	config.Cookie = new CookieBuilder
	{
		Name = "MyBlog",
		HttpOnly = true,
		SameSite = SameSiteMode.Strict,
		SecurePolicy = CookieSecurePolicy.Always //http ve https destekler canlýya alýrken always yap sadece https alsýn
	};
	config.SlidingExpiration = true;
	config.ExpireTimeSpan = TimeSpan.FromDays(7); //cookie nin ne kadar sistemde tutulacaðý siteye giriþ yaptýktan sonra oturum 7 gün açýk kalacak
	config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied"); //yetkisiz bir giriþ olduðunda buraya yönlendirecek

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseNToastNotify(); //toast mesajýmýz için
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();
app.UseRouting();

app.UseAuthentication(); 
app.UseAuthorization(); //authorization altta kalmasý gerekiyor bu önemli

app.UseEndpoints(endpoints =>
{
	endpoints.MapAreaControllerRoute(
		name:"Admin",
		areaName:"Admin",
		pattern:"Admin/{controller=Home}/{action=Index}/{id?}"
		);
	endpoints.MapDefaultControllerRoute(); //admine girmezsem defaulta yönlendirecek
});

app.Run();
