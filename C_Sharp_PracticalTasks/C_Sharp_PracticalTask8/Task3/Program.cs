// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] ProductTwoMatrices(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixResult;
}

int[,] matrix1 = new int[Prompt("Введите количество строк матрицы 1 -> "),
                        Prompt("Введите количество столбцов матрицы 1 -> ")];
int minLimit1 = Prompt("Введите нижнюю границу диапазона случайных чисел матрицы 1 -> ");
int maxLimit1 = Prompt("Введите верхнюю границу диапазона случайных чисел матрицы 1 -> ");
int[,] matrix2 = new int[Prompt("Введите количество строк матрицы 2 -> "),
                        Prompt("Введите количество столбцов матрицы 2 -> ")];
int minLimit2 = Prompt("Введите нижнюю границу диапазона случайных чисел матрицы 2 -> ");
int maxLimit2 = Prompt("Введите верхнюю границу диапазона случайных чисел матрицы 2 -> ");
FillArray(matrix1, minLimit1, maxLimit1);
FillArray(matrix2, minLimit2, maxLimit2);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Умножение матриц невозможно.");
    Console.WriteLine("Число столбцов матрицы 1 должно совпадать с числом строк матрицы 2.");
}
else
{
    int[,] set = ProductTwoMatrices(matrix1, matrix2);
    PrintArray(set);
}