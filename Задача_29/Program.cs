// Написать программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1,2,5,7,19 -> [1,2,5,7,19]
// 6,1,33 -> [6,1,33]


//Console.WriteLine("Введите числа: ");

/*string number = Console.ReadLine();
void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++);
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            matrix[i, j] = new Random();Next(1, 8); 
        }
    }
    
}
int[,] matrix = new int[4, 4];
PrintArray(matrix);*/

int[,] matrix = new int[4, 4];

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i, j]}");
    }
Console.WriteLine();
}



