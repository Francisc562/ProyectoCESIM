using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Registro_CESIM.Models
{
    public enum sex
    {
        Masculino, Femenino,
    }
    public class Estudiante
    {
        public int estudianteID { get; set; }
        public int tutorID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public sex? Sexo { get; set; }
       
        public DateTime Nacimiento { get; set; }
        public string Codigo { get; set; }

        public Tutor Tutor { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }

    }
}
