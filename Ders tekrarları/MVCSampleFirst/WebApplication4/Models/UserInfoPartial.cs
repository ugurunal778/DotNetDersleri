using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public partial class UserInfo
    {
        [DisplayName("Id Görünen İsim")]
        public int Id { get; set; }
        [DisplayName("İsim")]
        public string FirstName { get; set; }
        [DisplayName("Soyisim")]
        public string LastName { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        [DisplayName("Şifre")]
        public string Password { get; set; }
        [DisplayName("Güncelleme Tarihi")]
        public System.DateTime ModifiedDate { get; set; }
        [DisplayName("Oluşturulma Tarihi")]
        public System.DateTime CreatedDate { get; set; }
    }
}