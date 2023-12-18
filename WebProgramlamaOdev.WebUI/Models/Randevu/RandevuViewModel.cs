namespace WebProgramlamaOdev.WebUI.Models.Randevu
{
    public class RandevuViewModel
    {
        public int RandevuId { get; set; }
        public DateTime RandevuTarih { get; set; }
        public string SaatAraligi { get; set; }
        public int DoktorId { get; set; }
        public int PoliklinikId { get; set; }
        public string HastaTC { get; set; }
        public bool Durum { get; set; }
    }
}
