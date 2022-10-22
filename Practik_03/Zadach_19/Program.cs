// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Clear();

void Numb(int num)
{   
    int right = num / 10000;
    int left = num % 10;
    int right1 = num / 1000 % 10;
    int left1 = num % 100 / 10;
    if (num < 10000 || num > 99999) 
    {
        Console.WriteLine("Вы ввели не пятизначное число!!!");
    }
    else if (right == left && right1 == left1) 
    {
        Console.WriteLine("Да, это палиндромом");
    }
    else Console.WriteLine("НЕТ, это не палиндромом");
}
Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
Numb(num);

// Альтернативный способ


//Console.Clear();
//Console.WriteLine("Введите пятизначное число: ");
//int num = int.Parse(Console.ReadLine()!);
//int right = num / 10000;
//int left = num % 10;
//int right1 = num / 1000 % 10;
//int left1 = num % 100 / 10;
//if (num < 10000 || num > 99999) Console.WriteLine("Вы ввели не пятизначное число!!!");
//else if (right == left && right1 == left1) Console.WriteLine("Да, это палиндромом");
//else Console.WriteLine("НЕТ, это не палиндромом");