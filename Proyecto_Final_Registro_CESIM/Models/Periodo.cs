using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Registro_CESIM.Models
{
    public class Periodo
    {
        public int IDPERIODO { get; set; }
        public string Nombre { get; set; }

        public DateTime MatriculaDate { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
