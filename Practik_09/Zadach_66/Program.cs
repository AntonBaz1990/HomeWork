// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturNumbers(int numberM, int numberN)
{
    if (numberM == numberN) return numberN;
    return SumNaturNumbers(numberM + 1, numberN) + numberM;
}
Console.Clear();

Console.WriteLine("Введите начало интервала: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец интервала: ");
int numberN = int.Parse(Console.ReadLine()!);
int sumNumber = SumNaturNumbers(numberM, numberN);
Console.Write($"Cумма чисел интервала от {numberM} до {numberN} ровна: " + sumNumber);
