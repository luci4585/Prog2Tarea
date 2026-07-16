using ClasesyObjetos3;

//Ejercicio 3

Console.Write("Nombre del solicitante: ");
string nombre = Console.ReadLine();

Console.Write("Fecha: ");
string fecha = Console.ReadLine();

Console.Write("Motivo: ");
string motivo = Console.ReadLine();

Console.Write("Estado: ");
string estado = Console.ReadLine();

Turno turno = new Turno(nombre, fecha, motivo, estado);

turno.MostrarTurno();