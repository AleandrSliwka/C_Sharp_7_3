/*
Задача 36: Задайте одномерный массив, заполненный случайными 
           числами. Найдите сумму элементов, 
           стоящих на нечётных позициях.
           Пример:
           [3, 7, 23, 12] -> 19
           [-4, -6, 89, 6] -> 0
*/

void Print(int[] arr)
{
  int size = arr.Length;
  for (int i = 0; i < size; i++)
    Console.Write($"{arr[i]} ");
  Console.WriteLine();
}

int[] RandMass(int size, int from, int to)
{
  int[] arr = new int[size];

  for (int i = 0; i < size; i++)
    arr[i] = new Random().Next(from, to + 1);
  return arr;
}

int SumNum(int[] num)
{
  int sum = 0;
  for (int i = 0; i < num.Length; i = i + 2)
  {
    sum += num[i];
  }
  return sum;
}

Console.Write("Enter array length: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter minimal range value: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter maximum range value: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = RandMass(num, start, stop);
Print(mass);
Console.WriteLine($"Sum of elements in odd positions: {SumNum(mass)} ");