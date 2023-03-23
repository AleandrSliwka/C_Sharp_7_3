/* 
Задача 38: Задайте массив вещественных чисел. 
           Найдите разницу между максимальным и 
           минимальным элементов массива.
           Пример:
           [3 7 22 2 78] -> 76
*/

void Print(double[] arr)
{
  int size = arr.Length;
  for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
  Console.WriteLine();
}

double[] RandMass(int size)
{
  double[] arr = new double[size];

  for (int i = 0; i < size; i++)
    arr[i] = new Random().NextDouble() * 100.0;
  return arr;
}

void ElemRaz(double[] num)
{
  double min = num[0];
  double max = 0;
  for (int i = 0; i < num.Length; i++)
  {
    if (num[i] < min) min = num[i];
    if (num[i] > max) max = num[i];
  }
  Console.WriteLine($"Min element mass: {min}");
  Console.WriteLine($"Max element mass: {max}");
  Console.WriteLine($"Raznica mezhdu max i min: {max - min}");
}

Console.Write("Enter array length: ");
int num = int.Parse(Console.ReadLine()!);


double[] mass = RandMass(num);
Print(mass);
ElemRaz(mass);