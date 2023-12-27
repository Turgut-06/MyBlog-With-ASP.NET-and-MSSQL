using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Categories;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.AutoMapper.Categories
{
    public class CategoryProfile :Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryDto, Category>().ReverseMap(); //ikisini birbirine çeviriyor

            CreateMap<CategoryAddDto, Category>().ReverseMap(); //ikisini birbirine çeviriyor

            CreateMap<CategoryUpdateDto, Category>().ReverseMap(); //ikisini birbirine çeviriyor


        }
    }
}
