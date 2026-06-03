public class Libro
{
    private string _titulo;
    private string _autor;
    private decimal _precio;

    public string Titulo
    {
        get => _titulo;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El título no puede estar vacío",
                    nameof(value));
            _titulo = value.Trim();
        }
    }

    public string Autor
    {
        get => _autor;
        private set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El autor no puede estar vacío", 
                    nameof(value));
            _autor = value.Trim();
        }
    }

    public decimal Precio
    {
        get => _precio;
        private set
        {
            if(value <= 0)
                throw new ArgumentOutOfRangeException(nameof(value),
                    "El precio debe ser mayor a 0");
            if(value > 10000)
                throw new ArgumentOutOfRangeException(nameof(value),
                    "Precio excede límite comercial");

            _precio = Math.Round(value, 2);
        }
    }

    public Libro(string titulo, string autor, decimal precio)
    {
        Titulo = titulo;
        Autor = autor;
        Precio = precio;
    }
    
    public override string ToString() => $"{Titulo} - {Autor} (${Precio:F2})";
}