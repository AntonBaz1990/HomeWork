// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
string getNum(int n)
{
    string result = " ";
    for (int i = 1; i < n; i++)
    {
        result += (Math.Pow(i, 3)).ToString()+", ";
    }
    result +=Math.Pow(n, 3).ToString();
    return result;
}
Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(getNum(n));