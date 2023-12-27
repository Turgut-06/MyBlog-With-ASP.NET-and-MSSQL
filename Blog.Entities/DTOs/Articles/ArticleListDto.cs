using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.DTOs.Articles
{
    public class ArticleListDto
    {
        public IList<Article> Articles { get; set; }

        public Guid? CategoryId { get; set; }


        public virtual int CurrentPage { get; set; } = 1; //otomatik hangi sayfanın verilerinin getirilip başlayacağı
        public virtual int PageSize { get; set; } = 4; //bir sayfada görülen makale sayısı

        public virtual int TotalCount { get; set;}
        public virtual int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalCount,PageSize)); //ceiling ondalıklı sayıyı bir fazlasına atıyor Ör: 3.1 => 4 

        public virtual bool ShowPrevious => CurrentPage > 1;
        public virtual bool ShowNext => CurrentPage < TotalPages;

        public virtual bool IsAscending { get; set; } = false;
    }
}
