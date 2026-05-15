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

List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(3);
//list.Add("Ana");
list.Remove(3);
list.RemoveAt(0);
Console.WriteLine(list.Count);
Console.WriteLine(list[1]);

ArrayList lista = new ArrayList();
lista.Add(1);
lista.Add("Ana");
//int numero = (int)lista[1];


void Imprimir(IEnumerable<string> items)
{
    foreach (string item in items)
    {
        Console.WriteLine(item);
    }
}

List<string> estudiantes = new List<string>();
estudiantes.Add("Felipe");
estudiantes.Add("Alejandra");
estudiantes.Add("José");
string[] arreglo = { "Edgar", "Esteban" };
HashSet<string> conjunto = new HashSet<string> { "Axl", "Jared" };

Imprimir(estudiantes);
Imprimir(arreglo);
Imprimir(conjunto);

void ProcesarColeccion(ICollection<string> coleccion)
{
    Console.WriteLine($"Total: {coleccion.Count}");

    if(!coleccion.IsReadOnly)
    {
        coleccion.Add("Nuevo elemento");
        coleccion.Remove("Alguno");
    }

    string[] copia = new string[coleccion.Count];
    coleccion.CopyTo(copia, 0);
}

ProcesarColeccion(estudiantes);

void ModificarPorIndice(IList<int> lista)
{
    Console.WriteLine(lista[0]);
    lista.Insert(1, 99);
    lista.RemoveAt(2);
    lista[0] = 100;
}

List<int> ints = new List<int> { 1, 2, 3};
ModificarPorIndice(ints);
HashSet<int> ints1 = new HashSet<int> { 1, 2, 3 };
//ModificarPorIndice(ints1);

string ObtenerValorSeguro(IDictionary<string, int> dict, string clave)
{
    if (dict.TryGetValue(clave, out int valor))
        return $"Encontrado: {valor}";

    return "Clave no existe";
}

Dictionary<string, int> edades = new Dictionary<string, int>();
edades.Add("Ana", 25);
edades.Add("Luis", 30);
edades.Add("Adolfo", 30);
edades.Add("Roberto", 30);

Console.WriteLine(edades["Ana"]);
Console.WriteLine(ObtenerValorSeguro(edades, "Luis"));

