using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
	public  class Article : EntityBase
	{
        //Article sınıfını new lediğimde direk neler girmek gerektiğini bilmek için constructor oluşturmak zorundayım.
        public Article() //boş geçebilmemi sağlar
        {
            
        }

        public Article(string title,string content,Guid userId, string createdBy,Guid categoryid,Guid imageId) //bu contructor boş geçilemeyen ve default olarak değeri girilmeyen alanları görmemi sağlar nesne oluşturunca
        {
            Title = title;
			Content = content;
			UserId = userId;
			categoryId = categoryid;
			ImageId = imageId;
			CreatedBy = createdBy;

        }

        //makalemizin başlığı ve içeriği olacak
        public string Title { get; set; }

		public string Content { get; set; }

		//makalemizin kaç kere görüntülendiği
		public int viewCount { get; set; } =0;

		public Guid categoryId { get; set; }

		public Category category { get; set; }

		public Guid? ImageId { get; set; } //foreign key olarak buraya yazdık
		                                  //Image tablosunu buraya bağladım
										  //nullable yapmayı unutma(test yaparken sıkıntı olmasın diye nullable ancak her makalenin bir resmi olmak zorunda olacak)
		public Image Image { get; set; }

		public Guid UserId { get; set; } //her makalenin bir tane yazarı olacağından

		public AppUser User { get; set; }


		
    }
	
}
