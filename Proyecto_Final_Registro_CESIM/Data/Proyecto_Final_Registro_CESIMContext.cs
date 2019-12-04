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

        public DbSet<Proyecto_Final_Registro_CESIM.Models.Estudiante> Estudiante { get; set; }
    }
}
