// Ejercicio 1

Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("¿Está inscripto? (true/false): ");
bool inscripto = bool.Parse(Console.ReadLine());

Console.Write("¿Tiene autorización? (true/false): ");
bool autorizacion = bool.Parse(Console.ReadLine());

if (edad >= 18 && inscripto)
{
    Console.WriteLine("Puede participar en la actividad.");
}
else if (edad < 18 && inscripto && autorizacion)
{
    Console.WriteLine("Puede participar en la actividad.");
}
else
{
    Console.WriteLine("No puede participar en la actividad.");
}

//Ejercicio 2

Console.Write("¿El aula está disponible? (true/false): ");
bool aulaDisponible = bool.Parse(Console.ReadLine());

Console.Write("¿El docente confirmó? (true/false): ");
bool docenteConfirmo = bool.Parse(Console.ReadLine());

Console.Write("¿Hay equipamiento suficiente? (true/false): ");
bool equipamiento = bool.Parse(Console.ReadLine());

if (aulaDisponible && docenteConfirmo && equipamiento)
{
    Console.WriteLine("Reserva aprobada.");
}
else if (aulaDisponible && docenteConfirmo)
{
    Console.WriteLine("Reserva pendiente.");
}
else
{
    Console.WriteLine("Reserva rechazada.");
}

//Elercicio 3

Console.WriteLine("Menú de Biblioteca");
Console.WriteLine("1. Registrar libro");
Console.WriteLine("2. Registrar lector");
Console.WriteLine("3. Prestar libro");
Console.WriteLine("4. Devolver libro");
Console.WriteLine("5. Salir");

Console.Write("Seleccione una opción: ");
string opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        Console.WriteLine("Registrar libro");
        break;

    case "2":
        Console.WriteLine("Registrar lector");
        break;

    case "3":
        Console.WriteLine("Prestar libro");
        break;

    case "4":
        Console.WriteLine("Devolver libro");
        break;

    case "5":
        Console.WriteLine("Salir");
        break;

    default:
        Console.WriteLine("Opción inválida.");
        break;
}

//Ejercicio de refuerzo

Console.WriteLine("Ficha del Libro");

Console.Write("Título: ");
string titulo = Console.ReadLine();

Console.Write("Autor: ");
string autor = Console.ReadLine();

Console.Write("Cantidad de ejemplares: ");
int ejemplares = int.Parse(Console.ReadLine());

Console.WriteLine("Ficha");
Console.WriteLine("Título: " + titulo);
Console.WriteLine("Autor: " + autor);
Console.WriteLine("Ejemplares: " + ejemplares);

if (ejemplares > 0)
{
    Console.WriteLine("Disponible");
}
else
{
    Console.WriteLine("No disponible");
}

//Mini reto

Console.Write("¿El solicitante está registrado? (true/false): ");
bool registrado = bool.Parse(Console.ReadLine());

Console.Write("¿El material está disponible? (true/false): ");
bool disponible = bool.Parse(Console.ReadLine());

Console.Write("¿Tiene devoluciones pendientes? (true/false): ");
bool devolucionesPendientes = bool.Parse(Console.ReadLine());

Console.Write("¿La solicitud fue realizada dentro del horario permitido? (true/false): ");
bool horarioPermitido = bool.Parse(Console.ReadLine());

if (registrado && disponible && !devolucionesPendientes && horarioPermitido)
{
    Console.WriteLine("La solicitud fue aprobada.");
}
else
{
    Console.WriteLine("La solicitud fue rechazada.");
}
