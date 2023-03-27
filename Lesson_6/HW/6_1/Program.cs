// Задача 3: Напишите программу, которая будет создавать 
//           копию заданного двумерного массива с помощью 
//           поэлементного копирования.


void Print(int[,] arr)
{
  int size = arr.Length;

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j]} ");
    }
    Console.WriteLine();
  }
}

void Print1(int[,] arr)
{
  int size = arr.Length;

  for (int i1 = 0; i1 < arr.GetLength(0); i1++)
  {
    for (int j1 = 0; j1 < arr.GetLength(1); j1++)
    {
      Console.Write($"{arr[i1, j1]} ");
    }
    Console.WriteLine();
  }
}

int[,] RandMass(int size, int size1, int from, int to)
{
  int[,] arr = new int[size, size1];
  //int[,] copy = arr.Clone() as int[,];
  int[,] copy = new int[size, size1];

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(from, to + 1);
    }
  }
  return arr;

  for (int i1 = 0; i1 < copy.GetLength(0); i1++)
  {
    for (int j1 = 0; j1 < copy.GetLength(1); j1++)
    {
      Console.Write($"{copy[i1, j1]}");
    }
    Console.WriteLine();
  }
  return copy;
}


Console.Write("Enter the number of lines: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter minimal range value: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter maximum range value: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = RandMass(num, num1, start, stop);
Print(mass);
Console.WriteLine();
Console.WriteLine("Copy Mass:");
Console.WriteLine();
Print1(mass);