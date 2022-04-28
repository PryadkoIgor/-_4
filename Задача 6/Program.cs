Console.Clear();
Console.WriteLine("Введите число");

int num1 = Convert.ToInt32(Console.ReadLine());
string num=(num1%2==0)?$"четное число" : $"не четное число";

Console.WriteLine(num);

