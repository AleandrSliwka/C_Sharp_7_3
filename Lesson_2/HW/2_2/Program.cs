// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Write a number: ");
int a = int.Parse(Console.ReadLine()!);
if (a < 100)
{
  Console.WriteLine("Третей цифры нет");
}
else if (a < 1000)
{
  a = a % 10;
  Console.WriteLine($"Третья цифра заданного числа: {a}");
}
else if (a > 999)
{
  while (a > 999)
  {
    a = a / 10;
  }
  a = a % 10;
  Console.WriteLine($"Третья цифра заданного числа: {a}");
}
