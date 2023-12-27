using Blog.Entity.Entities;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Context
{
	public class AppDbContext : IdentityDbContext<AppUser,AppRole,Guid,AppUserClaim,AppUserRole,AppUserLogin,AppRoleClaim,AppUserToken>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		protected AppDbContext()
		{
		}

		//DbSet ile veritabanı tablousu oluşturuyoruz tablo ismi çoğul olarak oluşturulur
		public DbSet<Article> Articles { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Image> Images { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder); //base e bunu göndermemiz lazım identity yapısından dolayı
			//IEntityTypeConfiguration dan kalıtım alan tüm mapping sınıflarını burada tanımlar 
			//Assembly implemente edilen arayüze erişim etmiş oluyor
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			//assembly içinde bulunduğu katmanı entity katmanını ifade ediyor
			
		}
	}
}
