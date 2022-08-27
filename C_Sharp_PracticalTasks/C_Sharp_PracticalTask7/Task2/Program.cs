// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void ReturnValueElementByPosition(int[,] matrix, int value)
{
    int j = value % 10;
    int i = value / 10;
    if (j >= matrix.GetLength(1) || j < 0 || i >= matrix.GetLength(0) || i < 0)
    {
        Console.WriteLine($"{value} -> такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"{value} -> {matrix[i, j]}");
    }
}

int minLimit = Prompt("Введите нижнюю границу для случайных чисел -> ");
int maxLimit = Prompt("Введите верхнюю границу для случайных чисел -> ");
int[,] set = new int[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
FillArray(set, minLimit, maxLimit);
PrintArray(set);
int number = Prompt("Введите значение позиции элемента в двумерном массиве -> ");
ReturnValueElementByPosition(set, number);