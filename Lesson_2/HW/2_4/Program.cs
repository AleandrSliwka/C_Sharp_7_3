// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// Пример:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);
int Weekend(int num)
{
  if (num < 6 && num > 0) Console.WriteLine("Будни - рабочий день");
  else if (num == 6 || num == 7) Console.WriteLine("Выходной");
  else Console.WriteLine("Не относится к дням недели");
  return num;
}
Weekend(day);

/*

Второе решение:

Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);

void Weekend(int num)
{
  string text = "Не относится к дням недели";
  if (num < 6 && num > 0) text = "Будни - рабочий день";
  else if (num == 6 || num == 7) text = "Выходной";
  Console.WriteLine($"{num} - {text}");
}

Weekend(day);

Третье решение:

Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);
if (day == 1) Console.WriteLine("Понедельник - Рабочий день!");
else if (day == 2) Console.WriteLine("Вторник - Рабочий день!");
else if (day == 3) Console.WriteLine("Среда - Рабочий день!");
else if (day == 4) Console.WriteLine("Четверг - Рабочий день!");
else if (day == 5) Console.WriteLine("Пятница - Рабочий день!");
else if (day == 6) Console.WriteLine("Суббота - Выходной день!");
else if (day == 7) Console.WriteLine("Воскресенье - Выходной день!");
else Console.WriteLine("Данное число не относиться к дням недели!");

Четвертое решение:

Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);
string[] weeks =
{
  "Понедельник - Рабочий день!",
  "Вторник - Рабочий день!",
  "Среда - Рабочий день!",
  "Четверг - Рабочий день!",
  "Пятница - Рабочий день!",
  "Суббота - Выходной день!",
  "Воскресенье - Выходной день!"
};
if (day == 1) Console.WriteLine(weeks[0]);
if (day == 2) Console.WriteLine(weeks[1]);
if (day == 3) Console.WriteLine(weeks[2]);
if (day == 4) Console.WriteLine(weeks[3]);
if (day == 5) Console.WriteLine(weeks[4]);
if (day == 6) Console.WriteLine(weeks[5]);
if (day == 7) Console.WriteLine(weeks[6]);
else
  Console.WriteLine("Данное число не относиться к дням недели!");
*/