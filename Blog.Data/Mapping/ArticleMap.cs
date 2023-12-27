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
	internal class ArticleMap : IEntityTypeConfiguration<Article>
	{
		public void Configure(EntityTypeBuilder<Article> builder)
		{
			/*
			builder.Property(x => x.Title).HasMaxLength(150);
			builder.Property(x => x.Title).IsRequired(false);
			*/
			builder.HasData(new Article
			{
				Id = Guid.NewGuid(),
				Title = "Asp.net makalesi 1",
				Content = "asp.net1sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds",
				viewCount = 15,
				CreatedBy = "Turgut1",
				CreatedDate = DateTime.Now,
				IsDeleted = false,
				categoryId = Guid.Parse("FDCA4000-618B-4071-8309-93D79F1EBD9A"),
				ImageId=Guid.Parse("E2115C08-6ADB-4650-BF91-0371F285D695"),
				UserId= Guid.Parse("FB4AEF20-2643-442D-8840-A32E17477CB1")


            },
				new Article {
					Id = Guid.NewGuid(),
					Title = "Asp.net makalesi 2",
                    Content = "asp.net2sdfdsfdsgsdgsdfsdgsdgsdgsdsdgdsgsdgsdhsdvdxfvxvdfhşsıdfjdskfjludsfgpudsguds",
					viewCount = 15,
					CreatedBy = "Turgut1",
					CreatedDate = DateTime.Now,
					IsDeleted = false,
					categoryId= Guid.Parse("79F69F6C-AB9F-4CE9-93CF-D6D4D8865EF6"),
					ImageId= Guid.Parse("CAC76575-24C7-4038-AF6D-FE07475023EB"),
					UserId= Guid.Parse("C76A84D9-93A1-44B1-9A2C-C7DB4C55D9AF")

                });
		}
	}
}
