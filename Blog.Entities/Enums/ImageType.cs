using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Enums
{
    public enum ImageType
    {
        User=1,  //verilen resim kullanıcıya mı ait yoksa post yapılan article a mı onun için yazıyoruz
        Post=0, //article a giden resmi belirtiyor

    }
}
