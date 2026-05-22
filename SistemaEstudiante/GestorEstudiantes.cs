
public class GestorEstudiantes
{
    private readonly List<Estudiante> _estudiantes
        = new();

    public void Agregar(string nombre)
    {
        if (Existe(nombre))
        {
            Console.WriteLine("El estudiante ya existe.");
            return;
        }
        _estudiantes.Add(new Estudiante(nombre));
        Console.WriteLine("Estudiante agregado");
    }

    private bool Existe(string nombre)
    {
        return _estudiantes.Any(e => !string.IsNullOrEmpty(e.Nombre) &&
        e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
    }

    public void Eliminar(string nombre)
    {
        var estudiante = _estudiantes.Find(e => !string.IsNullOrEmpty(e.Nombre) &&
        e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

        if (estudiante == null)
        {
            Console.WriteLine("Estudiante no encontrado.");
            return;
        }
        _estudiantes.Remove(estudiante);
        Console.WriteLine("Estudiante eliminado.");
    }

    public void MostrarTotal()
    {
        Console.WriteLine($"Total: {_estudiantes.Count}");
    }

    public void OrdenarPorNombre()
    {
        _estudiantes.Sort((a, b) => string.Compare(a.Nombre, b.Nombre,
            StringComparison.Ordinal));
        Console.WriteLine("Lista ordenada.");
    }

    public void Filtrar(string texto)
    {
        var filtrados = _estudiantes.Where(e =>
        !string.IsNullOrEmpty(e.Nombre) &&
        e.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase)).ToList();

        Console.WriteLine();
        foreach (var e in filtrados)
        {
            Console.WriteLine(e);
        }
    }

    public void Listar()
    {
        if (_estudiantes.Count == 0)
        {
            Console.WriteLine("No hay estudiantes.");
            return;
        }
        Console.WriteLine();
        foreach (var e in _estudiantes) { Console.WriteLine(e); }
    }
}
