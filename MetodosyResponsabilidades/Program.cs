//Ejercicio 1

static void MostrarMenu1()
{
    Console.WriteLine("1 - Registrar producto");
    Console.WriteLine("2 - Salir");
}

static string RegistrarDatos()
{
    Console.Write("Nombre del producto: ");
    string producto = Console.ReadLine();

    return producto;
}

static bool ValidarEntrada(string texto)
{
    return texto != "";
}

static void MostrarResultado(string producto)
{
    Console.WriteLine($"Producto registrado: {producto}");
}

string opcion1;

do
{
    MostrarMenu1();
    Console.Write("Opción: ");
    opcion1 = Console.ReadLine();

    switch (opcion1)
    {
        case "1":

            string producto1 = RegistrarDatos();

            if (ValidarEntrada(producto1))
            {
                MostrarResultado(producto1);
            }
            else
            {
                Console.WriteLine("Debe ingresar un nombre.");
            }

            break;

        case "2":
            Console.WriteLine("Fin del programa.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

    Console.WriteLine();

} while (opcion1 != "2");

//Ejercicio 2

static bool EsTextoObligatorio(string texto)
{
    return texto != "";
}

static bool EsCantidadValida(int cantidad)
{
    return cantidad > 0;
}

static void MostrarError(string mensaje)
{
    Console.WriteLine(mensaje);
}

Console.Write("Producto: ");
string producto2 = Console.ReadLine();

Console.Write("Cantidad: ");
int cantidad = int.Parse(Console.ReadLine());

if (!EsTextoObligatorio(producto2))
{
    MostrarError("El nombre del producto es obligatorio.");
}
else if (!EsCantidadValida(cantidad))
{
    MostrarError("La cantidad debe ser mayor que cero.");
}
else
{
    Console.WriteLine("Producto registrado correctamente.");
}

//Ejercicio 3

static void MostrarFicha(string titulo, string autor, bool disponible)
{
    Console.WriteLine("Ficha del libro");
    Console.WriteLine($"Título: {titulo}");
    Console.WriteLine($"Autor: {autor}");

    if (disponible)
    {
        Console.WriteLine("Disponible");
    }
    else
    {
        Console.WriteLine("No disponible");
    }
}

Console.Write("Título: ");
string titulo = Console.ReadLine();

Console.Write("Autor: ");
string autor = Console.ReadLine();

Console.Write("¿Está disponible? (true/false): ");
bool disponible = bool.Parse(Console.ReadLine());

MostrarFicha(titulo, autor, disponible);

//Mini reto

static void MostrarMenu2()
{
    Console.WriteLine("Sistema de Biblioteca");
    Console.WriteLine("1 - Registrar libro");
    Console.WriteLine("2 - Registrar lector");
    Console.WriteLine("3 - Prestar libro");
    Console.WriteLine("4 - Devolver libro");
    Console.WriteLine("0 - Salir");
}

static void RegistrarLibro()
{
    Console.WriteLine("Registrar libro");
}

static void RegistrarLector()
{
    Console.WriteLine("Registrar lector");
}

static void PrestarLibro()
{
    Console.WriteLine("Prestar libro");
}

static void DevolverLibro()
{
    Console.WriteLine("Devolver libro");
}

string opcion2;

do
{
    MostrarMenu2();

    Console.Write("Opción: ");
    opcion2 = Console.ReadLine();

    switch (opcion2)
    {
        case "1":
            RegistrarLibro();
            break;

        case "2":
            RegistrarLector();
            break;

        case "3":
            PrestarLibro();
            break;

        case "4":
            DevolverLibro();
            break;

        case "0":
            Console.WriteLine("Fin del programa.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

    Console.WriteLine();

} while (opcion2 != "0");
