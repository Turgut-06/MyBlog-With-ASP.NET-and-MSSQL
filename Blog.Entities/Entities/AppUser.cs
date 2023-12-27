using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class AppUser :IdentityUser<Guid>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("E2115C08-6ADB-4650-BF91-0371F285D695");//kullanıcının fotosu olacak

        public Image Image { get; set; } //Image sınıfımızdan çekicez

        public ICollection<Article> Articles { get; set; } //bir kullanıcının birden çok makalesi olabileceğinden
    }
}
