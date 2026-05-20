using System.Collections;

int[] numeros = new int[3];
numeros[0] = 1;
numeros[1] = 2;
numeros[2] = 3;
//numeros[3] = 4;

// El código anterior lanzará una excepción de tipo IndexOutOfRangeException

int[] temp = new int[5];
Array.Copy(numeros, temp, numeros.Length);
// Ahora temp tiene los mismos elementos que numeros, pero con capacidad para 5 elementos
temp[3] = 4;
numeros = temp; // Ahora numeros tiene capacidad para 5 elementos

List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4); // No hay problema, la lista se redimensiona automáticamente
list.Add(3);
list.Remove(3); // Elimina la primera ocurrencia del valor 3
list.RemoveAt(0); // Elimina el elemento en la posición 0 (el número 1)
Console.WriteLine(list.Count);
Console.WriteLine(list[1]); // Imprime el elemento en la posición 1 (el número 4)

ArrayList arrayList = new ArrayList();
arrayList.Add(1);
arrayList.Add("Ana");
//int numero = (int)arrayList[1];

void ImprimirLista(IEnumerable<string> items)
{
    foreach (string item in items)
    {
        Console.WriteLine(item);
    }
}

List<string> nombres = new List<string> { "Ana", "Luis", "Carlos" };
ImprimirLista(nombres);
string[] nombresArray = new string[] { "Ana", "Luis", "Carlos" };
ImprimirLista(nombresArray);
HashSet<string> nombresSet = new HashSet<string> { "Ana", "Luis", "Carlos" };
ImprimirLista(nombresSet);

void ProcesarColeccion(ICollection<string> coleccion)
{
    Console.WriteLine($"La colección tiene {coleccion.Count} elementos.");

    if(!coleccion.IsReadOnly)
    {
        coleccion.Add("Nuevo elemento");
        Console.WriteLine("Se ha agregado un nuevo elemento a la colección.");
        coleccion.Remove("Alguno");
    }
    else
    {
        Console.WriteLine("La colección es de solo lectura, no se pueden agregar elementos.");
    }

    string[] array = new string[coleccion.Count];
    coleccion.CopyTo(array, 0);
}

ProcesarColeccion(nombres);

void ModificarPorIndice(IList<int> lista)
{
    Console.WriteLine(lista[0]);
    lista.Insert(1, 99); // Inserta el valor 99 en la posición 1
    lista.RemoveAt(2); // Elimina el elemento en la posición 2
    lista[0] = 42; // Modifica el elemento en la posición 0
}

List<int> numerosList = new List<int> { 1, 2, 3 };
ModificarPorIndice(numerosList);
HashSet<int> numerosSet = new HashSet<int> { 1, 2, 3 };
// ModificarPorIndice(numerosSet);

string ObtenerValorSeguro(IDictionary<string, int> dict, string clave)
{
    if (dict.TryGetValue(clave, out int valor))
    {
        return $"El valor para la clave '{clave}' es {valor}.";
    }
    else
    {
        return $"La clave '{clave}' no se encontró en el diccionario.";
    }
}

Dictionary<string, int> edades = new Dictionary<string, int>
{
    { "Ana", 30 },
    { "Luis", 25 },
    { "Carlos", 35 }
};

Console.WriteLine(edades["Ana"]);
Console.WriteLine(ObtenerValorSeguro(edades, "Luisa") );