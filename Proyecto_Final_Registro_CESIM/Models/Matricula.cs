using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Registro_CESIM.Models
{
    public enum Grad
    {
        Prescolar, A, B, C,
    }
    public class Matricula
    {
        public int matriculaID { get; set; }
        public int gradoID { get; set; }
        public int periodoID { get; set; }
        public Grad? Grad { get; set; }

        public Grado Grado { get; set; }
        public Periodo Periodo { get; set; }

    public ICollection<Usuario> Usuarios { get; set; }
    }
}
