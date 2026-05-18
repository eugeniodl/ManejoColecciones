int[] numeros = { 1, 2, 3, 4, 5 };
numeros[0] = 10; // Modificar el primer elemento del arreglo
numeros[1] = 10; // Modificar el primer elemento del arreglo
numeros[2] = 10; // Modificar el primer elemento del arreglo
numeros[3] = 10; // Modificar el primer elemento del arreglo
numeros[4] = 10; // Modificar el primer elemento del arreglo
//numeros[5] = 10; // Esto causará un error de índice fuera de rango

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

int[] temp = new int[10];
Array.Copy(numeros, temp, numeros.Length);

List<int> numerosList = new List<int> { 1, 2, 3, 4, 5 };
numerosList.Add(10); // Agregar un nuevo elemento a la lista

foreach (int numero in numerosList)
{
    Console.WriteLine(numero);
}
