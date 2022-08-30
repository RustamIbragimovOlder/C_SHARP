// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
// Значения элементов массива 0..9
// Набор данных                    Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }      // 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза

// 1, 2, 3                         // 1 встречается 3 раза
// 4, 6, 1                         // 2 встречается 2 раз 
// 2, 1, 6                         // 3 встречается 1 раз
// 4 встречается 1 раз 
// 6 встречается 2 раза

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

void PrintArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i} -> {array[i]}");
    }
    Console.WriteLine();
}

void PrintArray2(int[,] matrix)
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

int[] FrequencyDictionary(int[,] array)
{
    int[] answer = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            answer[array[i, j]]++;
        }
    }
    return answer;
}

int[,] matrix = new int[Prompt("Введите количество строк -> "), Prompt("Введите количество столбцов -> ")];
int minLimit = Prompt("Введите нижнюю границу диапазона случайных чисел -> ");
int maxLimit = Prompt("Введите верхнюю границу диапазона случайных чисел -> ");
FillArray(matrix, minLimit, maxLimit);
PrintArray2(matrix);
Console.WriteLine();
int[] set = FrequencyDictionary(matrix);
PrintArray1(set);

