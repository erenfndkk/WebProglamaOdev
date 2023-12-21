namespace WebProgramlamaOdev.WebUI.Models.Doktor
{
    public class AddDoktorViewModel
    {
        public string DoktorAd { get; set; }
        public string DoktorSoyad { get; set; }
        public string ImageUrl { get; set; }
        public int AnaBilimDaliId { get; set; }
        public int PoliklinikId { get; set; }
    }
}
