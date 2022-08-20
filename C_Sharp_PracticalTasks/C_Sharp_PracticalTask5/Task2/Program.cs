// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Функция создания массива
int[] CreateArray(int length, int minLimit, int maxLimit)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(minLimit, maxLimit);
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
    Console.WriteLine();
}

// Функция подсчета суммы элементов, стоящих на нечётных позициях
int SumElementsOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] set = CreateArray(10, -10, 20);
PrintArray(set);
int sumOddPositions = SumElementsOddPositions(set);
Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях -> {sumOddPositions}");