using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaOdev.WebUI.Dtos
{
    public class CreateNewHastaDto
    {
        [Required(ErrorMessage ="Ad Alanı gereklidir")]
        public string HastaAd { get; set; }
        [Required(ErrorMessage = "Soyad Alanı gereklidir")]
        public string HastaSoyad { get; set; }
        [Required(ErrorMessage = "Mail Alanı gereklidir")]
        public string HastaMail { get; set; }
        [Required(ErrorMessage = "Telefon Alanı gereklidir")]
        public string HastaTelefon { get; set; }
        [Required(ErrorMessage = "TC Alanı gereklidir")]
        public string HastaTC { get; set; }
        [Required(ErrorMessage = "Şifre Alanı gereklidir")]
        public string HastaSifre { get; set; }
        [Required(ErrorMessage = "Şifre tekrar Alanı gereklidir")]
        [Compare("HastaSifre", ErrorMessage ="Şifreler uyuşmuyor")]
        public string HastaSifreTekrar { get; set; }
    }
}
