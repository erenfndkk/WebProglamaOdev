
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
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ERMISH\\SQLEXPRESS01;initial catalog=OdevDb;integrated security=true");
        }

        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Home> Homes { get; set; }


    }
}
