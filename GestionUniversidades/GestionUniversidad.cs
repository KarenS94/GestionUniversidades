using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUniversidades
{
    public class GestionUniversidad
    {
        //declara la lista
        public List<Universidad> universidades;
        public List<Estudiante> estudiantes;

        // constructor

        public GestionUniversidad()
        {
            universidades = new List<Universidad>();
            estudiantes = new List<Estudiante>();

            //Agregar Universidades
            universidades.Add(new Universidad { Id = 1, Nombre = "UCA" });
            universidades.Add(new Universidad { Id = 2, Nombre = "UPOLI" });

            // Agregamos estudiantes

            estudiantes.Add(new Estudiante { Id = 1, Nombre = "Karen", Genero = "Femenino", Edad = 30, UniversidadId = 1 });
            estudiantes.Add(new Estudiante { Id = 2, Nombre = "Santos", Genero = "Masculino", Edad = 37, UniversidadId = 1 });
            estudiantes.Add(new Estudiante { Id = 3, Nombre = "Allan de Jesus", Genero = "Masculino", Edad = 27, UniversidadId = 2 });
            estudiantes.Add(new Estudiante { Id = 4, Nombre = "Sofia", Genero = "Femenino", Edad = 33, UniversidadId = 2 });
            estudiantes.Add(new Estudiante { Id = 5, Nombre = "Valeska", Genero = "Femenino", Edad = 31, UniversidadId = 1 });
            estudiantes.Add(new Estudiante { Id = 6, Nombre = "Rey", Genero = "Masculino", Edad = 34, UniversidadId = 1 });
            estudiantes.Add(new Estudiante { Id = 7, Nombre = "Aura", Genero = "Femenino", Edad = 28, UniversidadId = 1 });
            estudiantes.Add(new Estudiante { Id = 8, Nombre = "Valeria", Genero = "Femenino", Edad = 18, UniversidadId = 1 });
            estudiantes.Add(new Estudiante { Id = 9, Nombre = "Marling", Genero = "Femenino", Edad = 22, UniversidadId = 2 });
            estudiantes.Add(new Estudiante { Id = 10, Nombre = "Guillermo", Genero = "Masculino", Edad = 32, UniversidadId = 2 });

        }

        public void CrearColeccionEstudianteUniversidades()
        {
            var coleccionNueva = from estudiante in estudiantes
                                 join universidad in universidades on estudiante.UniversidadId equals universidad.Id
                                 orderby estudiante.Nombre
                                 select new { NombreEstudiante = estudiante.Nombre, NombreUniversidad = universidad.Nombre };

            Console.WriteLine(" Nueva coleccion: ");
            foreach (var col in coleccionNueva)
            {
                Console.WriteLine("Estudiante {0} de la Universidad {1} ", col.NombreEstudiante, col.NombreUniversidad);
            }

        }
        public void MostrarEstudiantesMasculinos()
        {
            IEnumerable<Estudiante> estudiantesMasculinos = from estudiante in estudiantes where estudiante.Genero == "Masculino" select estudiante;

            Console.WriteLine(" Estudiantes Masculinos:   ");
            foreach (Estudiante estudiante in estudiantesMasculinos)
            {
                estudiante.MuestraEstudiante();
            }
        }
        public void MostarEstudiantesFemeninas()
        {
            IEnumerable<Estudiante> estudiantesFemenino = from estudiante in estudiantes where estudiante.Genero == "Femenino" select estudiante;

            Console.WriteLine("Estudiantes Femeninos:  ");
            foreach (Estudiante estudiante in estudiantesFemenino)
            {
                estudiante.MuestraEstudiante();
            }


        }
        public void OrdenarPorEdad()
        {
            var estudiantePorEdad = from estudiante in estudiantes orderby estudiante.Edad select estudiante;

            Console.WriteLine("Estudiantes ordenados por edad");
            foreach (Estudiante e in estudiantePorEdad)
            {
                e.MuestraEstudiante();
            }
        }

        public void MostrarEstudiantesUca()
        {
            IEnumerable<Estudiante> estudiantesUca = from estudiante in estudiantes join universidad in universidades on estudiante.UniversidadId equals universidad.Id where universidad.Nombre == "UCA" select estudiante;

            Console.WriteLine("Estudiantes de UCA");
            foreach (Estudiante e in estudiantesUca)
            {
                e.MuestraEstudiante();
            }
        }
        public void MostrarEstudiantesdeUniv(int Id)
        {
            IEnumerable<Estudiante> estudiantesUniv = from estudiante in estudiantes join universidad in universidades on estudiante.UniversidadId equals universidad.Id where universidad.Id == Id select estudiante;

            Console.WriteLine("Estudiantes estan en: ");
            foreach (Estudiante e in estudiantesUniv)
            {
                e.MuestraEstudiante();
            }
        }

    }
}


