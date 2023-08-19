using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public class SupplierMessages
    {
        public static string Added = "Tedarikçi Eklendi";
        
        public static string Deleted = "Tedarikçi Silindi";
        
        public static string Updated = "Tedarikçi Güncellendi";
        
        public static string RecordNotFound = "Kayıt Bulunamadı";

        public static string SupplierListed = "Tedarikçi Listelendi";

        public static string SuppliersListed = "Tedarikçiler Listelendi";

        public static string SupplierCompanyNameInvalid = "Şirket Ünvanı Geçersiz";
        public static string SupplierCompanyNameCannotBeEmpty = "Şirket Ünvanı Boş Olamaz!";

        public static string SupplierContactNameInvalid = "İrtibat Kurulacak Kişi İsmi Geçersiz";
        public static string SupplierContactNameCannotBeEmpty = "İrtibat Kurulacak Kişi İsmi Boş Olamaz!";

        public static string SupplierCityInvalid = "Şehir İsmi Geçersiz";
        public static string SupplierCityCannotBeEmpty = "Şehir İsmi Boş Olamaz!";

        public static string SupplierContactTitleInvalid = "Kişi Ünvanı Geçersiz";
        public static string SupplierContactTitleCannotBeEmpty = "Kişi Ünvanı Boş Olamaz!";

        public static string SupplierAddressInvalid = "Adres Geçersiz";
        public static string SupplierAddressCannotBeEmpty = "Adres Boş Olamaz!";

        public static string SupplierPhoneNumberInvalid = "Telefon Numarası Geçersiz";
        public static string SupplierPhoneNumberCannotBeEmpty = "Telefon Numarası Boş Olamaz!";

        public static string MaintenanceTime = "Sistem bakımı yapılmaktadır. Lütfen daha sonra tekrar deneyiniz!";
    }
}
