/*Задача 19
Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите 5-ти значное число: ");
int a = int.Parse(Console.ReadLine()!);
int Num(int num)
{
  int num1 = num / 10000;
  int num2 = num % 10;
  int num3 = num / 1000;
  int num4 = num3 % 10;
  int num5 = num % 100;
  int num6 = num5 / 10;
  if (num1 == num2 && num4 == num6)
  {
    Console.WriteLine("Данное число является палиндромом");
  }
  else
  {
    Console.WriteLine("Данное число НЕ является палиндромом");
  }
  return num;
}
int result = Num(a);


