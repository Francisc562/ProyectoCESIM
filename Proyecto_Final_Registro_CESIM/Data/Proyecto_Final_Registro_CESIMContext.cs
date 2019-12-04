using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyecto_Final_Registro_CESIM.Models;

namespace Proyecto_Final_Registro_CESIM.Data
{
    public class Proyecto_Final_Registro_CESIMContext : DbContext
    {
        public Proyecto_Final_Registro_CESIMContext (DbContextOptions<Proyecto_Final_Registro_CESIMContext> options)
            : base(options)
        {
        }

        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Grado> Grados { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docente>().ToTable("Docente");
            modelBuilder.Entity<Grado>().ToTable("Grado");
            modelBuilder.Entity<Tutor>().ToTable("Tutor");
            modelBuilder.Entity<Estudiante>().ToTable("Estudiante");
            modelBuilder.Entity<Periodo>().ToTable("Periodo");
            modelBuilder.Entity<Matricula>().ToTable("Matricula");
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
        }


        public DbSet<Proyecto_Final_Registro_CESIM.Models.Docente> Docente { get; set; }
    }
}
