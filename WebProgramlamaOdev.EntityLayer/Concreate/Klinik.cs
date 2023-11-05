using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.EntityLayer.Concreate
{
    public class Klinik
    {
        [Key]
        public int KlinikID { get; set; }
        public string KlinikAd { get; set; }
    }
}
