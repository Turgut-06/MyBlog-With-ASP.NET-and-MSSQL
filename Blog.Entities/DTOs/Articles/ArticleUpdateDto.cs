using Blog.Entity.DTOs.Categories;
using Blog.Entity.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.DTOs.Articles
{
    public class ArticleUpdateDto
    {
        public Guid Id { get; set; } //makalenin bir id si olacak ona göre işlem yapacağız güncellerken

        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }


        public Image Image { get; set; }

        public IFormFile? Photo { get; set; } //makale güncellenirken resimde değişiklik yapmamışsa eski resmim kalacak bu yüzden IFormFile yapısı boş geçilebilir

        public IList<CategoryDto> Categories { get; set; } //güncellerken diğer kategorilere de görmem lazım yine list tipinde kategoriler gelecek
    }
}
