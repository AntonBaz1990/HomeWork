// Задача 21: Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
//  A (3,6,8); B (2,1,-7), -> 15.84
//  A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
double AB(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result =Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

Console.WriteLine("Введите значение первой точки: Х1= ");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение первой точки: Y1= ");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение первой точки: Z1= ");
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение второй точки: Х2= ");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение второй точки: Y2= ");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение второй точки: Z2= ");
double z2 = double.Parse(Console.ReadLine()!);

Console.Write($"Длина отрезка: {AB(x1, y1, z1, x2, y2, z2):f2}");