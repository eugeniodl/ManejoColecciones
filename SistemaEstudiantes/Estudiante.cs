public class Estudiante
{
    private string? _nombre;

    public string? Nombre
    {
        get => _nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException(
                    "El nombre es obligatorio");
            _nombre = value;
        }
    }

    public Estudiante(string nombre)
    {
        Nombre = nombre;
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}";
    }
}

