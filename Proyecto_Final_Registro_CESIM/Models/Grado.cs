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
    public class Grado
    {
        public int IDGRADO { get; set; }
        public int IDDOCENTE { get; set; }
       
        public Grad? Grad { get; set; }

        public Docente docente { get; set; }
        public ICollection<Matricula> matriculas { get; set; }

    }
}
