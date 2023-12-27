using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            // Primary key
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNeAppUsers table
            builder.ToTable("AspNeAppUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();

            var SuperAdmin = new AppUser
            {
                Id=Guid.Parse("FB4AEF20-2643-442D-8840-A32E17477CB1"),
                UserName="superadmin@gmail.com",
                NormalizedUserName="SUPERADMIN@GMAIL.COM",
                Email = "superadmin@gmail.com",
                NormalizedEmail= "SUPERADMIN@GMAIL.COM",
                PhoneNumber="+05349999999",
                FirstName="turgut",
                LastName="köksal",
                PhoneNumberConfirmed=true,
                EmailConfirmed=true,
                SecurityStamp=Guid.NewGuid().ToString(),
                ImageId= Guid.Parse("E2115C08-6ADB-4650-BF91-0371F285D695")

            };

            SuperAdmin.PasswordHash = CreatePasswordHash(SuperAdmin, "123456");

            var admin = new AppUser
            {
                Id = Guid.Parse("C76A84D9-93A1-44B1-9A2C-C7DB4C55D9AF"),
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                PhoneNumber = "+05349999988",
                FirstName = "Admin",
                LastName = "User",
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ImageId= Guid.Parse("CAC76575-24C7-4038-AF6D-FE07475023EB")
            };

            admin.PasswordHash = CreatePasswordHash(admin, "123456");
            
            builder.HasData(SuperAdmin,admin);
        }

        private string CreatePasswordHash(AppUser appUser,string password)
        {
            var passwordHasher = new PasswordHasher<AppUser>();
            return passwordHasher.HashPassword(appUser, password);

        }
    }
}
