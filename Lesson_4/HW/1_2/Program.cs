// 3. Напишите программу, которая задаёт массив из 8 элементов
//    случайными числами и выводит их на экран. Оформите заполнение массива
//    и вывод в виде функции (пригодится в следующих задачах)


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

Console.Write("Enter array length: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter minimal range value: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter maximum range value: ");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = RandMass(num, start, stop);
Print(mass);
