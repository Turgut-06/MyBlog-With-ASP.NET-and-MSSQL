using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.DTOs.Categories
{
    public class CategoryDto
    {

        public Guid Id { get; set; } //seçtiğimizdeki isim Id ye dönüştürülüp işleme sokulacağı için Id si de lazım
        public string Name { get; set; }

        public  string CreatedBy { get; set; } 

        public  DateTime CreatedDate { get; set; } 

        public bool IsDeleted { get; set; }



    }
}
