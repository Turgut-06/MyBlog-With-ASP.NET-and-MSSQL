using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
	public interface IArticleService
	{

		
		//asenkron metot olduğundan Task içine alıyoruz
		Task<List<ArticleDto>> GetAllArticleWithCategoryNonDeletedAsync();
		Task<List<ArticleDto>> GetAllArticlesWithCategoryDeletedAsync();

        Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId);

        Task CreateArticleAsync(ArticleAddDto articleAddDto);

		Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);

		Task<string> SafeDeleteArticleAsync(Guid articleId);
		Task<string> UndoDeleteArticleAsync(Guid articleId);
		Task<ArticleListDto> GetAllByPagingAsync(Guid? categoryId, int currentPage = 1, int pageSize=4, bool isAscending = false);

        Task<ArticleListDto> SearchAsync(string keyword, int currentPage = 1, int pageSize = 3, bool isAscending = false);



    }
}
