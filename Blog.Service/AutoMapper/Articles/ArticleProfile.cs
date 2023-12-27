using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.AutoMapper.Articles
{
    public class ArticleProfile :Profile
    {
        public ArticleProfile()
        {
            

            //articledto yu article a, article ı articledto ya map'leyebiliyorum reverse de tersine de olmasını sağlıyor
            CreateMap<ArticleDto,Article>().ReverseMap();

            CreateMap<ArticleUpdateDto, Article>().ReverseMap();

            CreateMap<ArticleUpdateDto, ArticleDto>().ReverseMap(); //dto üzerinden veri alışverişi yaptığımızdan bunu da map lememiz gerekiyor

            CreateMap<ArticleAddDto, Article>().ReverseMap();




        }
    }
}
