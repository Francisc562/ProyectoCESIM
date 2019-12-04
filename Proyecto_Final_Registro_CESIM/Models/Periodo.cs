using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Registro_CESIM.Models
{
    public enum par {
        Primero, Segundo, Tercero, Cuarto
    }
    public class Periodo
    {
        public int periodoID { get; set; }
        public par? Parcial { get; set; }
        

       

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
