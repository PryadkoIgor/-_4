﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 - > 12


Console.Clear();
Console.WriteLine("Введите число: ");
string? number = Console.ReadLine();

int sum = 0;

for (int i = 0; i < number.Length; i++)
{
    sum += Convert.ToInt32(number[i].ToString());
}
Console.WriteLine(sum);

