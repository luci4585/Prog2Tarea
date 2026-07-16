using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio 3

namespace ClasesyObjetos3
{
    class Turno
    {
        public string NombreSolicitante { get; set; }
        public string Fecha { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }

        public Turno(string nombreSolicitante, string fecha, string motivo, string estado)
        {
            NombreSolicitante = nombreSolicitante;
            Fecha = fecha;
            Motivo = motivo;
            Estado = estado;
        }

        public void MostrarTurno()
        {
            Console.WriteLine("Datos del turno");
            Console.WriteLine($"Solicitante: {NombreSolicitante}");
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Motivo: {Motivo}");
            Console.WriteLine($"Estado: {Estado}");
        }
    }
}
