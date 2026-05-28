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
            new Estudiante("Darío", "Herrera", 61)
        };
    }

    public List<Estudiante> Filtrar
        (Func<Estudiante, bool> criterio)
    {
        return _estudiantes.Where(criterio).ToList();
    }
}

