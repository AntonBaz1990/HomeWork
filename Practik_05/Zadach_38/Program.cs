// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

void GetArray(double[] array)  // Функция рандомa массива
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] =  Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}
void PrintArray(int[] arr)  // Функция вывода массива
{
    int count = arr.Length;
    for (int index = 0; index < count; index++)
    {
        Console.Write(arr[index] + " ");
    }
}

double FindMin(double[] array)   // Функция нахождения минимального значения
{
    double countmin = array[0];
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i]<countmin)
        {
            countmin= array[i];
        }
    }
    return countmin;
}
double FindMax(double[] array) // Функция нахождения максимального значения
{
    double countmax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>countmax)
        {
            countmax= array[i];
        }
    }
    return countmax;
}
Console.Clear();

double[] array = new double[10];
GetArray(array);
Console.WriteLine($"Массив вещественных чисел: [{String.Join(" ", array)}]");
double countIndex1 = FindMin(array);
Console.WriteLine($"Минимальная велечина в масиве: {countIndex1}");
double countIndex2 = FindMax(array);
Console.WriteLine($"Максимальная велечина в масиве: {countIndex2}");
double n=FindMax(array)-FindMin(array);
Console.WriteLine($"Pазницу между максимальным и минимальным элементов массива: {n}");