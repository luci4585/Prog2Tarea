using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio 2

namespace ClasesObjetos2
{
    internal class Aula
    {
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool TieneProyector { get; set; }
        public bool EstaDisponible { get; set; }

        public Aula(string nombre, int capacidad, bool tieneProyector, bool estaDisponible)
        {
            Nombre = nombre;
            Capacidad = capacidad;
            TieneProyector = tieneProyector;
            EstaDisponible = estaDisponible;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Datos del aula");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Capacidad: {Capacidad}");
            Console.WriteLine($"Tiene proyector: {TieneProyector}");
            Console.WriteLine($"Está disponible: {EstaDisponible}");
        }
    }
}
