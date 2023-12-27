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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId= Guid.Parse("FB4AEF20-2643-442D-8840-A32E17477CB1"),
                RoleId =Guid.Parse("E17509A7-A029-429A-A933-59BDEEC41BC4")

            },
            new AppUserRole
            {
                UserId= Guid.Parse("C76A84D9-93A1-44B1-9A2C-C7DB4C55D9AF"),
                RoleId= Guid.Parse("5CD396B8-AD64-4104-B054-0E38A668775A")
            }
            );
        }
    }
}
