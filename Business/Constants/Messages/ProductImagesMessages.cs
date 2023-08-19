using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class ProductImagesMessages
    {
        public static string Added = "Ürün Resmi Eklendi";
        
        public static string Deleted = "Ürün Resmi Silindi";
        
        public static string Updated = "Ürün Resmi Güncellendi";
        
        public static string RecordNotFound = "Kayıt Bulunamadı";

        public static string ProductImageListed = "Ürün Resmi Listelendi";

        public static string ProductImagesListed = "Ürün Resimleri Listelendi";

        public static string ProductImageNameInvalid = "Ürün Resim İsmi Geçersiz";
        public static string ProductImageNameCannotBeEmpty = "Ürün Resim İsmi Boş Olamaz!";
        public static string ProductImagePathCannotBeEmpty = "Resim Dosyasının Yerini Giriniz!";

        public static string ProductIdCannotBeEmpty = "Ürün ID'sini Giriniz!";
        public static string ProductIdCannotBeNegativeValue = "Ürün ID'si Negatif Olamaz!";

        public static string MaintenanceTime = "Sistem bakımı yapılmaktadır. Lütfen daha sonra tekrar deneyiniz!";

        public static string ImageNameAlreadyExists = "Bu İsimde Zaten Başka Bir Ürün Resmi Bulunmaktadır";

        public static string ProductImageLimitValueCannotBeExceeded = "Ürün Resmi sınır değeri aşılamaz.";

        public static string ProductImageLimitValueExceeded = "Ürün Resmi sınır değeri aşıldı.";
    }
}
