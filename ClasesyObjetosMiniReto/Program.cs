using Biblioteca;
using System;

Console.WriteLine("Proyecto Biblioteca");

Console.WriteLine();

Console.Write("Título del libro: ");
string titulo = Console.ReadLine();

Console.Write("Autor: ");
string autor = Console.ReadLine();

Libro libro = new Libro(titulo, autor);

Console.WriteLine();

Console.Write("Nombre del lector: ");
string nombre = Console.ReadLine();

Console.Write("Correo: ");
string correo = Console.ReadLine();

Lector lector = new Lector(nombre, correo);

Console.WriteLine();

Console.Write("Fecha del préstamo: ");
string fecha = Console.ReadLine();

Prestamo prestamo = new Prestamo(titulo, nombre, fecha);

Console.WriteLine();
Console.WriteLine("===== INFORMACIÓN =====");
Console.WriteLine();

libro.MostrarInformacion();

Console.WriteLine();

lector.MostrarInformacion();

Console.WriteLine();

prestamo.MostrarInformacion();