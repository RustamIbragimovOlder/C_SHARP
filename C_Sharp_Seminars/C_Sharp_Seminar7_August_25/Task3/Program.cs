// Задайте двумерный массив.
// Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

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
            matrix[i, j] = new Random().Next(1, 100);
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

int SumElementsMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] set = new int[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
if (set.GetLength(0) != set.GetLength(1))
{
    Console.WriteLine($"Главная диагональ отсутствует. Количество строк должно равняться количеству столбцов.");
}
else
{
    FillArray(set);
    PrintArray(set);
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов главной диагонали -> {SumElementsMainDiagonal(set)}");
}