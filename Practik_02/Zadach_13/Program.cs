// Задача 13: Напишите программу, которая выводит
// третью цифру (справа налево) заданного числа или
// сообщает, что третьей цифры нет
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = num % 1000 / 100;

if (num < 100)
{
    Console.WriteLine("третьей цифры нет !!! ");
}
else
Console.WriteLine($"Третья цифра: {num1}");



// Альтернативное решение
//Console.Clear();

//Console.WriteLine("Введите трехзначное число: ");
//int num = int.Parse(Console.ReadLine()!);

//while (num>1000)
//{
//num/=10;
//}
//int num1 = num % 10;
//Console.WriteLine($"Третья цифра: {num1}");
