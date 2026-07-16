using ClasesObjetos1;
using System;

//Ejercicio 1

Console.Write("Nombre: ");
string nombre = Console.ReadLine();

Console.Write("Categoría: ");
string categoria = Console.ReadLine();

Console.Write("Precio: ");
double precio = double.Parse(Console.ReadLine());

Console.Write("Stock: ");
int stock = int.Parse(Console.ReadLine());

Producto producto = new Producto(nombre, categoria, precio, stock);

producto.MostrarFicha();

