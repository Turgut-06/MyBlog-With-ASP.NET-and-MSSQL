using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Abstractions
{
	public interface IRepository<T> where T : class,IEntityBase,new()
	{
		//Repository de ki public ve async kısmı yok somut halin soyut hali bu
		Task AddAsync(T entity);

		Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);

		Task<T> GetAsync(Expression<Func<T, bool>> predicate , params Expression<Func<T, object>>[] includeProperties);
	
		//id yi verip entity e erişmek için
	    Task<T> GetByGuidAsync(Guid id);

		Task<T> UpdateAsync(T entity);
		Task DeleteAsync(T entity);

		Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

		Task<int> CountAsync(Expression<Func<T, bool>> predicate=null); //article tablosunda kaç satır var bunu hesaplamak için
	
	}
}
