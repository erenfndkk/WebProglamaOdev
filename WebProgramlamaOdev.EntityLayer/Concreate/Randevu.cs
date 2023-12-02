using System;
using System.Collections.Generic;
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

       // public int HastaId { get; set; }
       // public Hasta Hasta { get; set; }
        public int DoktorId { get; set; }
        //public Doktor Doktor { get; set; }
        public bool Durum { get; set; }
         
    }
}
