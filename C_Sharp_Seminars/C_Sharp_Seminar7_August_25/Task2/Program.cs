// Задайте двумерный массив. Найдите элементы,
// у которых обе позиции чётные, и замените эти элементы
// на их квадраты.
//Например, изначально массив
// выглядел вот так:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//Новый массив будет выглядеть 
//вот так:
//1   4  7  2
//5  81  2  9
//8   4  2  4

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ConvertEvenPositionToSqrt(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
    }
    return matrix;
}

int[,] set = new int[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
FillArray(set);
PrintArray(set);
Console.WriteLine();
int[,] array = ConvertEvenPositionToSqrt(set);
PrintArray(array);
