using System.Collections.Concurrent;

Console.WriteLine("=== DEMOSTRACIÓN DE COLECCIONES GENÉRICAS ===\n");

Console.WriteLine("---- List<T> ----");
var compras = new List<string> { "café", "pan", 
    "leche" };
compras.Add("jugo");
foreach (var compra in compras)
    Console.WriteLine(compra);
Console.WriteLine();

Console.WriteLine("---- Dictionary<TKey, TValue> ----");
var edades = new Dictionary<string, int>
{
    ["Juan"] = 30,
    ["Ana"] = 28 
};
if(edades.TryGetValue("Juan", out int edadJuan))
    Console.WriteLine($"Edad de Juan: {edadJuan}");
Console.WriteLine();

Console.WriteLine("---- HashSet<T> ----");
var numeros = new HashSet<int> { 1, 2, 3, 2, 3 };
numeros.Add(2);
Console.WriteLine($"Cantidad de elementos: {numeros.Count}");
Console.WriteLine();

Console.WriteLine("---- Stack<T> (LIFO) ----");
var historial = new Stack<string>();
historial.Push("Página 1");
historial.Push("Página 2");
historial.Push("Página 3");
Console.WriteLine($"Actual: {historial.Peek()}");
while(historial.Count > 0)
    Console.WriteLine($"Retrocediendo a: {historial.Pop()}");
Console.WriteLine();

Console.WriteLine("---- Queue<T> (FIFO) ----");
var cola = new Queue<string>();
cola.Enqueue("Primero");
cola.Enqueue("Segundo");
cola.Enqueue("Tercero");
while (cola.Count > 0)
    Console.WriteLine($"Procesando: {cola.Dequeue()}");
Console.WriteLine();

Console.WriteLine("---- ConcurrentDictionary (Hilos) ----");
var diccionarioConcurrente = new 
    ConcurrentDictionary<int,
    string>();
Parallel.For(0, 5, i =>
diccionarioConcurrente.TryAdd(i, $"Valor {i}"));
foreach (var kvp in diccionarioConcurrente)
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");



