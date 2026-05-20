using System.Collections;

int[] ints = new int[3];

ints[0] = 1;
ints[1] = 2;
ints[2] = 3;
//ints[3] = 4;

int[] temp = new int[5];
Array.Copy(ints, temp, ints.Length);
temp[3] = 4;
ints = temp;

List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);

list.Remove(3); // por valor
list.RemoveAt(0); // por índice
Console.WriteLine($"Tamaño: {list.Count}"); // tamaño actual
Console.WriteLine($"Elemento -> {list[1]}");

foreach (var item in list)
{
    Console.WriteLine($"Elemento -> {item}");
}

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"Elemento -> {list[i]}");
}

var nombres = new List<string>();
nombres.Add("Ana");
//nombres.Add(123);

var lista = new ArrayList();
lista.Add("texto");
//lista.Add(123);
//int numero = (int)lista[0];

void Imprimir(IEnumerable<string> items)
{
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}

string[] arreglo = { "A", "B" };
HashSet<string> conjunto = new HashSet<string> { "E", "F" };
Imprimir(nombres);
Imprimir(arreglo);
Imprimir(conjunto);


void ProcesarColeccion(ICollection<string> coleccion)
{
    Console.WriteLine($"Total: {coleccion.Count}");

    if (!coleccion.IsReadOnly)
    {
        coleccion.Add("Nuevo elemento");
        coleccion.Remove("Alguno");
    }

    string[] copia = new string[coleccion.Count];
    coleccion.CopyTo(copia, 0);
}

List<string> strings = new List<string> { "X", "Y" };
ProcesarColeccion(strings);


void ModificarPorIndice(IList<int> list)
{
    Console.WriteLine(list[0]);
    list.Insert(1, 99);
    list.RemoveAt(2);
    list[0] = 100;
}

List<int> nums = new List<int> { 1, 2, 3 };
ModificarPorIndice(nums);

HashSet<int> set = new HashSet<int> { 1, 2, 3 };
//ModificarPorIndice(set);

