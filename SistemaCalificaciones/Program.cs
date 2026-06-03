var registro = new RegistroEstudiantes();

UIEstudiantes.MostrarLista("TODOS LOS ESTUDIANTES", registro.ObtenerTodos());

// Filtrar
var aprobados = registro.Filtrar(e => e.EstaAprobado);
UIEstudiantes.MostrarLista("ESTUDIANTES APROBADOS", aprobados);

// Ordenar
var ordenados = registro.Ordenar(e => e.Nombre);
UIEstudiantes.MostrarLista("ORDENADOS POR NOMBRE", ordenados);

// Buscar
var encontrado = registro.Buscar(e => e.NombreCompleto == "Ana García");

Console.WriteLine("\n===== BÚSQUEDA =====");

if(encontrado != null)
    Console.WriteLine($"Encontrado: {encontrado}");
else
    Console.WriteLine("No encontrado");

// Estadísticas
UIEstudiantes.MostrarEstadisticas(registro);
