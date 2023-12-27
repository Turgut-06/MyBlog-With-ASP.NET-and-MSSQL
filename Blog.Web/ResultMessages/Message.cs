namespace Blog.Web.ResultMessages
{
    public static class Message
    {
        public static class Article
        {
            public static string Add(string articleTitle)
            {

                // $ işareti ile değişkeni stringin içine köşeli parantezle gömebilmeni sağlar
                return $"{articleTitle} başlıklı makale başarıyla eklenmiştir";
            }

            public static string Update(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla güncellenmiştir";

            }

            public static string Delete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla silinmiştir";

            }
            public static string UndoDelete(string articleTitle)
            {
                return $"{articleTitle} başlıklı makale başarıyla geri alınmıştır";

            }
        }

        public static class Category
        {
            public static string Add(string categoryName)
            {

                // $ işareti ile değişkeni stringin içine köşeli parantezle gömebilmeni sağlar
                return $"{categoryName} isimli kategori başarıyla eklenmiştir";
            }

            public static string Update(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla güncellenmiştir";

            }

            public static string Delete(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla silinmiştir";

            }

            public static string UndoDelete(string categoryName)
            {
                return $"{categoryName} isimli kategori başarıyla geriye döndürülmüştür";

            }
        }

        public static class User
        {
            public static string Add(string userName)
            {

                // $ işareti ile değişkeni stringin içine köşeli parantezle gömebilmeni sağlar
                return $"{userName} email adresli kullanıcı başarıyla eklenmiştir";
            }

            public static string Update(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla güncellenmiştir";

            }

            public static string Delete(string userName)
            {
                return $"{userName} email adresli kullanıcı başarıyla silinmiştir";

            }
        }
    }
}
