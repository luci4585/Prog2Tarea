using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Prestamo
    {
        public string Libro { get; set; }
        public string Lector { get; set; }
        public string Fecha { get; set; }

        public Prestamo(string libro, string lector, string fecha)
        {
            Libro = libro;
            Lector = lector;
            Fecha = fecha;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Libro: {Libro}");
            Console.WriteLine($"Lector: {Lector}");
            Console.WriteLine($"Fecha: {Fecha}");
        }
    }
}
