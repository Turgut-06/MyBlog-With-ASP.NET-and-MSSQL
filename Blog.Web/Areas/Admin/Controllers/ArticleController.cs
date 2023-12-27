using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Categories;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Blog.Service.Services.Extensions;
using Blog.Web.Consts;
using Blog.Web.ResultMessages;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using System;
using static Blog.Web.ResultMessages.Message;
using Article = Blog.Entity.Entities.Article;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly ICategoryService categoryService;
        private readonly IMapper mapper;
        private readonly IValidator<Article> validator;
        private readonly IToastNotification toast;

        public ArticleController(IArticleService articleService, ICategoryService categoryService, IMapper mapper,IValidator<Article> validator,IToastNotification toast)
        {
            this.articleService = articleService;
            this.categoryService = categoryService;
            this.mapper = mapper;
            this.validator = validator;
            this.toast = toast;
        }

        [HttpGet]
       [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin},{RoleConsts.User}")]

        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticleWithCategoryNonDeletedAsync(); //map lemeyi controller üstünden değil servisler üstünden yapıyoruz
            return View(articles);
        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin},{RoleConsts.User}")]

        public async Task<IActionResult> DeletedArticle()
        {
            var articles = await articleService.GetAllArticlesWithCategoryDeletedAsync(); //map lemeyi controller üstünden değil servisler üstünden yapıyoruz
            return View(articles);
        }


        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin}")]

        public async Task<IActionResult> Add()
        {
            var categories=await categoryService.GetAllCategoriesNonDeleted(); //article dto nun içinde de category liste tipinde  
            return View(new ArticleAddDto { Categories =categories });
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin}")]

        public async Task<IActionResult> Add(ArticleAddDto articleAddDto)
        {
            var map=mapper.Map<Article>(articleAddDto); //mapping işlemi yapıyoruz article olarak geliyor articleAddto ya map liyorum
            var result=await validator.ValidateAsync(map); //sistemin düzgün çalışması hata bildirmesi için eklerken fluent validation işleminden yararlanıyorum

            if(result.IsValid)
            {

                await articleService.CreateArticleAsync(articleAddDto);  //başarılıysa ekleme işlemini yapacak ve index e gidecek
                toast.AddSuccessToastMessage(Message.Article.Add(articleAddDto.Title),new ToastrOptions {Title="başarılı" });
                return RedirectToAction("Index", "Article", new { Area = "Admin" });
            }
            else
            {
                result.AddToModelState(this.ModelState);    //başarısızsa bize hatayı gösterip sonrasında aynı view ı  geri dönecek
               
            }

            var categories = await categoryService.GetAllCategoriesNonDeleted(); //article dto nun içinde de category liste tipinde  
            return View( new ArticleAddDto { Categories = categories }); //redirectToAction ve modelin birlikte kullanımı



        }

        [HttpGet]
        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin}")]

        public async Task<IActionResult> Update(Guid articleId)
        {



            var article= await articleService.GetArticleWithCategoryNonDeletedAsync(articleId);
            var categories= await categoryService.GetAllCategoriesNonDeleted();

            var articleUpdateDto =mapper.Map<ArticleUpdateDto>(article);
            articleUpdateDto.Categories = categories; //kategori ve article ın maplenmiş halini oluşturuyorum

            return View(articleUpdateDto); //model olarak articleUpdateDto yu çağırıyorum
           
        }

        [HttpPost]
        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin}")]

        public async Task<IActionResult> Update(ArticleUpdateDto articleUpdateDto)
        {

            var map = mapper.Map<Article>(articleUpdateDto); //mapping işlemi yapıyoruz article olarak geliyor articleAddto ya map liyorum
            var result = await validator.ValidateAsync(map);

            if( result.IsValid)
            {
                var title =await articleService.UpdateArticleAsync(articleUpdateDto);  //güncellenen title ı veya var olan title ı alıp toast mesajıma yazdırıyorum
                toast.AddSuccessToastMessage(Message.Article.Update(title),new ToastrOptions { Title="işlem başarılı"});
                return RedirectToAction("Index", "Article", new { Area = "Admin" });

            }
            else
            {
                result.AddToModelState(this.ModelState);
            }

            var categories = await categoryService.GetAllCategoriesNonDeleted();
            articleUpdateDto.Categories = categories;
            return View(articleUpdateDto);

        }

        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin}")]
        public async Task<IActionResult> Delete(Guid articleId)
        {

            var title=await articleService.SafeDeleteArticleAsync(articleId);
            toast.AddSuccessToastMessage(Message.Article.Delete(title), new ToastrOptions { Title = "işlem başarılı" });
            return RedirectToAction("Index", "Article", new { Area = "Admin" });

        }

        [Authorize(Roles = $"{RoleConsts.Superadmin},{RoleConsts.Admin}")]
        public async Task<IActionResult> UndoDelete(Guid articleId)
        {

            var title = await articleService.UndoDeleteArticleAsync(articleId);
            toast.AddSuccessToastMessage(Message.Article.UndoDelete(title), new ToastrOptions { Title = "işlem başarılı" });
            return RedirectToAction("Index", "Article", new { Area = "Admin" });

        }
    }
}
