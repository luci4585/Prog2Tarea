using ClasesObjetos2;

//Ejercicio 2

Console.Write("Nombre del aula: ");
string nombre = Console.ReadLine();

Console.Write("Capacidad: ");
int capacidad = int.Parse(Console.ReadLine());

Console.Write("¿Tiene proyector? (true/false): ");
bool tieneProyector = bool.Parse(Console.ReadLine());

Console.Write("¿Está disponible? (true/false): ");
bool estaDisponible = bool.Parse(Console.ReadLine());

Aula aula = new Aula(nombre, capacidad, tieneProyector, estaDisponible);

aula.MostrarDatos();