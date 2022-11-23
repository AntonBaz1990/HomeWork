// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}
void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.Clear();

int size = InputInt("Введите размер матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
int[,] matrixAB = new int[size, size];
GetArray(matrixA);
GetArray(matrixB);
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixAB[i, j] = matrixAB[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица: А");
PrintArray(matrixA);
Console.WriteLine("Матрица: В");
PrintArray(matrixB);
Console.WriteLine("Произведение матриц: А*В");
PrintArray(matrixAB);
