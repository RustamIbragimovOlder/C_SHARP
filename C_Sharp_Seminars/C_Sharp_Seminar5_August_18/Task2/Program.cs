// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// Функция генерации массива
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
    Console.WriteLine();
}

// Функция замены элементов массива на противоположные (замена знака)
int[] ReplaceElementSign(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = -array[i];
    }
    return array;
}

int[] set = CreateArray(8, -10, 5);
PrintArray(set);
PrintArray(ReplaceElementSign(set));


