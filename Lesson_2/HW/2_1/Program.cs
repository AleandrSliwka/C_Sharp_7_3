// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите 3-х значное число: ");
int a = int.Parse(Console.ReadLine()!);
int num(int num)
{
  int num1 = num % 100;
  int num2 = num1 / 10;
  return num2;
}

int result = num(a);

Console.WriteLine(result);