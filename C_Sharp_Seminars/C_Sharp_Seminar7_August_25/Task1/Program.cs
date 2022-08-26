// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1     4    8   19
// 5   -2  33   -2
// 77  3    8     1

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
            matrix[i, j] = new Random().Next(-99, 100);
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

int[,] matrix = new int[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
FillArray(matrix);
PrintArray(matrix);