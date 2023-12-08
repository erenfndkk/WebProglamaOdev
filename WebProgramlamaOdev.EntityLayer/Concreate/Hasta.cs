using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.EntityLayer.Concreate
{
    public class Hasta
    {
        public int HastaId { get; set; }
        public string HastaAd { get; set; }
        public string HastaSoyad { get; set; }
        public string HastaMail { get; set; }
        public string HastaSifre { get; set; }
       // public ICollection<Randevu> Randevular { get; set; }
    }
}
