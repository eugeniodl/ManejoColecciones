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
