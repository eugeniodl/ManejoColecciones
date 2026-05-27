public class RegistroEstudiantes
{
    private List<Estudiante> _estudiantes;

    public RegistroEstudiantes()
    {
        _estudiantes = new List<Estudiante>()
        {
            new Estudiante("Ana", "García", 85.5),
            new Estudiante("Luis", "Pérez", 42),
            new Estudiante("Sofía", "Ramírez", 95),
            new Estudiante("Carlos", "López", 58),
            new Estudiante("María", "Fernández", 73),
            new Estudiante("Diego", "Herrera", 61),
        };
    }

    public List<Estudiante> Filtrar(Func<Estudiante, bool> criterio)
    {
        return _estudiantes.Where(criterio).ToList();
    }

    public List<Estudiante> Ordenar(Func<Estudiante, object> criterio)
    {
        return _estudiantes.OrderBy(criterio).ToList();
    }

    public Estudiante? Buscar(Func<Estudiante, bool> criterio)
    {
        return _estudiantes.FirstOrDefault(criterio);
    }

    public double CalcularPromedio()
    {
        return Math.Round(_estudiantes.Average(e => e.Calificacion), 1);
    }

    public double ObtenerMaximaCalificacion()
    {
        return _estudiantes.Max(e => e.Calificacion);
    }

    public double ObtenerMinimaCalificacion()
    {
        return _estudiantes.Min(e => e.Calificacion);
    }

    public List<Estudiante> ObtenerTodos()
    {
        return new List<Estudiante>(_estudiantes);
    }
}

