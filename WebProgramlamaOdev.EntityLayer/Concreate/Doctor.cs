using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.EntityLayer.Concreate
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telefon { get; set; }
        
    }
}
