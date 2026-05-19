using System.Collections.Concurrent;

Console.WriteLine
    ("=== DEMOSTRACIÓN DE COLECCIONES GENÉRICAS ===\n");

// 1. List<T> - Lista genérica
var compras = new List<string> { "café", "pan", "leche" };
compras.Add("jugo");
foreach (var item in compras)
{
    Console.WriteLine($"Compra: {item}");
}
Console.WriteLine();

// 2. Dictionary<TKey, TValue> - Diccionario genérico
var edades = new Dictionary<string, int>
{
    ["Alice"] = 30,
    ["Bob"] = 25
};
if (edades.TryGetValue("Alice", out int edadAlice))
{
    Console.WriteLine($"La edad de Alice es: {edadAlice}");
}
Console.WriteLine();

// 3. HashSet<T> - Conjunto genérico
var numeros = new HashSet<int> { 1, 2, 3, 2, 3 };
numeros.Add(2); // No se agregará porque ya existe
Console.WriteLine($"Cantidad de números únicos: {numeros.Count}");
Console.WriteLine();

// 4. Queue<T> - Cola genérica
var cola = new Queue<string>();
cola.Enqueue("Primero");
cola.Enqueue("Segundo");
cola.Enqueue("Tercero");
while (cola.Count > 0)
    Console.WriteLine($"Procesando: {cola.Dequeue()}");
Console.WriteLine();

// 5. Stack<T> - Pila genérica
var historial = new Stack<string>();
historial.Push("Página 1");
historial.Push("Página 2");
historial.Push("Página 3");
Console.WriteLine($"Actual: {historial.Peek()}");
while (historial.Count > 0)
    Console.WriteLine($"Retrocediendo a: {historial.Pop()}");
Console.WriteLine();

// 6. ConcurrentDictionary (Thread-Safety)
Console.WriteLine("----- ConcurrentDictionary (Hilos) -----");
var diccionarioConcurrente = new ConcurrentDictionary<int, string>();
Parallel.For(0, 5, i => diccionarioConcurrente.TryAdd(i, $"Valor {i}"));
foreach (var kvp in diccionarioConcurrente)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}

Console.WriteLine();