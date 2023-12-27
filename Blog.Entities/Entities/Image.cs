using Blog.Core.Entities;
using Blog.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
	public class Image : EntityBase
	{

        public Image()
        {

        }
        public Image(string fileName,string fileType,string createdBy)
        {
            FileName = fileName;
            FileType = fileType;
            CreatedBy = createdBy;
        }
        public Guid Id { get; set; }
		public string FileName { get; set; }
		public string FileType { get; set; }
        public string CreatedBy { get; set; }


        //Article a collection olarak bağlı
        public ICollection<Article> Articles { get; set;}

		public ICollection<AppUser> Users { get; set;}
	}
}
