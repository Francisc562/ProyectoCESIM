using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Registro_CESIM.Models
{

    public enum se
    {
        Masculino, Femenino,
    }
    public class Docente
    {
        public int docenteID { get; set; }
        public string Nombre { get; set; }
        public se? Sexo { get; set; }
        public string Especialidad { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public DateTime Grado { get; set; }

        public ICollection<Grado> Grados { get; set; }
    }
}
