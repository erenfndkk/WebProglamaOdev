using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.EntityLayer.Concreate
{
    public class CalismaSaati
    {
        public int RandevuId { get; set; }
        public DayOfWeek Gun { get; set; }
        public TimeSpan BaslangicSaati { get; set; }
        public TimeSpan BitisSaati { get; set; }
        public int DoktorId { get; set; }
        [ForeignKey("DoktorId")]
        public Doktor Doktor { get; set; }
    }
}
