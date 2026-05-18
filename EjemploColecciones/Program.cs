using System.Collections;

int[] numeros = new int[5];
numeros[0] = 1;
numeros[1] = 2;
numeros[2] = 3;
numeros[3] = 4;
numeros[4] = 5;
//numeros[5] = 6; // Esto causará un error de índice fuera de rango

int[] temp = new int[10];
Array.Copy(numeros, temp, numeros.Length);
temp[5] = 6;
numeros = temp;

List<int> numerosList = new List<int>();
numerosList.Add(1);
numerosList.Add(2);
numerosList.Add(3);
numerosList.Add(4);
numerosList.Add(5);
numerosList.Add(6);
//numerosList.Add("texto");
numerosList.Remove(4);
numerosList.RemoveAt(0);
Console.WriteLine(numerosList.Count);
Console.WriteLine(numerosList[1]);

ArrayList lista = new ArrayList();
lista.Add("texto");
lista.Add(123);
//int numero = (int)lista[0];

void ImprimirCualquierLista(IEnumerable<string> items)
{
    foreach (string item in items)
    {
        Console.WriteLine(item);
    }
}

List<string> estudiantes = new List<string>
{
    "Juan", "Abigail", "Carlos", "Camila", "Jazmín"
};
ImprimirCualquierLista(estudiantes);

string[] arreglo = { "A", "B", "C", "D" };
ImprimirCualquierLista(arreglo);

HashSet<string> conjunto = new HashSet<string> 
{ "E", "F", "F", "G" };
ImprimirCualquierLista(conjunto);

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
    Console.WriteLine(lista[0]); // Leer por índice

    lista.Insert(1, 99); // Insertar en medio

    lista.RemoveAt(2); // Eliminar por posición

    lista[0] = 100; // Modificar por índice
}

ModificarPorIndice(numerosList);
HashSet<int> ints = new HashSet<int> { 1, 2, 3, 4 };
//ModificarPorIndice(ints);

string ObtenerValorSeguro(IDictionary<string, int> dict,
    string clave)
{
    if (dict.TryGetValue(clave, out int valor))
        return $"Encontrado: {valor}";

    return "Clave no existe";
}

Dictionary<string, int> edades = new Dictionary<string, int>();
edades.Add("Ana", 18);
edades.Add("Luis", 25);

Console.WriteLine(edades["Ana"]);
Console.WriteLine(ObtenerValorSeguro(edades, "Carlos"));