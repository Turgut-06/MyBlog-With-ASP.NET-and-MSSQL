using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.Repositories.Concretes;
using Blog.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Extensions
{
	public static class DataLayerExtensions
	{
		public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services,IConfiguration config)
		{

			//her IRepository e istek yolladığımda Repository nesnesini bana repository nesnesini gönder dedik
			services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
			services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("Default Connection")));
			
			//IUnitofWork istendiğinde UnitOfWork örneği göndericez dependency injection yaptık
			services.AddScoped<IUnitOfWork, UnitOfWork>();
			return services;
		}

	}
}
