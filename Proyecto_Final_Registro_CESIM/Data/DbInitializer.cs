using Proyecto_Final_Registro_CESIM.Data;
using Proyecto_Final_Registro_CESIM.Models;
using System;
using System.Linq;

namespace Proyecto_Final_Registro_CESIM.Data
{
    public class DbInitializer 
    {

        public static void Initialize(Proyecto_Final_Registro_CESIMContext context)
        {
            context.Database.EnsureCreated();

            
            if (context.Docentes.Any())
            {
                return;   
            }

            var docentes = new Docente[]
            {
                new Docente{Nombres="Martha Maria", Apellidos="Rocha Rodriguez", Sexo=se.Femenino, Especialidad="Matematica",
                Correo="Marm@yahoo.es", Telefono="54858695", Direccion="CALLE AGUSTIN LARA NO. 69-B",},
                new Docente{Nombres="Jose Bryan", Apellidos="Rodrigez Mercado", Sexo=se.Masculino, Especialidad="Educacion Fisica",
                Correo="JoseBry85@gmail.com", Telefono="85417563", Direccion="AV. INDEPENDENCIA NO. 241",},
                new Docente{Nombres="Victoria Eugenia", Apellidos="Cuevas Jimenez", Sexo=se.Femenino, Especialidad="Ciencias Naturales",
                Correo="victoeu@gmail.com", Telefono="55883221", Direccion="AV. 20 DE NOVIEMBRE NO.1024",},
                new Docente{Nombres="Lidia Tereza", Apellidos="Aldana Aguirre", Sexo=se.Femenino, Especialidad="Lengua y Literatura",
                Correo="litere@yahoo.com", Telefono="85472215", Direccion="Frente a Enacal",},

            };
            foreach (Docente d in docentes)
            {
                context.Docentes.Add(d);
            }
            context.SaveChanges();

            var grados = new Grado[]
           {
                new Grado{docenteID=1, Nivel=lev.Prescolar},
                new Grado{docenteID=2, Nivel=lev.Primero},
                new Grado{docenteID=3, Nivel=lev.Segundo},
                new Grado{docenteID=4, Nivel=lev.Tercero},

           };
            foreach (Grado g in grados)
            {
                context.Grados.Add(g);
            }
            context.SaveChanges();

            var tutores = new Tutor[]
           {
                new Tutor {Nombres="Mario Manuel", Apellidos="Gutierrez Garcia", Identificacion="324-250490-1000D",
                    Telefono="85474123", Direccion="de la policia 2 cuadras al sur y una al este"},
                new Tutor {Nombres="Ana Brenda", Apellidos="Hernandez Rivas", Identificacion="324-051286-1210A",
                    Telefono="88541256", Direccion="esquina opuesta al gallo mas gallo"},
                new Tutor {Nombres="Eliuth Azusena", Apellidos="Lanuza Palma", Identificacion="327-040790-8000E",
                    Telefono="52565441", Direccion="de la contran sur cuatro varas al este"},
           };
            foreach (Tutor t in tutores)
            {
                context.Tutors.Add(t);
            }
            context.SaveChanges();

            var estudiantes = new Estudiante[]
            {
                new Estudiante{tutorID=1, Nombres="Ana Maria", Apellidos="Gutierrez Martinez", Sexo=sex.Femenino,
                    Nacimiento=DateTime.Parse("2000-09-01"), Codigo="DSR1-DD96-DCVB"},
                new Estudiante{tutorID=1, Nombres="Mario Juaquin", Apellidos="Gutierrez Martinez", Sexo=sex.Masculino,
                    Nacimiento=DateTime.Parse("2001-02-24"), Codigo="DMRF-OJM6-HHRL"},
                new Estudiante{tutorID=2, Nombres="Luis Miguel", Apellidos="Sanchez Hernandez", Sexo=sex.Masculino,
                    Nacimiento=DateTime.Parse("2004-05-15"), Codigo="MNB8-ZXC2-OPLM"},
                new Estudiante{tutorID=3, Nombres="Andrea Maria", Apellidos="Lagos Lanuza", Sexo=sex.Femenino,
                    Nacimiento=DateTime.Parse("2001-08-10"), Codigo="OOMN-UYG8-YHB5"},

            };
            foreach (Estudiante s in estudiantes)
            {
                context.Estudiantes.Add(s);
            }
            context.SaveChanges();

            var peridos = new Periodo[]
        {
                new Periodo{Parcial=par.Primero},
                new Periodo{Parcial=par.Segundo},
                new Periodo{Parcial=par.Tercero},
                new Periodo{Parcial=par.Cuarto},

        };
            foreach (Periodo p in peridos)
            {
                context.Periodos.Add(p);
            }
            context.SaveChanges();

            var matriculas = new Matricula[]
            {
                new Matricula{gradoID=1,periodoID=1, estudianteID=1, Seccion=Seccion.A},
                new Matricula{gradoID=2,periodoID=2, estudianteID=2, Seccion=Seccion.B},
                new Matricula{gradoID=3,periodoID=1, estudianteID=3, Seccion=Seccion.B},
                new Matricula{gradoID=4,periodoID=2, estudianteID=4, Seccion=Seccion.A},


            };
            foreach (Matricula m in matriculas)
            {
                context.Matriculas.Add(m);
            }
            context.SaveChanges();

            var usuarios = new Usuario[]
           {
                new Usuario{Correo="Salomon@gmail.com", Clave="Admin"},
                    new Usuario{Correo="Salomoniba@gmail.com", Clave="AdminD"},


           };
            foreach (Usuario u in usuarios)
            {
                context.Usuarios.Add(u);
            }
            context.SaveChanges();
        }
    }
}
