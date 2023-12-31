﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class ProductMessages
    {
        public static string Added = "Ürün Eklendi";
        
        public static string Deleted = "Ürün Silindi";
        
        public static string Updated = "Ürün Güncellendi";
        
        public static string RecordNotFound = "Kayıt Bulunamadı";

        public static string ProductListed = "Ürün Listelendi";

        public static string ProductsListed = "Ürünler Listelendi";

        public static string ProductDetailsListed = "Ürün Detayları Listelendi";

        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";
        public static string ProductNameCannotBeEmpty = "Ürün İsmi Boş Olamaz!";

        public static string UnitsOnOrderCannotBeEmpty = "Sipariş Adedi Boş Olamaz!";
        public static string UnitsOnOrderCannotBeNegativeValue = "Sipariş Adedi Negatif Olamaz!";

        public static string UnitsInStockCannotBeEmpty = "Stok Miktarı Boş Olamaz!";

        public static string UnitPriceCannotBeNegativeValue = "Birim Fiyatı Negatif Olamaz!";
        public static string UnitPriceCannotBeEmpty = "Birim Fiyatı Boş Olamaz!";
        public static string UnitPriceInvalidGreaterThanOrEqualTo = "Ürün Kategorisi için Birim Fiyat Değeri 10 TL den küçük olamaz!";

        public static string MaintenanceTime = "Sistem bakımı yapılmaktadır. Lütfen daha sonra tekrar deneyiniz!";

        public static string ProductNameAlreadyExists = "Bu İsimde Zaten Başka Bir Ürün Bulunmaktadır";

        public static string CategoryLimitValueCannotBeExceeded = "Kategori sınır değeri aşılamaz.";

        public static string ProductPriceCannotBeLessThan = "Ürün Fiyatı 10 liradan az olamaz";

        public static string CategoryLimitValueExceeded = "Kategori sınır değeri aşıldı.";
    }
}
