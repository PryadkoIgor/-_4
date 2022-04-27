// Написать цикл, который принимает на вход два числа (A и B) и возводит число А в натуральную степень В.
//3,5->243 (3`5)
//2,4->14 (2`4)

using System;

Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetStrite(a, b));

int GetStrite(int a, int b)
{
    int i = a;
    while (b > 1)
    {
        b--;
        i *= a;
    }
    return i;
}


