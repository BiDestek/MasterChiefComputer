using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class CustomerMessages
    {
        public static string Added = "Müşteri Eklendi";
        
        public static string Deleted = "Müşteri Silindi";
        
        public static string Updated = "Müşteri Güncellendi";
        
        public static string RecordNotFound = "Kayıt Bulunamadı";

        public static string CustomerListed = "Müşteri Listelendi";

        public static string CustomersListed = "Müşteriler Listelendi";

        public static string CustomerNameInvalid = "Şirket İsmi Geçersiz";
        public static string CustomerNameCannotBeEmpty = "Şirket İsmi Boş Olamaz!";

        public static string PhoneNumberInvalid = "Geçersiz Telefon Numarası";
        public static string PhoneNumberCannotBeEmpty = "Telefon Numarası Boş Olamaz!";

        public static string CustomerCityCannotBeEmpty = "Şehir İsmi Boş Olamaz!";
        public static string CustomerCityInvalid = "Geçersiz Şehir İsmi";

        public static string AddressCannotBeEmpty = "Adres Boş Olamaz!";
        public static string CustomerAddressInvalid = "Geçersiz Adres";

        public static string RegionCannotBeEmpty = "İl Bilgisi Boş Olamaz!";
        public static string CustomerRegionInvalid = "Geçersiz İl İsmi";

        public static string CountryCannotBeEmpty = "Ülke İsmi Boş Olamaz!";
        public static string CustomerCountryInvalid = "Geçersiz Ülke İsmi";

        public static string PostalCodeCannotBeEmpty = "Posta Kodu Boş Olamaz!";
        public static string CustomerPostalCodeInvalid = "Geçersiz Posta Kodu";



        public static string MaintenanceTime = "Sistem bakımı yapılmaktadır. Lütfen daha sonra tekrar deneyiniz!";
        
    }
}
