// Найдите максимальное значение в матрице по каждой строке, ссумируйте их.
// Затем найдите минимальное значение по каждой колонке, тоже ссумируйте их.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами).

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

int CalculationSumMaximumElementsLines(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int maximumElementsLines = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > maximumElementsLines)
            {
                maximumElementsLines = matrix[i, j];
            }
        }
        sum += maximumElementsLines;
    }
    return sum;
}

int CalculationSumMinimumElementsColumns(int[,] matrix)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int minimumElementsColumns = matrix[0, j];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, j] < minimumElementsColumns)
            {
                minimumElementsColumns = matrix[i, j];
            }
        }
        sum += minimumElementsColumns;
    }
    return sum;
}

int minLimit = Prompt("Введите нижнюю границу для случайных чисел -> ");
int maxLimit = Prompt("Введите верхнюю границу для случайных чисел -> ");
int[,] set = new int[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
FillArray(set, minLimit, maxLimit);
PrintArray(set);
Console.WriteLine($"Сумма максимальных элементов по строкам -> {CalculationSumMaximumElementsLines(set)}");
Console.WriteLine($"Сумма минимальных элементов по столбцам -> {CalculationSumMinimumElementsColumns(set)}");
Console.WriteLine($"Разница между суммой максимумов по строкам и суммой минимумов по столбцам -> {CalculationSumMaximumElementsLines(set) - CalculationSumMinimumElementsColumns(set)}");
