using Blog.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.FluentValidations
{
    public class ArticleValidator :AbstractValidator<Article> //makaleyi güncellerken ve eklerken validation işlemi yapacağım Ör. makale 50 karakterden az olamaz diyeceğim
    {

        public ArticleValidator()
        {
            RuleFor(x => x.Title)
            .NotEmpty()
            .NotNull()
            .MinimumLength(3)
            .WithName("Başlık");  //bu WithName i türkçeleştirirken kullanacağım automapper kısmında
                
            RuleFor(x => x.Content)
            .NotEmpty()
            .NotNull()
            .MinimumLength(3)
            .WithName("İçerik");
        }
    }
}
