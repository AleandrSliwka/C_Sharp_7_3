/* Задача 27: Напишите программу, которая принимает 
              на вход число и выдаёт сумму цифр в числе.
              Пример:
              452 -> 11
              82 -> 10
              9012 -> 12
*/

Console.WriteLine("Write A number: ");
int a = int.Parse(Console.ReadLine()!);
int SumNum(int num)
{
  int num_1 = 0;
  while (num > 0)
  {
    num_1 += num % 10;
    num /= 10;
  }
  return num_1;
}
SumNum(a);
Console.WriteLine($"Сумма чисел заданного числа = {SumNum(a)}");
