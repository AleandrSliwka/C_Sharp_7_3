// Задача 2: Задайте значения M и N. Напишите программу, 
//           которая найдёт сумму натуральных элементов 
//           в промежутке от M до N с помощью рекурсии.

//           M = 1; N = 15 -> 120
//           M = 4; N = 8 -> 30

Console.WriteLine("Write a number M: ");
int firstValue = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write a number N: ");
int secondValue = int.Parse(Console.ReadLine()!);

int evenNaturalNumber(int M, int N)
{
  if (M > N) return 0;
  return evenNaturalNumber(M, N - 1) + N;
}

Console.WriteLine(evenNaturalNumber(firstValue, secondValue));
