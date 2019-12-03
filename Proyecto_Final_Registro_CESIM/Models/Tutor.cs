using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Registro_CESIM.Models
{
    public class Tutor
    {
        public int tutorID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime EstudianteDate { get; set; }

        public ICollection<Estudiante> Estudiantes { get; set; }
    }
}
