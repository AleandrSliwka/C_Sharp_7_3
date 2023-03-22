/* Задача 34: Задайте массив заполненный случайными положительными 
              трёхзначными числами. Напишите программу, 
              которая покажет количество чётных чисел в массиве.
              Пример:
              [345, 897, 568, 234] -> 2
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

int EvenNum(int[] num)
{
  int a = 0;
  for (int i = 0; i < num.Length; i++)
  {
    if (num[i] % 2 == 0)
    {
      a++;
    }
  }
  return a;
}

Console.Write("Enter array length: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter minimal range value: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter maximum range value: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = RandMass(num, start, stop);
Print(mass);
Console.WriteLine($"Number of even numbers in array: {EvenNum(mass)} ");