﻿using Blog.Entity.DTOs.Categories;
using Microsoft.AspNetCore.Http;

namespace Blog.Entity.DTOs.Articles
{
    public class ArticleAddDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Guid CategoryId { get; set; }


        public IFormFile Photo { get; set; } //resim bilgilerimizi IFormFile yapısıyla alacağız
        public IList<CategoryDto> Categories { get; set; }
    }
}
