using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.EntityLayer.Concreate
{
    public class Doktor
    {
        public int DoktorId { get; set; }
        public string DoktorAd { get; set; }
        public string DoktorSoyad { get; set; }
        public string ImageUrl { get; set; }
        public int AnaBilimDaliId { get; set; }
       // public AnaBilimDali AnaBilimDali { get; set; }
        
       public ICollection<Randevu> Randevular { get; set; }

    }
}
