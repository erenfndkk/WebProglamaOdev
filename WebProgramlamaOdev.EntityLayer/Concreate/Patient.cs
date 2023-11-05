using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.EntityLayer.Concreate
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string PatientTC { get; set; }
        public string PatientMail { get; set; }
        public string Sifre { get; set; }
        public string Telefon { get; set; }
    }
}
