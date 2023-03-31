// Задача 2: Напишите программу, которая найдёт точку 
//           пересечения двух прямых, заданных уравнениями 
//           y = k1 * x + b1, y = k2 * x + b2; 
//           значения b1, k1, b2 и k2 задаются пользователем.
// https://studok.net/obrazovanie-i-kommunikacii/vopros-kak-vychislit-tochku-peresechenija-dvuh-prjamyh/
//           Пример:
//           b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите b1: ");
double b_1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1: ");
double k_1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2: ");
double b_2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2: ");
double k_2 = double.Parse(Console.ReadLine()!);

void Peres(double b1, double k1, double b2, double k2)
{
  double k_sub = k1 - k2;
  if (k_sub != 0)
  {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Intersection point: ({x}; {y})");
  }
  else if (k1 == k2 && b1 == b2)
    Console.WriteLine("There are an infinite number of intersection points.");
  else
    Console.WriteLine("There is no intersection point");
}
Peres(b_1, k_1, b_2, k_2);