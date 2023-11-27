﻿using System;
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
        //public DayOfWeek Gun { get; set; }
        public TimeSpan BaslangicSaati { get; set; }
        public TimeSpan BitisSaati { get; set; }
        public int HastaId { get; set; }
        public Hasta Hasta { get; set; }
        public int DoktorId { get; set; }
        public Doktor Doktor { get; set; }
        // buna devam edilecek 
    }
}
