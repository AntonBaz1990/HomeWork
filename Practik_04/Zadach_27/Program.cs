// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int BigSum(int A)
{
    int sum = 0;
    int ost = 0;
    while (A > 0)
    {
        ost = A % 10;
        sum = sum + ost;
        A = A / 10;
    }return sum;
}
Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int a=BigSum(num);
Console.WriteLine($"Сумма цифр равна:  {a}");

// Альтернативное решение
// Console.Clear();

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// int sum = 0;
// int ost=0;
// while (num > 0)
// {
//     ost = num % 10;
//     sum = sum + ost;
//     num = num/10;
// }
// Console.WriteLine($"Сумма цифр равна:  {sum}");