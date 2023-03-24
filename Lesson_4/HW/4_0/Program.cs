/*
Задача 25: Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.
Пример:
3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Write a number A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write a number B: ");
int B = int.Parse(Console.ReadLine()!);

int Exponent(int A, int B)
{
  int x = A;
  for (int i = 1; i < B; i++)
  {
    x = x * A;
  }
  return x;
}
int result = Exponent(A, B);
Console.WriteLine($"Число A в степини B = {result}");