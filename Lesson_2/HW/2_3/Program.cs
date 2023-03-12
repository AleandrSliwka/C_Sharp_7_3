// Напишите программу, которая выводит случайное трехзначное
// число и удаляет вторую цифру этого числа.
// Пример:
// 456 -> 46
// 782 -> 72
// 918 -> 98

int TakeNum(int num)
{
  Console.WriteLine(num);
  int num1 = num / 100;
  int num2 = num % 10;
  return (num1 * 10 + num2);
}
int th_num = new Random().Next(100, 1000);
int result = TakeNum(th_num);
Console.WriteLine(result);