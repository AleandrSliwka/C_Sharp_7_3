// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.
//    https://4apple.org/summa-diagonalnyh-jelementov-matricy/
//    https://ru.wikipedia.org/wiki/%D0%93%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D0%B4%D0%B8%D0%B0%D0%B3%D0%BE%D0%BD%D0%B0%D0%BB%D1%8C

int[,] FilArr(int line, int pillar, int min, int max)
{
  int[,] arr = new int[line, pillar];
  for (int i = 0; i < line; i++)
  {
    for (int k = 0; k < pillar; k++)
    {
      arr[i, k] = new Random().Next(min, max + 1);
    }
  }
  return arr;
}
void Print(int[,] arr, int line, int pillar)
{
  for (int i = 0; i < line; i++)
  {
    for (int k = 0; k < pillar; k++)
    {
      Console.Write(arr[i, k]);
      Console.Write(" ");
    }
    Console.WriteLine();
  }
}
int Sum(int[,] arr)
{
  int line = arr.GetLength(0);
  int pillar = arr.GetLength(1);
  int sum = 0;
  for (int i = 0; i < line; i++)
  {
    for (int j = 0; j < pillar; j++)
    {
      if (i == j) sum += arr[i, j];
    }
  }
  return sum;
}

Console.WriteLine("Ввидите количество строк:");
int line1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите количество столбцов:");
int pillar1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите минимальное значениея массива:");
int min1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ввидите максимальное значение массива:");
int max1 = int.Parse(Console.ReadLine()!);
int[,] newarr = FilArr(line1, pillar1, min1, max1);
Print(newarr, line1, pillar1);
Console.WriteLine("Сумма элементов главной диагонали:" + Sum(newarr));