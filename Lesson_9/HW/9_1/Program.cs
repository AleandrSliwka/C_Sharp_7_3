// Задача 1: Задайте значения M и N. Напишите программу, 
//           которая выведет все чётные натуральные числа 
//           в промежутке от M до N с помощью рекурсии.
//           M = 1; N = 5 -> "2, 4"
//           M = 4; N = 8 -> "4, 6, 8"

Console.WriteLine("Write a number M: ");
int firstValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write a number N: ");
int secondValue = int.Parse(Console.ReadLine()!);

void evenNaturalNumber(int M, int N)
{
  if (M > N) return;
  if (N % 2 == 0)
  {
    evenNaturalNumber(M, N - 2);
    Console.Write($"{N} ");
  }
  if (N % 2 != 0)
  {
    N = N - 1;
    evenNaturalNumber(M, N - 2);
    Console.Write($"{N} ");
  }
}
evenNaturalNumber(firstValue, secondValue);
