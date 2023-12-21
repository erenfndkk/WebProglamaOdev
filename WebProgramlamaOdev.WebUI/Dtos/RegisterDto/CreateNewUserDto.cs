using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaOdev.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad Alanı gereklidir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad Alanı gereklidir")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı Alanı gereklidir")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mail Alanı gereklidir")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "TC Alanı gereklidir")]
        public string UserTC { get; set; }
        [Required(ErrorMessage = "Şifre Alanı gereklidir")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre tekrar Alanı gereklidir")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
