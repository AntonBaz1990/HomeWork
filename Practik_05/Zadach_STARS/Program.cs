// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray(int size, int minValue, int maxValue) // Создания рандомного массива;
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
void Selection(int[] array)                       // Создание функции сортировки массива;
{
    int length = array.Length;
    for (int i = 0; i < length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}
Console.Clear();

int[] array = GetArray(10,-10, 10);   //   Задаем условия массива;
Console.WriteLine($"Вводный массив:         [{String.Join(", ", array)}]");
Selection(array);
Console.WriteLine($"Отсортированный массив: [{String.Join(", ", array)}]");



