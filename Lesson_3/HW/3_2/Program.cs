/* Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B(2, 1, -7), -> 15.84

A(7, -5, 0); B(1, -1, 9)-> 11.53
*/

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
  return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}
Console.WriteLine("Введите координаты точки A: ");
Console.WriteLine("x1 = ");
int x_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("y1 = ");
int y_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("z1 = ");
int z_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки B: ");
Console.WriteLine("x2 = ");
int x_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("y2 = ");
int y_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("z2 = ");
int z_2 = int.Parse(Console.ReadLine()!);

double a = Distance(x_1, y_1, z_1, x_2, y_2, z_2);
Console.WriteLine($"Расстояние между точками A и B в 3D пространстве = {a}");
