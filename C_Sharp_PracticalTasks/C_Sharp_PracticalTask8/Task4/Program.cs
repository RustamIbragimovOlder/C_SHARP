// Со звездочкой (*) Напишите программу, которая заполнит спирально квадратный массив.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

// Заполнить массив по спирали
void FillArray(int[,] matrix)
{
    int index = 1;
    int i = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = index++;
    }
    for (i = 1; i < matrix.GetLength(0); i++)
    {
        int j = matrix.GetLength(1) - 1;
        matrix[i, j] = index++;
    }
    for (int j = matrix.GetLength(0) - 2; j >= 0; j--)
    {
        i = matrix.GetLength(0) - 1;
        matrix[i, j] = index++;
    }
    for (i = matrix.GetLength(0) - 2; i >= 1; i--)
    {
        int j = 0;
        matrix[i, j] = index++;
    }
    for (int j = 1; j < matrix.GetLength(1) - 1; j++)
    {
        i = 1;
        matrix[i, j] = index++;
    }
    for (i = 2; i < matrix.GetLength(0) - 1; i++)
    {
        int j = matrix.GetLength(1) - 2;
        matrix[i, j] = index++;
    }
    for (int j = matrix.GetLength(0) - 3; j > 0; j--)
    {
        i = matrix.GetLength(0) - 2;
        matrix[i, j] = index++;
    }
    for (i = matrix.GetLength(0) - 3; i > 1; i--)
    {
        int j = 1;
        matrix[i, j] = index++;
    }
    for (int j = 2; j < matrix.GetLength(1) - 2; j++)
    {
        i = 2;
        matrix[i, j] = index++;
    }
    for (i = 3; i < matrix.GetLength(0) - 2; i++)
    {
        int j = matrix.GetLength(1) - 3;
        matrix[i, j] = index++;
    }
    for (int j = matrix.GetLength(0) - 4; j > 1; j--)
    {
        i = matrix.GetLength(0) - 3;
        matrix[i, j] = index++;
    }
    for (int j = 2; j < matrix.GetLength(1) - 3; j++)
    {
        i = 3;
        matrix[i, j] = index++;
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

int rows = Prompt("Введите количество строк -> ");
int columns = Prompt("Введите количество столбцов -> ");
int[,] matrix = new int[rows, columns];
if (rows != columns)
{
    Console.WriteLine("Такую матрицу заполнить по спирали невозможно");
    Console.WriteLine("Количество строк должно равняться количеству столбцов");
}
else
{
    FillArray(matrix);
    PrintArray(matrix);
}







