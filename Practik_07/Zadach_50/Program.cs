// Задача 50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}
bool FindNumber(int[,] array, int findNumber)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (findNumber == array[i, j])
            {
                findNumber = array[i, j];
                Console.WriteLine($"Индексы искомого числа: {findNumber} являются: строка: {i + 1} стольбец: {j + 1}");
                return true;
            }
        }
    }
    Console.WriteLine("Такого числа нет!");
    return false;
}
Console.Clear();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во стобцов: ");
int cols = int.Parse(Console.ReadLine()!);
Console.Write("Введите искомое число: ");
int findNumber = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, cols, 0, 10);
PrintArray(array);
FindNumber(array, findNumber);

