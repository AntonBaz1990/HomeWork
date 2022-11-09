// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ResultNum(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }
    return result;
}
Console.Clear();

Console.Write("Введите значение A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение B: ");
int b = int.Parse(Console.ReadLine()!);
int Num = ResultNum(a, b);
Console.WriteLine($"Степень значение A в степени В: {Num}");


// Альтернативный способ

// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int B = int.Parse(Console.ReadLine()!);
// int result = A;
// for(int i=1;i<B;i++ ) 
// {
//     result=result*A;
// }
// Console.WriteLine($"степень первого числа равена:  {result} ");