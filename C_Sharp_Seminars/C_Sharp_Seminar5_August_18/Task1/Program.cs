// Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов
// массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

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

const int minus = -1; // задание переменной соответствующей знаку минус
const int plus = 1; // плюс

// Функция подсчета суммы элементов с определенным знаком
int SumSignedElements(int[] array, int sign = plus)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] * sign) > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

// Функция подсчета суммы отрицательных элементов массива
int SumNegativeElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

// Функция подсчета суммы положительных элементов массива
int SumPositiveElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

// Функция подсчета суммы положительных и отрицательных элементов массива
(int, int) SumPlusMinusElements(int[] array)
{
    int sumPlus = 0;
    int sumMinus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPlus += array[i];
        }
        if (array[i] < 0)
        {
            sumMinus += array[i];
        }
    }
    return (sumPlus, sumMinus);
}

int[] set = CreateArray(12, -9, 9);
PrintArray(set);
int sumPositive = SumPositiveElements(set);
int sumNegative = SumNegativeElements(set);
Console.WriteLine($"Сумма положительных элементов массива sumPositive -> {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов массива sumNegative -> {sumNegative}");
int sumPositiveSign = SumSignedElements(set, plus);
int sumNegativeSign = SumSignedElements(set, minus);
Console.WriteLine($"Сумма положительных элементов массива sumPositiveSign -> {sumPositiveSign}");
Console.WriteLine($"Сумма отрицательных элементов массива sumNegativeSign -> {sumNegativeSign}");
(int sumPlus, int sumMinus) = SumPlusMinusElements(set);
Console.WriteLine($"Сумма положительных элементов массива sumPlus -> {sumPlus}");
Console.WriteLine($"Сумма отрицательных элементов массива sumMinus -> {sumMinus}");
