// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7.3 22.2 2 78] -> 76

// Функция создания массива
double[] CreateArray(int length)
{
    double[] answer = new double[50];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = Math.Round((100 - rnd.Next(100) + rnd.NextDouble()), 2);
    }
    return answer;
}

// Функция вывода массива на консоль
void PrintArray(double[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    Console.WriteLine();
}

// Функция поиска максимальныго элемента массива
double SearchMaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

// Функция поиска минимального элемента массива
double SearchMinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] set = CreateArray(100);
PrintArray(set);
double max = SearchMaxElement(set);
double min = SearchMinElement(set);
Console.WriteLine($"Максимальный элемент массива -> {max}");
Console.WriteLine($"Минимальный элемент массива -> {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива -> {max - min}");