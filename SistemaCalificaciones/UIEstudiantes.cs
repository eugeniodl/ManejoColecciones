public static class UIEstudiantes
{
    public static void MostrarLista(string titulo, List<Estudiante> estudiantes)
    {
        Console.WriteLine($"\n===== {titulo} =====");

        foreach (var item in estudiantes)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Total: {estudiantes.Count}");
    }

    public static void MostrarEstadisticas(RegistroEstudiantes registro)
    {
        Console.WriteLine("\n===== ESTADÍSTICAS =====");
        Console.WriteLine($"Promedio: {registro.CalcularPromedio():F1}");
        Console.WriteLine($"Máxima: {registro.ObtenerMaximaCalificacion():F1}");
        Console.WriteLine($"Mínima: {registro.ObtenerMinimaCalificacion():F1}");
    }
}

