//  Задача 1: Пользователь вводит с клавиатуры M чисел. 
//            Посчитайте, сколько чисел больше 0 ввёл 
//            пользователь.
//            Пример:
//            0, 7, 8, -2, -2 -> 2
//            1, -7, 567, 89, 223-> 3


Console.WriteLine("Сколько чисел хотите ввести: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите {a} чисел(а): ");
int Num(int b)
{
  int res = 0;

  for (int i = 1; i <= a; i++)
  {
    Console.Write($"Число {i}: ");
    int a = int.Parse(Console.ReadLine()!);
    if (a > 0) res++;
  }
  return res;
}

int result = Num(a);
Console.WriteLine($"Количество чисел больше 0: {result}");
