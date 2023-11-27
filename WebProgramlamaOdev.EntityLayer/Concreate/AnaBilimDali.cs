using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.EntityLayer.Concreate
{
    public class AnaBilimDali
    {
        public int AnaBilimDaliId { get; set; }
        public string AnaBilimDaliAd { get; set; }
        public ICollection<Doktor> Doktorlar { get; set; }
    }
}
