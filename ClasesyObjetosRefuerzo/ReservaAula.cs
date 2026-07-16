using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio de refuerzo

namespace ClasesyObjetosRefuerzo
{
    class ReservaAula
    {
        public string NombreSolicitante { get; set; }
        public string Aula { get; set; }
        public string Fecha { get; set; }

        public ReservaAula(string nombreSolicitante, string aula, string fecha)
        {
            NombreSolicitante = nombreSolicitante;
            Aula = aula;
            Fecha = fecha;
        }

        public void MostrarReserva()
        {
            Console.WriteLine("Reserva de aula");
            Console.WriteLine($"Solicitante: {NombreSolicitante}");
            Console.WriteLine($"Aula: {Aula}");
            Console.WriteLine($"Fecha: {Fecha}");
        }
    }
}
