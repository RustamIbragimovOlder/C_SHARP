// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
            Console.Write("{0,7:F0}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

void FindAverageColumn(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        double average = sum / matrix.GetLength(0);
        Console.Write("{0,7:F1}", average);
    }
}

int minLimit = Prompt("Введите нижнюю границу для случайных чисел -> ");
int maxLimit = Prompt("Введите верхнюю границу для случайных чисел -> ");
int[,] set = new int[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
FillArray(set, minLimit, maxLimit);
PrintArray(set);
Console.WriteLine("Среднее арифметическое по столбцам: ");
FindAverageColumn(set);
Console.WriteLine();