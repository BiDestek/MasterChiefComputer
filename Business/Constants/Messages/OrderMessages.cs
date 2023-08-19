using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class OrderMessages
    {
        public static string Added = "Sipariş Eklendi";
        
        public static string Deleted = "Sipariş Silindi";
        
        public static string Updated = "Sipariş Güncellendi";
        
        public static string RecordNotFound = "Kayıt Bulunamadı";

        public static string OrderListed = "Sipariş Listelendi";

        public static string OrdersListed = "Siparişler Listelendi";

        public static string OrderDetailsListed = "Sipariş Detayları Listelendi";

        public static string OrderDateCannotBeEmpty = "Tarih Boş Olamaz!";

        public static string CustomerIdCannotBeEmpty = "Müşteri Numarası Boş Olamaz!";
        public static string CustomerIdGreaterThanZero = "Müşteri Numarası Sıfırdan Büyük Olmalı";

        public static string MaintenanceTime = "Sistem bakımı yapılmaktadır. Lütfen daha sonra tekrar deneyiniz!";
    }
}
