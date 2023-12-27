using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using Blog.Entity.Enums;
using Blog.Service.Helpers.Images;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Extensions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Image = Blog.Entity.Entities.Image;

namespace Blog.Service.Services.Concrete
{
	public class ArticleService : IArticleService
	{
		private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper ımageHelper;
        private readonly ClaimsPrincipal _user;
        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper,IHttpContextAccessor httpContextAccessor,IImageHelper ımageHelper)
		{
			this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.ımageHelper = ımageHelper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task<ArticleListDto> GetAllByPagingAsync(Guid? categoryId,int currentPage=1,int pageSize=4,bool isAscending=false)
        {
            pageSize = pageSize > 20 ? 20 : pageSize;
            var articles = categoryId == null
                ? await unitOfWork.GetRepository<Article>().GetAllAsync(a => !a.IsDeleted, a => a.category, i => i.Image, u => u.User)
                : await unitOfWork.GetRepository<Article>().GetAllAsync(a => a.categoryId == categoryId && !a.IsDeleted,
                    a => a.category, i => i.Image, u => u.User);
            var sortedArticles = isAscending
                ? articles.OrderBy(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList()
                : articles.OrderByDescending(a => a.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            return new ArticleListDto
            {
                Articles = sortedArticles,
                CategoryId = categoryId == null ? null : categoryId.Value,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = articles.Count,
                IsAscending = isAscending,
             
                
            };
        }
        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
			//var userId = Guid.Parse("FB4AEF20-2643-442D-8840-A32E17477CB1");
			var userId = _user.GetLoggedInUserId(); //_user ın yolunu yukarıda belirlediğim için direk static metoda ulaşabiliyorum
			var userEmail=_user.GetLoggedInEmail();

			var imageUpload = await ımageHelper.Upload(articleAddDto.Title, articleAddDto.Photo, ImageType.Post);

            Image image = new(imageUpload.FullName, articleAddDto.Photo.ContentType, userEmail); // Imagehelper ile Entity deki Image sınıfını eşliyorum
            await unitOfWork.GetRepository<Image>().AddAsync(image); //saveasync yapmadığımız için direk veritabanına gitmese de veritabanı davranışımız belli add olarak
            

            var article = new Article(articleAddDto.Title,articleAddDto.Content,userId,userEmail,articleAddDto.CategoryId,image.Id);


            await unitOfWork.GetRepository<Article>().AddAsync(article);
			await unitOfWork.SaveAsync();
        }
       

        public async Task<List<ArticleDto>> GetAllArticleWithCategoryNonDeletedAsync()
		{

			//unitOfWork üzerinden generic olarak istediğim repository e ordan da repository içindeki fonksiyonlara erişiyorum
			//unitOfWork yazmamın nedeni dispose işlemiyle kaynakları düzgün kullanabilmem için
			var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted ,  x=> x.category);
			var map=mapper.Map<List<ArticleDto>>(articles);
			
			return map;
		}

       
        public async Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId) //liste değil id ye göre tek bir article dönüyor
        {
           
			
            //unitOfWork üzerinden generic olarak istediğim repository e ordan da repository içindeki fonksiyonlara erişiyorum
            //unitOfWork yazmamın nedeni dispose işlemiyle kaynakları düzgün kullanabilmem için

            
			var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleId , x => x.category , x=> x.Image);
            var map = mapper.Map<ArticleDto>(article);
            
			return map;
			
        }

		public async Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto)
		{

            var userEmail = _user.GetLoggedInEmail();

            var article = await unitOfWork.GetRepository<Article>().GetAsync(x => !x.IsDeleted && x.Id == articleUpdateDto.Id, x => x.category, i => i.Image);

           if(articleUpdateDto.Photo !=null) //makaleyi güncelleyen photo üstünde değişiklik yaptığında
			{

              
                ımageHelper.Delete(article.Image.FileName);

                
                var imageUpload = await ımageHelper.Upload(articleUpdateDto.Title, articleUpdateDto.Photo, ImageType.Post);

                Image image = new(imageUpload.FullName, articleUpdateDto.Photo.ContentType, userEmail);
                await unitOfWork.GetRepository<Image>().AddAsync(image);

                article.categoryId = articleUpdateDto.CategoryId;
                article.Title = articleUpdateDto.Title;
                article.Content = articleUpdateDto.Content;
                article.Image.FileName= image.FileName; //resmi değiştirdiğim için fileName leri de güncelliyorum
                 // article.Id=image.Id


            }

            else if (articleUpdateDto.Photo == null ) 
            {
               
                article.categoryId = articleUpdateDto.CategoryId;
                article.Title = articleUpdateDto.Title;
                article.Content = articleUpdateDto.Content;




            }

            mapper.Map(article, articleUpdateDto);

            article.ModifiedDate = DateTime.Now;
            article.ModidifiedBy = _user.GetLoggedInEmail();



            await unitOfWork.GetRepository<Article>().UpdateAsync(article);
			await unitOfWork.SaveAsync();

			return article.Title;
        }

		public async Task<string> SafeDeleteArticleAsync(Guid articleId)
		{
			var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId); //view dan tıklanan ve devamında gelen articleId ile eşleşen article ı veritabanından bulup getiriyorum

			article.IsDeleted = true;
            article.DeletedDate = DateTime.Now;
			article.DeletedBy= _user.GetLoggedInEmail();

			await unitOfWork.GetRepository<Article>().UpdateAsync(article); // article ı güncelledik IsDeleted ı true olarak güncellendiği için Index de gözükmeyecek
			await unitOfWork.SaveAsync();

			return article.Title;	

		}

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => x.IsDeleted, x => x.category);
            var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
        }

        public async Task<string> UndoDeleteArticleAsync(Guid articleId) //sildiğimiiz geri döndürebilmek için
        {
            var article = await unitOfWork.GetRepository<Article>().GetByGuidAsync(articleId); //view dan tıklanan ve devamında gelen articleId ile eşleşen article ı veritabanından bulup getiriyorum

            article.IsDeleted = false;
            article.DeletedDate = null;
            article.DeletedBy = null;

            await unitOfWork.GetRepository<Article>().UpdateAsync(article); // article ı güncelledik IsDeleted ı true olarak güncellendiği için Index de gözükmeyecek
            await unitOfWork.SaveAsync();

            return article.Title;
        }

        public async Task<ArticleListDto> SearchAsync(string keyword, int currentPage = 1, int pageSize = 3, bool isAscending = false)
        {
            pageSize = pageSize > 20 ? 20 : pageSize;

            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(a => !a.IsDeleted && (a.Title.Contains(keyword) || a.Content.Contains(keyword) || a.category.Name.Contains(keyword)),
                a => a.category, i => i.Image, u => u.User);

            var sortedArticles = isAscending
                ? articles.OrderBy(x => x.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList()
                : articles.OrderByDescending(x => x.CreatedDate).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

            return new ArticleListDto
            {
                Articles = sortedArticles,
                CurrentPage = currentPage,
                PageSize = pageSize,
                TotalCount = articles.Count,
                IsAscending = isAscending
            };
        }

        
    }
}
