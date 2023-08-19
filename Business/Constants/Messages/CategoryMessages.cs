using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class CategoryMessages
    {
        public static string Added = "Kategori Eklendi.";
        
        public static string Deleted = "Kategori Silindi.";
        
        public static string Updated = "Kategori Güncellendi.";
        
        public static string RecordNotFound = "Kayıt Bulunamadı";

        public static string CategoryListed = "Kategori Listelendi";

        public static string CategoriesListed = "Kategoriler Listelendi";

        public static string CategoryNameInvalid = "Geçersiz Kategori İsmi";
        public static string CategoryNameCannotBeEmpty = "Kategori İsmi Boş Olamaz!";

        public static string CategoryDescriptionCannotBeEmpty = "Kategori Açıklaması Boş Olamaz!";
        public static string CategoryDescriptionInvalid = "Kategori Açıklaması Geçersiz!";

        public static string MaintenanceTime = "Sistem bakımı yapılmaktadır. Lütfen daha sonra tekrar deneyiniz!";
    }
}
