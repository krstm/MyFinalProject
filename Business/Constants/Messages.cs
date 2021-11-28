using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime { get; } = "Sistem bakımda";
        public static string ProductsListed { get; } = "Ürünler listelendi";

        public static string ProductAdded { get; } = "Ürün eklendi";
        public static string ProductNameInvalid { get; } = "Ürün ismi geçersiz";
        public static string ProductCountOfCategoryError { get; } = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists { get; } = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceeded { get; } = "Kategori limiti aşıldığı için yeni ürün eklemiyor";
        public static string AuthorizationDenied { get; } = "Yetkiniz yok";
        public static string UserRegistered { get; } = "Kullanıcı kayıt oldu";
        public static string UserNotFound { get; } = "Kullanıcı bulunamadı";
        public static string PasswordError { get; } = "Şifre hatası";
        public static string SuccessfulLogin { get; } = "Giriş başarılı";
        public static string UserAlreadyExists { get; } = "Kullanıcı zaten var";
        public static string AccessTokenCreated { get; } = "Access Token oluşturuldu";
        public static string ProductUpdated { get; } = "Güncellendi";
    }
}
