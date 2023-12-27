using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Categories;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Extensions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IMapper mapper;
        private readonly ClaimsPrincipal _user;

        private readonly IUnitOfWork unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork,IMapper mapper,IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            Mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;

        }

        public IMapper Mapper { get; }

        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()

        {
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map=Mapper.Map<List<CategoryDto>>(categories); //dto olarak da dönebilmemiz için
            return map;
        }

        public async Task<List<CategoryDto>> GetAllCategoriesNonDeletedTake24()
        {
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map = Mapper.Map<List<CategoryDto>>(categories); //dto olarak da dönebilmemiz için
            return map.Take(24).ToList();
        }


        public async Task CreateCategoryAsync(CategoryAddDto categoryAddDto)
        {
            var userEmail = _user.GetLoggedInEmail();

            Category category = new Category(categoryAddDto.Name, userEmail);
            await unitOfWork.GetRepository<Category>().AddAsync(category);
            await unitOfWork.SaveAsync();

        }

        public async Task<Category> GetCategoryByGuid(Guid id)
        {
            var category= await unitOfWork.GetRepository<Category>().GetByGuidAsync(id);
            return  category;
        }

        public async Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto)
        {
            var userEmail = _user.GetLoggedInEmail();
            var category = await unitOfWork.GetRepository<Category>().GetAsync(x => !x.IsDeleted && x.Id == categoryUpdateDto.Id);

            category.Name = categoryUpdateDto.Name;
            category.ModidifiedBy = userEmail;
            category.ModifiedDate = DateTime.Now;


            await unitOfWork.GetRepository<Category>().UpdateAsync(category);
            await unitOfWork.SaveAsync();

            return category.Name;
        }

      
        public async Task<string> SafeDeleteCategoryAsync(Guid categoryId)
        {
            var category = await unitOfWork.GetRepository<Category>().GetByGuidAsync(categoryId); //view dan tıklanan ve devamında gelen articleId ile eşleşen article ı veritabanından bulup getiriyorum

            category.IsDeleted = true;
            category.DeletedDate = DateTime.Now;
            category.DeletedBy = _user.GetLoggedInEmail();

            await unitOfWork.GetRepository<Category>().UpdateAsync(category); // category ı güncelledik IsDeleted ı true olarak güncellendiği için Index de gözükmeyecek
            await unitOfWork.SaveAsync();

            return category.Name;

        }

        public async Task<List<CategoryDto>> GetAllCategoriesDeleted()
        {
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x => x.IsDeleted);
            var map = Mapper.Map<List<CategoryDto>>(categories); //dto olarak da dönebilmemiz için
            return map;
        }

        public async Task<string> UndoDeleteCategoryAsync(Guid categoryId)
        {
            var category = await unitOfWork.GetRepository<Category>().GetByGuidAsync(categoryId); //view dan tıklanan ve devamında gelen articleId ile eşleşen article ı veritabanından bulup getiriyorum

            category.IsDeleted = false;
            category.DeletedDate = null;
            category.DeletedBy = null;

            await unitOfWork.GetRepository<Category>().UpdateAsync(category); // category ı güncelledik IsDeleted ı true olarak güncellendiği için Index de gözükmeyecek
            await unitOfWork.SaveAsync();

            return category.Name;
        }

       
    }
}
