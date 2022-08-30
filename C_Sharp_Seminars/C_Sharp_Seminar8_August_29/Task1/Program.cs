// Задайте двумерный массив.
// Напишите программу, которая поменяет местами
// первую и последнюю строку массива.

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void FillArray(int[,] matrix, int minLimit, int maxLimit)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(minLimit, maxLimit);
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

int[,] ReplacingFirstAndLastLines(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temporary = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temporary;
    }
    return array;
}

int[,] matrix = new int[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
int minLimit = Prompt("Введите нижнюю границу диапазона случайных чисел -> ");
int maxLimit = Prompt("Введите верхнюю границу диапазона случайных чисел -> ");
FillArray(matrix, minLimit, maxLimit);
PrintArray(matrix);
Console.WriteLine();
int[,] set = ReplacingFirstAndLastLines(matrix);
PrintArray(set);