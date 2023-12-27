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
	.AddNToastNotifyToastr(new ToastrOptions()   //Toast mesaj�n� controllerVithViews ile birlikte veriyorum
	{
		PositionClass=ToastPositions.TopRight,
		TimeOut=3000, //milisaniye cinsinden 3 sn yapar


	})
	.AddRazorRuntimeCompilation();
builder.Services.AddSession();




builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{

	//canl�ya al�rken parolalar�n g��l� olmas� i�in bunlar� kald�r,test oldu�u i�in �imdi b�yle
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
		SecurePolicy = CookieSecurePolicy.Always //http ve https destekler canl�ya al�rken always yap sadece https als�n
	};
	config.SlidingExpiration = true;
	config.ExpireTimeSpan = TimeSpan.FromDays(7); //cookie nin ne kadar sistemde tutulaca�� siteye giri� yapt�ktan sonra oturum 7 g�n a��k kalacak
	config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied"); //yetkisiz bir giri� oldu�unda buraya y�nlendirecek

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseNToastNotify(); //toast mesaj�m�z i�in
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();
app.UseRouting();

app.UseAuthentication(); 
app.UseAuthorization(); //authorization altta kalmas� gerekiyor bu �nemli

app.UseEndpoints(endpoints =>
{
	endpoints.MapAreaControllerRoute(
		name:"Admin",
		areaName:"Admin",
		pattern:"Admin/{controller=Home}/{action=Index}/{id?}"
		);
	endpoints.MapDefaultControllerRoute(); //admine girmezsem defaulta y�nlendirecek
});

app.Run();
