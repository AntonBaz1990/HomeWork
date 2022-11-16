// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void newArray(int[] getArray)              // Функция ввода чисел массива
{
    for (int i = 0; i < getArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");
        getArray[i] = int.Parse(Console.ReadLine()!);
    }
}
String ArrayToString(int[] array)            // Вывод массива
{
    return "[" + String.Join(", ", array) + "]";
}
int SumNum(int[] array)                    // Функция счетчика положительных чисел
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum++;
    }
    return sum;
}
Console.Clear();
Console.Write("Введите количество элементов массива:\t");
int numCount = int.Parse(Console.ReadLine()!);
int[] getArray = new int[numCount];
newArray(getArray);
int Sum = SumNum(getArray);
Console.WriteLine(ArrayToString(getArray));               
Console.WriteLine($"Количество положительных чисел: {Sum}");