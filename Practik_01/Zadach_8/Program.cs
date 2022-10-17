// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.


Console.Clear();

Console.Write("Введите  число: ");
int num = int.Parse(Console.ReadLine()!);
int i = 2;

Console.Write("Все четные числа: ");

while (i <= num)

{
    if (i % 2 == 0)
    Console.Write($"{i}  ");
    i += 2;
}



