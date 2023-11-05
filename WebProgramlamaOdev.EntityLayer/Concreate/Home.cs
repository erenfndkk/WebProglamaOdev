using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProgramlamaOdev.EntityLayer.Concreate
{
    public class Home
    {
        [Key]
        public int HomeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
