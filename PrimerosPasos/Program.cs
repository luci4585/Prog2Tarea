//Ejercicio 1

Console.WriteLine("Presentación Personal");

Console.Write("Nombre: ");
string nombre = Console.ReadLine();

Console.Write("Apellido: ");
string apellido = Console.ReadLine();

Console.Write("Ciudad: ");
string ciudad = Console.ReadLine();

Console.Write("Materia favorita: ");
string materia = Console.ReadLine();

Console.Write("Frase que te representa: ");
string frase = Console.ReadLine();

Console.WriteLine("Presentación");
Console.WriteLine("Nombre: " + nombre);
Console.WriteLine("Apellido: " + apellido);
Console.WriteLine("Ciudad: " + ciudad);
Console.WriteLine("Materia favorita: " + materia);
Console.WriteLine("Frase: " + frase);

//Ejercicio 2

Console.WriteLine("Credencial de Biblioteca");

Console.Write("Nombre del lector: ");
string nombreLector = Console.ReadLine();

Console.Write("Curso: ");
string curso = Console.ReadLine();

Console.Write("Turno: ");
string turno = Console.ReadLine();

Console.Write("Correo electrónico: ");
string correo = Console.ReadLine();

Console.WriteLine("Credencial");
Console.WriteLine("Nombre: " + nombreLector);
Console.WriteLine("Curso: " + curso);
Console.WriteLine("Turno: " + turno);
Console.WriteLine("Correo electrónico: " + correo);

//Ejercicio 3

Console.WriteLine("Cartel para evento escolar");

Console.Write("Nombre del evento: ");
string evento = Console.ReadLine();

Console.Write("Lugar: ");
string lugar = Console.ReadLine();

Console.Write("Fecha: ");
string fecha = Console.ReadLine();

Console.Write("Responsable: ");
string responsable = Console.ReadLine();

Console.WriteLine("Cartel");
Console.WriteLine("Evento: " + evento);
Console.WriteLine("Lugar: " + lugar);
Console.WriteLine("Fecha: " + fecha);
Console.WriteLine("Responsable: " + responsable);

//Preguntas de comprensión
//
//1. ¿Qué diferencia hay entre `Console.Write` y `Console.WriteLine`?
//2. ¿Qué tipo de dato devuelve `Console.ReadLine()`?
//3. ¿Qué ocurre si el usuario no escribe nada y presiona Enter?
//4. ¿Por qué conviene elegir nombres claros para las variables?
//
//1. Console.Write escribe en la misma línea, Console.WriteLine escribe y pasa a la siguiente línea
//
//2. Devuelve un string
//
//3. La variable guarda una cadena vacía ("")
//
//4. Porque hacen que el programa sea más fácil de leer y entender, tanto para uno mismo
//como para otros programadores que puedan trabajar en el código