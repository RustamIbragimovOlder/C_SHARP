// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых
// лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов.
// В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// Функция создания массива
int[] CreateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

// Функция вывода массива на консоль
void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

// Функция подсчете количества элементов массива, значения которых лежат в заданном отрезке
int CountingNumberArrayElements(int[] array, int minLimit, int maxLimit)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= minLimit & array[i] <= maxLimit)
        {
            count++;
        }
    }
    return count;
}

int[] set = CreateArray(123, 0, 1000);
PrintArray(set);
Console.WriteLine($"-> {CountingNumberArrayElements(set, 10, 99)}");
