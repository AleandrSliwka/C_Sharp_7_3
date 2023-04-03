// Задача 56: Задайте прямоугольный двумерный массив. 
//            Напишите программу, которая будет находить 
//            строку с наименьшей суммой элементов.
//            Например, задан массив:
//            1 4 7 2
//            5 9 2 3
//            8 4 2 4
//            5 2 6 7
//            Программа считает сумму элементов в каждой 
//            строке и выдаёт номер строки с наименьшей 
//            суммой элементов: 1 строка


void Print(int[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
      Console.Write($" {arr[i, j]} ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

int[,] MassRand(int row, int column, int from, int to)
{
  int[,] arr = new int[row, column];
  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
    {
      arr[i, j] = new Random().Next(from, to + 1);
    }
  return arr;
}

void minSumLine(int[,] arr)
{

  int sum = int.MaxValue;
  int index = 0;
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    int temp = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      temp += arr[i, j];
    }
    if (temp < sum)
    {
      sum = temp;
      index = i + 1;
    }
  }
  Console.WriteLine("Строка с наименьшей суммой элементов: " + index + " Сумма = " + sum);
}


Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassRand(row_num, column_num, start, stop);

Print(mass);

minSumLine(mass);

