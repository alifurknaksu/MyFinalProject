using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Kategorideki ürün ekleme limitini aştınız.";
        public static string ProductNameAlreadyExist = "Böyle bir ürün zaten bulunuyor";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı kayıt oldu.";
        public static string UserNotFound = "Böyle bir kullanıcı bulunamadı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Böyle bir kullanıcı zaten var.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string PasswordError = "Şifre hatalı.";
    }
}
