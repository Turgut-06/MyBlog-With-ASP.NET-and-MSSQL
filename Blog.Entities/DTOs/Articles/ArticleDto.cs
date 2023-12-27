using Blog.Entity.DTOs.Categories;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.DTOs.Articles
{
    public class ArticleDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }   
        public string Content { get; set; }   
        public CategoryDto category { get; set; } //categoryDto önerecek bunu yazma serviste

        public virtual DateTime CreatedDate { get; set; }

        public Image Image { get; set; }

        public virtual string CreatedBy { get; set; }

        public bool isDeleted { get; set; }
       




    }
}
