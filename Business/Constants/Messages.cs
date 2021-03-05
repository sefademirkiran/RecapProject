using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araç Eklendi";
        public static string CarAddedInvalid = "Araç Ekleme Başarısız";
        public static string CarDeleted = "Araç Silindi.";
        public static string CarUpdated = "Araç Güncellendi";
        public static string CarUpdatedInvalid = "Araç Güncelleme Başarız!";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarListed = "Araçlar Listelendi";
        public static string BrandAdded = "Marka Eklendi";
        public static string BrandInvalid = "Marka Ekleme Başarısız";
        public static string BrandUpdeted = "Marka Güncellendi";
        public static string BrandUpdateInvalid = "Marka Güncelleme Başarısız!";
        public static string BrandDeleted ="Marka Silindi";
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdeted = "Renk Güncellendi.";

        public static string UserAdded = "Kullanıcı Eklendi";

        public static string UserDeleted = "Kullanıcı Silindi. ";

        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";

        public static string CustomerDeleted = "Müşteri Silindi";

        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string CustomerListed = "Müşteri Listelendi";

        public static string RentalAdded = "Kiralama Eklendi";

        public static string RentalDeleted = "Kiralama Silindi ";

        public static string RentalUpdated = "Kiralama Güncellendi";

        public static string RentalListed { get; internal set; }
    }
}
