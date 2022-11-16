// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты точек заданных прямых.\nзначения b1, k1, b2 и k2 задаются пользователем.");
Console.WriteLine("значения b1, k1, b2 и k2 задаются пользователем.");
Console.Write ("Введите b1:\t");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите k1:\t");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите b2:\t");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите k2:\t");
double k2 = Convert.ToDouble(Console.ReadLine());


void Method()                             // Функция вывода пересечения прямых
{
    double x = 0;
    double y = 0;
    if (b1 == b2 & k1 == k2) Console.WriteLine("Прямые совпадают");
    else if (k1 == k2) Console.WriteLine("Прямые параллельны друг другу");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine("точка пересечения " + " (" + x + " ; " + y + ")");
    }
}
Method();


////// Решение вывод икса
//k1 * x + b1 - k2 * x - b2)=0
// x(k1-k2)+b1-b2 =0  =>... x(k1-k2)=b2-b1 =>... x=(b2-b1)/(k1-k2)

// y = 5 * x + 2
// y = 9 * x + 4

//x =-0.5    =>...   y=9 *(-0.5) + 4   =>...   y=-0.5