using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.EntityLayer.Concreate
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminKullaniciAdi { get; set; }
        public string AdminAd { get; set; }
        public string AdminSoyad { get; set; }
        public string AdminSifre { get; set; }
    }
}
