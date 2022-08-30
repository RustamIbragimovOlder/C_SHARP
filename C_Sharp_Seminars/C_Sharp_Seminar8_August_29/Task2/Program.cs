// Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

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

int[,] ReplacesRowsWithColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int temporary = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temporary;
        }
    }
    return array;
}

int[,] matrix = new int[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
int minLimit = Prompt("Введите нижнюю границу диапазона случайных чисел -> ");
int maxLimit = Prompt("Введите верхнюю границу диапазона случайных чисел -> ");
FillArray(matrix, minLimit, maxLimit);
if (matrix.GetLength(0) != matrix.GetLength(1))
{
    Console.WriteLine("Число строк не равно числу колонок");
    return;
}
PrintArray(matrix);
Console.WriteLine();
int[,] set = ReplacesRowsWithColumns(matrix);
PrintArray(set);