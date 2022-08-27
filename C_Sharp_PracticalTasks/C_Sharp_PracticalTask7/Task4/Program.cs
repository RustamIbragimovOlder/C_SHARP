// Со звездочкой(*). Найдите максимальное значение в матрице по каждой строке, ссумируйте их.
// Затем найдети минимальное значение по каждой колонке, тоже ссумируйте их.
// Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)

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

int FindSumMaxElementsLines(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int maxElementsLines = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > maxElementsLines)
            {
                maxElementsLines = matrix[i, j];
            }
        }
        sum += maxElementsLines;
    }
    return sum;
}

int FindSumMinElementsColumns(int[,] matrix)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int minElementsColumns = matrix[0, j];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, j] < minElementsColumns)
            {
                minElementsColumns = matrix[i, j];
            }
        }
        sum += minElementsColumns;
    }
    return sum;
}

int minLimit = Prompt("Введите нижнюю границу для случайных чисел -> ");
int maxLimit = Prompt("Введите верхнюю границу для случайных чисел -> ");
int[,] set = new int[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
FillArray(set, minLimit, maxLimit);
PrintArray(set);
Console.WriteLine($"Сумма максимальных элементов по строкам -> {FindSumMaxElementsLines(set)}");
Console.WriteLine($"Сумма минимальных элементов по столбцам -> {FindSumMinElementsColumns(set)}");
Console.WriteLine($"Разница между суммой максимумов по строкам и суммой минимумов по столбцам -> {FindSumMaxElementsLines(set) - FindSumMinElementsColumns(set)}");



