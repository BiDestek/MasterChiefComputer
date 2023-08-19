using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class OrderDetailMessages
    {
        public static string Added = "Sipariş Detayı Eklendi";
        
        public static string Deleted = "Sipariş Detayı Silindi";
        
        public static string Updated = "Sipariş Detayı Güncellendi";
        
        public static string RecordNotFound = "Kayıt Bulunamadı";

        public static string OrderDetailListed = "Sipariş Detayı Listelendi";

        public static string OrderDetailsListed = "Sipariş Detayları Listelendi";

        public static string UnitPriceCannotBeNegativeValue = "Birim Fiyatı Negatif Olamaz!";
        public static string UnitPriceCannotBeEmpty = "Birim Fiyatı Boş Olamaz!";

        public static string DiscountCannotBeNegativeValue = "indirim Oranı Negatif Olamaz!";

        public static string QuantityCannotBeEmpty = "Miktar Boş Olamaz!";

        public static string MaintenanceTime = "Sistem bakımı yapılmaktadır. Lütfen daha sonra tekrar deneyiniz!";
       
    }
}
