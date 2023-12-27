using Blog.Entity.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.FluentValidations
{
    public class CategoryValidator : AbstractValidator<Category> //serviceLayerExtension daki assembly den dolayı bunu implemente alan bütün sınıflarda validator işlemini otomatik tanımlıyor articleValidator ı oluşturarak bunu gerçekleştirdik
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name)
           .NotEmpty()
           .NotNull()
           .MinimumLength(3)
           .MaximumLength(100).
           WithName("Kategori Adı");
        }
    }
}
