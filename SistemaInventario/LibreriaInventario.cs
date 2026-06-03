public class LibreriaInventario
{
    private Dictionary<string, Stock> _inventario;

    public int TotalProductos => _inventario?.Count ?? 0;

    public Stock this[string isbn]
    {
        get
        {
            if (!_inventario.ContainsKey(isbn))
                throw new KeyNotFoundException($"ISBN {isbn} no encontrado");

            return _inventario[isbn];
        }
    }

    public LibreriaInventario()
    {
        _inventario = new Dictionary<string, Stock>(StringComparer.OrdinalIgnoreCase);
        InicializartDatosDePrueba();
    }

    private void InicializartDatosDePrueba()
    {
        var libro1 = new Libro("C# 9.0 In a Nutshell", "Joseph Albahari", 59.99m);
        var libro2 = new Libro("Professional C# 7", "Christian Nagel", 49.99m);
        var libro3 = new Libro("Clean Code", "Robert C. MArtin", 45.99m);

        var stock1 = new Stock(libro1, 4);
        var stock2 = new Stock(libro2, 12);
        var stock3 = new Stock(libro3, 0);

        _inventario.Add("978-0131345915", stock1);
        _inventario.Add("978-1118314418", stock2);
        _inventario.Add("978-0132350884", stock3);
    }

    public bool Vender(string isbn, int cantidad = 1)
    {
        if (!_inventario.TryGetValue(isbn, out var stock))
        {
            Console.WriteLine($"ISBN {isbn} no encontrado en inventario");
            return false;
        }

        try
        {
            stock.ReducirStock(cantidad);
            Console.WriteLine($"Vendido: {stock.Item.Titulo} (x{cantidad}). " +
                $"Quedan: {stock.OnHand}");
            return true;
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"{ex.Message}");
            return false;
        }
    }

    public void MostrarInventario()
    {
        Console.WriteLine("INVENTARIO COMPLETO");

        foreach (var kvp in _inventario)
        {
            string isbn = kvp.Key;
            Stock stock = kvp.Value;

            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine($"Título: {stock.Item.Titulo}");
            Console.WriteLine($"Autor: {stock.Item.Autor}");
            Console.WriteLine($"Precio: ${stock.Item.Precio:F2}");
            Console.WriteLine($"Stock: {stock.OnHand} unidades");
            Console.WriteLine();
        }
    }
}