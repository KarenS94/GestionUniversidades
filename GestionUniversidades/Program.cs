using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUniversidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestionUniversidad ge = new GestionUniversidad();

            ge.MostrarEstudiantesMasculinos();
            ge.MostarEstudiantesFemeninas();
            ge.OrdenarPorEdad();
            ge.MostrarEstudiantesUca();
            Console.Read();

        }
    }
}

