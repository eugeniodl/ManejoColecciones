var gestor = new GestorEstudiantes();

bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("=== GESTOR DE ESTUDIANTES ===");
    Console.WriteLine("1. Agregar");
    Console.WriteLine("2. Eliminar");
    Console.WriteLine("3. Listar");
    Console.WriteLine("4. Filtrar");
    Console.WriteLine("5. Ordenar");
    Console.WriteLine("6. Total");
    Console.WriteLine("7. Salir");

    Console.Write("\nOpción: ");
    string opcion = Console.ReadLine()?.Trim() ?? "";

    switch (opcion)
    {
        case "1":
            Console.Write("\nNombre: ");
            string nombre = Console.ReadLine()?.Trim() ?? "";
            gestor.Agregar(nombre);
            break;
        case "2":
            Console.Write("\nNombre: ");
            string nombreEliminar = Console.ReadLine()?.Trim() ?? "";
            gestor.Eliminar(nombreEliminar);
            break;
        case "3":
            gestor.Listar();
            Console.ReadLine();
            break;
        case "4":
            Console.Write("\nTexto a buscar: ");
            string texto = Console.ReadLine()?.Trim() ?? string.Empty;
            gestor.Filtrar(texto);
            Console.ReadLine();
            break;
        case "5":
            gestor.OrdenarPorNombre();
            Console.ReadLine();
            break;
        case "6":
            gestor.MostrarTotal();
            Console.ReadLine();
            break;
        case "7":
            salir = true;
            break;
        default:
            Console.WriteLine("Opción inválida.");
            Console.ReadLine();
            break;
    }
}