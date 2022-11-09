// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Решение с двумя циклами !!!

int FillArray(int[] mass)
{
    int length=mass.Length;
    for (int i = 0; i < length; i++)
    {
        mass[i] = int.Parse(Console.ReadLine());
    }
    return length;
}
int PrintArray(int[] col)
{
    int count=col.Length;
    for(int index=0;index<count-1;index++ )
    {
        Console.Write($" {col[index]},");
    }
    Console.Write($" {col[7]} ");
    return count;
}
Console.Clear();

Console.WriteLine("Введите элементы массива массива");
int[] array = new int[8];
FillArray(array);
Console.Write("Массив: [");
PrintArray(array);
Console.Write("]");

// Решение с одним циклом!!!

// void FillArray(int[] mass)
// {
//     int length=mass.Length;
//     for (int i = 0; i < length; i++)
//     {
//         mass[i] = int.Parse(Console.ReadLine());
//     }
// }
// Console.Clear();

// Console.WriteLine("Введите элементы массива массива");
// int[] array = new int[8];
// FillArray(array);
// Console.WriteLine("Массив: [{0}]", String.Join(", ", array));