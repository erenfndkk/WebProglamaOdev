
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProgramlamaOdev.EntityLayer.Concreate;

namespace WebProgramlamaOdev.DataAccessLayer.Concreate
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ERMISH\\SQLEXPRESS01;initial catalog=OdevDb3;integrated security=true");
        }

  
        public DbSet<AnaBilimDali> AnaBilimDali { get; set; }
        public DbSet<Doktor> Doktor { get; set; }
        public DbSet<Poliklinik> Poliklinik { get; set; }
        public DbSet<Randevu> Randevu { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Home> Homes { get; set; }


    }
}
