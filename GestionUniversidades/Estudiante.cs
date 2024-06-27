using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUniversidades
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }
        public int UniversidadId { get; set; }

        public void MuestraEstudiante()
        {
            Console.WriteLine("Estudiante {0} tiene el Id {1} , edad {2}, de genero {3} y asiste a la Universidad {4}",
                Nombre, Id, Edad, Genero, UniversidadId);
        }

    }
}

