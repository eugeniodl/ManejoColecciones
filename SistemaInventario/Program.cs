Console.WriteLine("SISTEMA DE INVENTARIO");

var libreria = new LibreriaInventario();

libreria.MostrarInventario();

Console.WriteLine("PROCESANDO VENTAS");
libreria.Vender("978-0131345915", 1);
libreria.Vender("978-0131345915", 2);
libreria.Vender("978-0132350884", 1);  // Producto agotado
try
{

	var stock = libreria["978-0131345915"];
	Console.WriteLine($"Indexador -> ISBN 978-0131345915: {stock.OnHand} unidades");
}
catch (KeyNotFoundException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("ESTADÍSTICAS");
Console.WriteLine($"Total productos en inventario: {libreria.TotalProductos}");