using Blog.Core.Entities;
using Blog.Data.Context;
using Blog.Data.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Repositories.Concretes
{
	public class Repository<T> : IRepository<T> where T : class, IEntityBase, new()
	{
		private readonly AppDbContext dbContext;

		public Repository(AppDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		//dbContext i set ettiğimiz bir fonksiyon yazdık her seferinde yazmamak için
		private DbSet<T> Table { get => dbContext.Set<T>(); }


		//1.si isDeleted ları false olanları getirmemizi sağlar,2.si birbirine bağlı olan bire çok ilişki gibi döndürmemizi sağlar
		public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> query = Table;
			if(predicate != null)
				query = query.Where(predicate);
			if(includeProperties.Any())
				foreach(var property in includeProperties)
					query=query.Include(property);

			return await query.ToListAsync();
        }
		
		
		
		
		//Task; void in asenkron programlamadaki karşılığı
		public async Task AddAsync(T entity)
		{
			await Table.AddAsync(entity);
		}

		public async Task<T> GetAsync(Expression<Func<T, bool>> predicate  , params Expression<Func<T, object>>[] includeProperties)
		{
			IQueryable<T> query = Table;
			query = query.Where(predicate);

			if (includeProperties.Any())
				foreach(var property in includeProperties)
					query=query.Include(property);

            return await query.SingleAsync();
		}

		public async Task<T> GetByGuidAsync(Guid id)
		{
			return await Table.FindAsync(id);
		}

		public async Task<T> UpdateAsync(T entity)
		{
			await Task.Run(() => Table.Update(entity)); //asenkron halini bozmamak için bunu yazıyoruz
			return entity;
		}

		public async Task DeleteAsync(T entity)
		{
			await Task.Run(()=> Table.Remove(entity));
		}

		public async Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
		{
			return await Table.AnyAsync(predicate);
		}

		public async Task<int> CountAsync(Expression<Func<T, bool>> predicate= null)
		{
			if (predicate is not null)
			   return await Table.CountAsync(predicate);
			return await Table.CountAsync();
		}
	}
}
