// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

String NaturalNumbers(int number)
{
    if (number == 1) return number.ToString();
    return $"{number}, {NaturalNumbers(number - 1)}";
}
Console.Clear();

Console.WriteLine("Введите число: ");
int naturNum = int.Parse(Console.ReadLine()!);
Console.Write(String.Join(",", NaturalNumbers(naturNum)));

// Альтернативный способ

// void NaturNumInterval(int number)
// {
//     if (number == 0) return;
//     Console.Write(number + " "); NaturNumInterval(number - 1);
// }
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int naturNum = int.Parse(Console.ReadLine()!);
// NaturNumInterval(naturNum);
