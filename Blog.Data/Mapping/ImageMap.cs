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
	public class ImageMap : IEntityTypeConfiguration<Image>
	{
		public void Configure(EntityTypeBuilder<Image> builder)
		{
			builder.HasData(new Image
			{
				Id = Guid.Parse("E2115C08-6ADB-4650-BF91-0371F285D695"),
				IsDeleted = false,
				FileName = "images/testImages",
				FileType = "jpg",
				CreatedBy = "Turgut1",
				CreatedDate = DateTime.Now,
			},
			new Image
			{
				Id = Guid.Parse("CAC76575-24C7-4038-AF6D-FE07475023EB"),
				IsDeleted = false,
				FileName = "images/testImages2",
				FileType = "png",
				CreatedBy = "Turgut2",
				CreatedDate = DateTime.Now,
			}
			);
		}
	}
}
