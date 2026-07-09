//Ejercicio 1

Console.WriteLine("Ficha de libro");

Console.Write("Título: ");
string titulo = Console.ReadLine();

Console.Write("Autor: ");
string autor = Console.ReadLine();

Console.Write("Editorial: ");
string editorial = Console.ReadLine();

Console.Write("Año de publicación: ");
int anioPublic = int.Parse(Console.ReadLine());

Console.Write("Cantidad de ejemplares: ");
int cantidadEjemplares = int.Parse(Console.ReadLine());

Console.Write("¿Está disponible? (true/false): ");
bool estaDisponible = bool.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("         FICHA DE LIBRO");
Console.WriteLine("==================================");
Console.WriteLine("Título: " + titulo);
Console.WriteLine("Autor: " + autor);
Console.WriteLine("Editorial: " + editorial);
Console.WriteLine("Año de publicación: " + anioPublic);
Console.WriteLine("Cantidad de ejemplares: " + cantidadEjemplares);
Console.WriteLine("Disponible: " + estaDisponible);
Console.WriteLine("==================================");

//Ejercicio 2

Console.WriteLine("Registro de producto");

Console.Write("Nombre del producto: ");
string nombreProducto = Console.ReadLine();

Console.Write("Categoría: ");
string categoria = Console.ReadLine();

Console.Write("Precio: ");
double precio = double.Parse(Console.ReadLine());

Console.Write("Stock: ");
int stock = int.Parse(Console.ReadLine());

Console.Write("Proveedor: ");
string proveedor = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("      REGISTRO DE PRODUCTO");
Console.WriteLine("==================================");
Console.WriteLine("Producto: " + nombreProducto);
Console.WriteLine("Categoría: " + categoria);
Console.WriteLine("Precio: " + precio);
Console.WriteLine("Stock: " + stock);
Console.WriteLine("Proveedor: " + proveedor);
Console.WriteLine("==================================");

//Ejercicio 3

Console.WriteLine("Inscripción a jornada");

Console.Write("Nombre del asistente: ");
string nombre1 = Console.ReadLine();

Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine());

Console.Write("¿Participará de todas las actividades? (true/false): ");
bool participaCompleta = bool.Parse(Console.ReadLine());

Console.Write("Fecha de inscripción (dd/mm/aaaa): ");
DateTime fechaInscripcion = DateTime.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("   INSCRIPCIÓN A JORNADA");
Console.WriteLine("==================================");
Console.WriteLine("Nombre: " + nombre1);
Console.WriteLine("Edad: " + edad);
Console.WriteLine("Participación completa: " + participaCompleta);
Console.WriteLine("Fecha de inscripción: " + fechaInscripcion);
Console.WriteLine("==================================");

//Ejercicio de refuerzo

Console.WriteLine("Presentación personal");

Console.Write("Nombre: ");
string nombre = Console.ReadLine();

Console.Write("Apellido: ");
string apellido = Console.ReadLine();

Console.Write("Ciudad: ");
string ciudad = Console.ReadLine();

Console.Write("Materia favorita: ");
string materiaFavorita = Console.ReadLine();

Console.Write("Una frase que lo represente: ");
string frase = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("    PRESENTACIÓN PERSONAL");
Console.WriteLine("==================================");
Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Apellido: {apellido}");
Console.WriteLine($"Ciudad: {ciudad}");
Console.WriteLine($"Materia favorita: {materiaFavorita}");
Console.WriteLine($"Frase: {frase}");
Console.WriteLine("==================================");

//Mini reto

Console.WriteLine("Reserva de aula");

Console.Write("Nombre del docente: ");
string nombreDocente = Console.ReadLine();

Console.Write("Materia: ");
string materia = Console.ReadLine();

Console.Write("Aula: ");
string aula = Console.ReadLine();

Console.Write("Cantidad de estudiantes: ");
int cantidadEstudiantes = int.Parse(Console.ReadLine());

Console.Write("Fecha de reserva (dd/mm/aaaa): ");
DateTime fechaReserva = DateTime.Parse(Console.ReadLine());

Console.Write("¿Necesita proyector? (true/false): ");
bool necesitaProyector = bool.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("==================================");
Console.WriteLine("        RESERVA DE AULA");
Console.WriteLine("==================================");
Console.WriteLine($"Docente: {nombreDocente}");
Console.WriteLine($"Materia: {materia}");
Console.WriteLine($"Aula: {aula}");
Console.WriteLine($"Cantidad de estudiantes: {cantidadEstudiantes}");
Console.WriteLine($"Fecha de reserva: {fechaReserva}");
Console.WriteLine($"Necesita proyector: {necesitaProyector}");
Console.WriteLine("==================================");