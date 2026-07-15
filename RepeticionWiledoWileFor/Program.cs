//Ejercicio 1

Console.Write("¿Cuántos asistentes desea cargar?: ");
int cantidad = int.Parse(Console.ReadLine());

for (int i = 1; i <= cantidad; i++)
{
    Console.WriteLine("Asistente número " + i);

    Console.Write("Nombre: ");
    string nombre = Console.ReadLine();

    Console.Write("Institución: ");
    string institucion = Console.ReadLine();

    Console.Write("Correo electrónico: ");
    string correo1 = Console.ReadLine();

    Console.WriteLine("Asistente registrado.");
    Console.WriteLine("Nombre: " + nombre);
    Console.WriteLine("Institución: " + institucion);
    Console.WriteLine("Correo: " + correo1);

    Console.WriteLine();
}

//Ejercicio 2

string opcion1;

do
{
    Console.WriteLine("Menú de Turnos");
    Console.WriteLine("1. Solicitar turno");
    Console.WriteLine("2. Consultar estado");
    Console.WriteLine("3. Cancelar turno");
    Console.WriteLine("4. Salir");

    Console.Write("Seleccione una opción: ");
    opcion1 = Console.ReadLine();

    switch (opcion1)
    {
        case "1":
            Console.WriteLine("Solicitar turno.");
            break;

        case "2":
            Console.WriteLine("Consultar estado.");
            break;

        case "3":
            Console.WriteLine("Cancelar turno.");
            break;

        case "4":
            Console.WriteLine("Saliendo del sistema.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

    Console.WriteLine();

} while (opcion1 != "4");

//Ejercicio 3

string correo2 = "";

while (correo2 == "")
{
    Console.Write("Ingrese un correo electrónico: ");
    correo2 = Console.ReadLine();

    if (correo2 == "")
    {
        Console.WriteLine("Debe ingresar un correo.");
    }
}

Console.WriteLine("Correo aceptado: " + correo2);

//Ejercicio de refuerzo

string opcion2;

do
{
    Console.WriteLine("Sistema de Biblioteca");
    Console.WriteLine("1. Registrar libro");
    Console.WriteLine("2. Registrar lector");
    Console.WriteLine("3. Prestar libro");
    Console.WriteLine("4. Devolver libro");
    Console.WriteLine("5. Salir");

    Console.Write("Seleccione una opción: ");
    opcion2 = Console.ReadLine();

    switch (opcion2)
    {
        case "1":
            Console.WriteLine("Registrar libro.");
            break;

        case "2":
            Console.WriteLine("Registrar lector.");
            break;

        case "3":
            Console.WriteLine("Prestar libro.");
            break;

        case "4":
            Console.WriteLine("Devolver libro.");
            break;

        case "5":
            Console.WriteLine("Cerrando sistema.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

    Console.WriteLine();

} while (opcion2 != "5");

//Mini reto

int cantidadReservas = 0;
string respuesta;

do
{
    Console.WriteLine("Nueva reserva de aula");

    Console.Write("Nombre del solicitante: ");
    string nombre = Console.ReadLine();

    Console.Write("Aula: ");
    string aula = Console.ReadLine();

    Console.Write("Fecha: ");
    string fecha = Console.ReadLine();

    cantidadReservas++;

    Console.Write("¿Desea cargar otra reserva? (si/no): ");
    respuesta = Console.ReadLine();

    Console.WriteLine();

} while (respuesta == "si");

Console.WriteLine("Cantidad de reservas cargadas: " + cantidadReservas);
