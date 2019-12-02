using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Registro_CESIM.Models
{
    public class Estudiante
    {
        public int IDESTUDIANTE { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public DateTime Nacimiento { get; set; }
        public DateTime MatriculaDate { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }

    }
}
