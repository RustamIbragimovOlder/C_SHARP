// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void FillArray(double[,] matrix, double minLimit, double maxLimit)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (maxLimit - minLimit) * random.Next() / 2147483648 + minLimit;
        }
    }
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,7:F1}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

int minLimit = Prompt("Введите нижнюю границу для определения случайных чисел -> ");
int maxLimit = Prompt("Введите верхнюю границу для определения случайных чисел -> ");
double[,] set = new double[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
FillArray(set, minLimit, maxLimit);
PrintArray(set);