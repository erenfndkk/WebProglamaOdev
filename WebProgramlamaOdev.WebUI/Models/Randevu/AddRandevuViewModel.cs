namespace WebProgramlamaOdev.WebUI.Models.Randevu
{
    public class AddRandevuViewModel
    {
        public DateTime RandevuTarih { get; set; }
        public string SaatAraligi { get; set; }
        public int HastaId { get; set; }
        public int DoktorId { get; set; }
        public bool Durum { get; set; }
    }
}
