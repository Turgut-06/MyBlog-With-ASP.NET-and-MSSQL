﻿using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blog.Web.Areas.Admin.Controllers
{
    //önyüzde de HomeController olduğu için bunun areasını belirtmem gerekiyor
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IDashboardService dashboardService;

        public HomeController(IArticleService articleService,IDashboardService dashboardService)
        {
            this.articleService = articleService;
            this.dashboardService = dashboardService;
        }
        public async Task<IActionResult> Index()
        {
            var articles=await articleService.GetAllArticleWithCategoryNonDeletedAsync();
            return View(articles);
        }

        [HttpGet]
        public async Task<IActionResult> YearlyArticleCounts()
        {
            var count = await dashboardService.GetYearlyArticleCounts();
            return Json(JsonConvert.SerializeObject(count)); //dizi olarak yollamamız için serializeObjecti yapmamız gerekiyor
        }

        [HttpGet]
        public async Task<IActionResult> TotalArticleCount()
        {
            var count = await dashboardService.GetTotalArticleCount();
            return Json(count); //dizi olarak yollamamız için serializeObjecti yapmamız gerekiyor
        }

        [HttpGet]
        public async Task<IActionResult> TotalCategoryCount()
        {
            var count = await dashboardService.GetTotalCategoryCount();
            return Json(count); //dizi olarak yollamamız için serializeObjecti yapmamız gerekiyor
        }

    }
}
