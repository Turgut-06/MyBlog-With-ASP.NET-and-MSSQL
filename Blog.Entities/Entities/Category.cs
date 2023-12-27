using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
	public class Category :EntityBase
	{

        public Category()
        {
            
        }

        public Category(string name,string createdBy)
        {
            Name = name;
            CreatedBy = createdBy;
        }

		public string Name { get; set; }
        public string CreatedBy { get; set; }
        public ICollection<Article> Articles { get; set;} //bire çok ilişki tanımlıyoruz bir kategoride bir çok makale olabiliyor
	}
}
