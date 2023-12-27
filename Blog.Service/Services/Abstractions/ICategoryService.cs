using Blog.Entity.DTOs.Categories;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface ICategoryService
    {
         Task<List<CategoryDto>> GetAllCategoriesNonDeleted();
         Task<List<CategoryDto>> GetAllCategoriesNonDeletedTake24();
         Task<List<CategoryDto>> GetAllCategoriesDeleted();

        Task<Category> GetCategoryByGuid(Guid id);
        Task CreateCategoryAsync(CategoryAddDto categoryAddDto);

        Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto);

        Task<string> SafeDeleteCategoryAsync(Guid categoryId);
        Task<string> UndoDeleteCategoryAsync(Guid categoryId);
    }
}
