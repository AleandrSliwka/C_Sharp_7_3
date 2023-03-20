/* 
Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void S(int n)
{
  int a = 1;
  while (a <= n)
  {
    Console.WriteLine(a * a * a);
    a++;
  }
}
Console.WriteLine("Ввидите число: ");
S(int.Parse(Console.ReadLine()!));