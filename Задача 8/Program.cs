Console.Clear();
Console.WriteLine("Введите число");

int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(numA);
int count = 1;

while (count < numA)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
        count++;
    }

    else
        count++;
}

