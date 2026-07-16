using ClasesyObjetosRefuerzo;

//Ejercicio de refuerzo

Console.Write("Nombre del solicitante: ");
string nombre = Console.ReadLine();

Console.Write("Aula: ");
string aula = Console.ReadLine();

Console.Write("Fecha: ");
string fecha = Console.ReadLine();

ReservaAula reserva = new ReservaAula(nombre, aula, fecha);

reserva.MostrarReserva();