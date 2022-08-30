// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

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

int[] FindiIndexMinimumElement(int[,] array)
{
    int[] answer = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[answer[0], answer[1]])
            {
                answer[0] = i;
                answer[1] = j;
            }
        }
    }
    return answer;
}

int[,] DeleteRowAndColumnMinimumElement(int[,] array)
{
    int[] indexes = FindiIndexMinimumElement(array);
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
int l = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != indexes[0] && j != indexes[1])
            {
                result[k, l] = array[i, j];
                l++;
            }
        }
        if (i != indexes[0])
        {
            k++;
        }
    }
    return result;
}

int[,] matrix = new int[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
int minLimit = Prompt("Введите нижнюю границу диапазона случайных чисел -> ");
int maxLimit = Prompt("Введите верхнюю границу диапазона случайных чисел -> ");
FillArray(matrix, minLimit, maxLimit);
PrintArray(matrix);
Console.WriteLine();
int[,] set = DeleteRowAndColumnMinimumElement(matrix);
PrintArray(set);