﻿Console.WriteLine("введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int max = (num1 > num2) ? num1 : num2;
Console.WriteLine($"максимальное число {max}");

int min = (num1 < num2) ? num1 : num2;
Console.WriteLine($"минимальное число {min}");