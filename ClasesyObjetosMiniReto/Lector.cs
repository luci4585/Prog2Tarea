using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mini reto

namespace Biblioteca
{
    class Lector
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public Lector(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Correo: {Correo}");
        }
    }
}
