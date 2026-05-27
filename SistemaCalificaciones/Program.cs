var registro = new RegistroEstudiantes();

// Lista completa
UIEstudiantes.MostrarLista("Todos los estudiantes", registro.ObtenerTodos());

// Filtrar
var aprobados = registro.Filtrar(e => e.EstaAprobado);
UIEstudiantes.MostrarLista("Estudiantes aprobados", aprobados);

// Ordenar
var ordenados = registro.Ordenar(e => e.Nombre);
UIEstudiantes.MostrarLista("Ordenados por nombre", ordenados);

// Buscar
var encontrado = registro.Buscar(e => e.NombreCompleto == "Ana García");
Console.WriteLine("\n===== BÚSQUEDA =====");
if(encontrado != null)
    Console.WriteLine($"Encontrado: {encontrado}");
else
    Console.WriteLine("No encontrado");

// Estadísticas
UIEstudiantes.MostrarEstadisticas(registro);
