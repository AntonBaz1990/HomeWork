//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunc(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberN == 0 && numberM > 0) return AkkermanFunc(numberM - 1, 1);
    else return (AkkermanFunc(numberM - 1, AkkermanFunc(numberM, numberN - 1)));
}
Console.Clear();

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int a = AkkermanFunc(m, n);
Console.Write("Результат функции Аккермана: " + a);
