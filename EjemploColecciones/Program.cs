using System.Collections;

int[] numeros = new int[3];
numeros[0] = 1;
numeros[1] = 2;
numeros[2] = 3;
//numeros[3] = 4;

int[] temp = new int[5];
Array.Copy(numeros, temp, numeros.Length);
temp[3] = 4;
numeros = temp;

List<int> numerosList = new List<int>();
numerosList.Add(1);
numerosList.Add(2);
numerosList.Add(3);
numerosList.Add(4);
numerosList.Add(3);
numerosList.Remove(3);
numerosList.RemoveAt(0);
Console.WriteLine(numerosList.Count);

List<string> estudiantes = new List<string>();
estudiantes.Add("Vilma");
estudiantes.Add("Camila");
estudiantes.Add("Devy");
//estudiantes.Add(123);

ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("texto");

//int numero = (int)arrayList[1];


void ImprimirLista(IEnumerable<string> items)
{
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

ImprimirLista(estudiantes);

string[] arreglo = { "A", "B", "C" };

ImprimirLista(arreglo);

HashSet<string> conjunto = new HashSet<string> { "D", "E" };

ImprimirLista(conjunto);

void ProcesarColeccion(ICollection<string> coleccion)
{
    Console.WriteLine($"Total: {coleccion.Count}");

    if(!coleccion.IsReadOnly)
    {
        coleccion.Add("Nuevo elemento");
        coleccion.Remove("Alguno");
    }

    // Copiar a arreglo
    string[] copia = new string[coleccion.Count];
    coleccion.CopyTo(copia, 0);
}

ProcesarColeccion(estudiantes);

void ModificarPorIndice(IList<int> lista)
{
    Console.WriteLine(lista[0]); // Leer por índice

    lista.Insert(1, 99); // Insertar en posición específica
    lista.RemoveAt(2); // Eliminar por índice

    lista[0] = 42; // Modificar por índice
}

ModificarPorIndice(numerosList);
HashSet<int> ints = new HashSet<int> { 1, 2, 3 };
//ModificarPorIndice(ints);

string ObtenerValorSeguro(IDictionary<string, int> dict, string clave)
{
    if (dict.TryGetValue(clave, out int valor))
        return $"Encontrado: {valor}";

    return "Clave no existe";
}

Dictionary<string, int> edades = new Dictionary<string, int>();
edades.Add("Ana", 25);
edades.Add("Luis", 30);

Console.WriteLine(edades["Ana"]);
Console.WriteLine(ObtenerValorSeguro(edades, "Carlos"));