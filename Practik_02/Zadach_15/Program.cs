// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Ведите нормер дня недели: ");
int num = int.Parse(Console.ReadLine()!);

if (num == 6 || num == 7)
{
    Console.WriteLine("Да,это выходной");
}
else if (num > 7)
{
    Console.WriteLine("Нет такого дня недели!!!");
}
else
{
    Console.WriteLine("Нет,это рабочий");
}

