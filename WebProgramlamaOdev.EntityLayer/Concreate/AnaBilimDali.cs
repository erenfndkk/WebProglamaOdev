using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.EntityLayer.Concreate
{
    public class AnaBilimDali
    {
        [Key]
        public int AnaBilimDaliId { get; set; }
        public string AnaBilimDaliAd { get; set; }
    }
}   
