
public class Estudiante
{
    private string? _nombre;
    private string? _apellido;
    private double _calificacion;

    public string? Nombre
    {
        get => _nombre;
        private set => _nombre = ValidarTexto(value, "nombre");
    }

    public string? Apellido
    {
        get => _apellido;
        private set => _apellido = ValidarTexto(value, "apellido");
    }

    public double Calificacion
    {
        get => _calificacion;
        private set
        {
            if (value < 0 || value > 100)
                throw new ArgumentOutOfRangeException(nameof(value),
                    "La calificación debe estar entre 0 y 100");
            _calificacion = Math.Round(value, 1);
        }
    }

    public string NombreCompleto => $"{Nombre} {Apellido}";
    public bool EstaAprobado => Calificacion >= 60;

    public string Estado =>
        Calificacion >= 90 ? "Excelente" :
        Calificacion >= 70 ? "Bueno" :
        Calificacion >= 60 ? "Suficiente" :
        "Reprobado";

    public Estudiante(string nombre, string apellido, 
        double calificacion)
    {
        Nombre = nombre;
        Apellido = apellido;
        Calificacion = calificacion;
    }

    private string? ValidarTexto(string? texto, string campo)
    {
        if(string.IsNullOrWhiteSpace(texto))
            throw new ArgumentException
                ($"El {campo} es obligatorio");
        if (texto.Trim().Length < 2)
            throw new ArgumentException
             ($"El {campo} debe tener al menos 2 caracteres");
        return texto.Trim();
    }

    public override string ToString()
    {
        return $"{NombreCompleto, -25} | {Calificacion, 5:F1} pts | {Estado}";
    }
}

