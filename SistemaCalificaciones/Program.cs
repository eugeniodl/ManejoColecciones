var registro = new RegistroEstudiantes();

// Lista completa
UIEstudiante.MostrarLista("Todos los estudiantes", registro.ObtenerTodos());

// Filtrar
var aprobados = registro.Filtrar(e => e.EstaAprobado);
UIEstudiante.MostrarLista("Estudiantes aprobados", aprobados);

// Ordenar
var ordenados = registro.Ordenar(e => e.Nombre ?? string.Empty);
UIEstudiante.MostrarLista("Ordenar por nombre", ordenados);

// Buscar
var encontrado = registro.Buscar(e => e.NombreCompleto == "Ana García");
Console.WriteLine("\n===== BÚSQUEDA =====");
if (encontrado != null)
    Console.WriteLine($"Encontrado: {encontrado}");
else
    Console.WriteLine("No encontrado");

// Estadísticas
UIEstudiante.MostrarEstadisticas(registro);