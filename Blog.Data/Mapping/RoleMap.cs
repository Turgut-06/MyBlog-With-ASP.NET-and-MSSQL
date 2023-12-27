
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
    public class RoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("AspNetRoles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new AppRole
            {
                Id=Guid.Parse("E17509A7-A029-429A-A933-59BDEEC41BC4"),
                Name="Superadmin",
                NormalizedName="SUPERADMIN",
                ConcurrencyStamp=Guid.NewGuid().ToString() //aynı anda 2 kişi aynı rolü değiştirmeye çalışırsa çakışmayı önler
            },
            new AppRole
            {
                Id=Guid.Parse("5CD396B8-AD64-4104-B054-0E38A668775A"),
                Name="Admin",
                NormalizedName="ADMIN",
                ConcurrencyStamp=Guid.NewGuid().ToString()
            },
            new AppRole
            {
                Id=Guid.Parse("CEAFC65B-BD01-4233-8336-29924A3F37C9"),
                Name="User",
                NormalizedName="USER",
                ConcurrencyStamp=Guid.NewGuid().ToString()
            });
        }
    }
}
