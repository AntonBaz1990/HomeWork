// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] FindLessThan(string[] arrayIn, int n)
 {
    string[] arrayOut = new string[CountLessThan(arrayIn, n)];

    for(int m = 0 , i = 0; i < arrayIn.Length; i++) 
    {
        if(arrayIn[i].Length <= n) 
        {
            arrayOut[m] = arrayIn[i];
            m++;
        }
    }
    return arrayOut;
}
int CountLessThan(string[] arrayIn, int n) {
    int count = 0;
    for(int i = 0; i < arrayIn.Length; i++) 
    {
        if(arrayIn[i].Length <= n) 
        {
            count++;
        }
    }
    return count;
}
string[] AskArray() 
{
    Console.Write("Введите значения массива через пробел: ");
    return Console.ReadLine().Split(" ");
}
Console.Clear();

string[] array = AskArray();
string[] resultArray = FindLessThan(array, 3);
Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", resultArray)}]");
