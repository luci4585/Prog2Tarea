using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejercicio 1

namespace ClasesObjetos1
{
    class Producto
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public Producto(string nombre, string categoria, double precio, int stock)
        {
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            Stock = stock;
        }

        public void MostrarFicha()
        {
            Console.WriteLine("Ficha del producto");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Categoría: {Categoria}");
            Console.WriteLine($"Precio: {Precio}");
            Console.WriteLine($"Stock: {Stock}");
        }
    }
}
