
using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Blog.Data.UnitOfWorks;
using Blog.Service.FluentValidations;
using Blog.Service.Helpers.Images;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Extensions
{
	public static class ServiceLayerExtensions
	{
		public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
		{

			var assembly=Assembly.GetExecutingAssembly(); //assembly autoMapperın çağrıldığı katmanın ismi oluyor service katmanı

			//dependency injection işlemimizi yaptık
			services.AddScoped<IArticleService,ArticleService>();
			services.AddScoped<ICategoryService,CategoryService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IDashboardService, DashboardService>();

            services.AddScoped<IImageHelper,ImageHelper>();

			services.AddSingleton<IHttpContextAccessor,HttpContextAccessor>(); //o anki sisteme giren(login olan) kullanıcıyı bulmamızı sağlayacak kısım

			services.AddAutoMapper(assembly); // assembly yazdıktan tüm profiledan kalıtım alan alanları otomatik bulup dependency injection yapısını kurmuş oluyor


			//articleValidator ın olduğu service assemblysinde abstractValidator<> sınıfından türetilen tüm validation sınıflarını aşağıdaki servis kendisi bulacak

			services.AddControllersWithViews()
				.AddFluentValidation(opt =>
			{
                opt.RegisterValidatorsFromAssemblyContaining<ArticleValidator>();
				opt.DisableDataAnnotationsValidation=true; // entity de başa gidip [] bu şekilde verilen yapıya izin vermiyorum fluentValidation kullanacağımız için
				opt.ValidatorOptions.LanguageManager.Culture = new System.Globalization.CultureInfo("tr");
			});

            
			
			return services;
		}
	}
}
