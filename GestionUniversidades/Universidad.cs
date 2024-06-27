using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUniversidades
{
    public class Universidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void MostrarUniversidad()
        {
            Console.WriteLine("Universidad {0} tiene el Id {1}", Nombre, Id);
        }

    }
}
