using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Registro_CESIM.Models
{

  
    public class Grado
    {
        public int gradoID { get; set; }
        public int docenteID { get; set; }
        
       
       

        public Docente docente { get; set; }
        public ICollection<Matricula> matriculas { get; set; }

    }
}
