using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_Monografico_Walder_Reyes.Models
{
    public class AppDbContext : IdentityDbContext
    {
        public DbSet<Empleado> Empeados { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

        public AppDbContext()
        {
                
        }
      
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base (options)
        {
        }

    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
