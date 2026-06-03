public class Stock
{
    private Libro _item;
    private int _onHand;

    public Libro Item
    {
        get => _item;
        private set
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value),
                    "El libro no puede ser null");
            _item = value;
        }
    }

    public int OnHand
    {
        get => _onHand;
        private set
        {
            if (value < 0)
                throw new InvalidOperationException("El stock no puede ser negativo");
            _onHand = value;
        }
    }

    public Stock(Libro libro, int cantidadInicial)
    {
        Item = libro;
        OnHand = cantidadInicial;
    }

    public void ReducirStock(int cantidad)
    {
        if (cantidad <= 0)
            throw new ArgumentException("La cantidad debe ser positiva",
                nameof(cantidad));

        if (_onHand < cantidad)
            throw new InvalidOperationException($"Stock insuficiente, Disponible: {OnHand}");

        _onHand -= cantidad;
    }

    public void AumentarStock(int cantidad)
    {
        if (cantidad <= 0)
            throw new ArgumentException("La cantidad debe ser positiva",
                nameof(cantidad));

        _onHand += cantidad;
    }

    public override string ToString()
    {
        return $"{_item.Titulo} - Stock: {_onHand}";
    }
}