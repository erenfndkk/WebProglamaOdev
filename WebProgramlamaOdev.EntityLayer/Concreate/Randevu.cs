using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.EntityLayer.Concreate
{
    public class Randevu
    {
        public int RandevuId { get; set; }
        public DateTime RandevuTarih { get; set; }
        public string SaatAraligi { get; set; }
        public int PoliklinikId { get; set; }
        //public Poliklinik Poliklinik { get; set; }
        public int DoktorId { get; set; }
        //public Doktor Doktor { get; set; }
        public bool Durum { get; set; }
         
    }
}
