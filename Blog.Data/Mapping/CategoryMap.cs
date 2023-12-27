using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mapping
{
	public class CategoryMap : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.HasData(new Category
			{

				Id = Guid.Parse("FDCA4000-618B-4071-8309-93D79F1EBD9A"),
				Name = "ASP.NET Core",
				CreatedBy = "Turgut1",
				CreatedDate = DateTime.Now,
				IsDeleted = false,



			},
			 new Category
			 {
				 Id = Guid.Parse("79F69F6C-AB9F-4CE9-93CF-D6D4D8865EF6"),
				 Name = "Visual Studio",
				 CreatedBy = "Turgut2",
				 CreatedDate = DateTime.Now,
				 IsDeleted = false,

			 }
			);
		}
	}
}
