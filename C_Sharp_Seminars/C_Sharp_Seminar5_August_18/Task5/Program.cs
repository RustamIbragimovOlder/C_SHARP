// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] RandomArray(int Length)
{
    int[] array = new int[Length];
    int index = 0;
    while(index < array.Length)
    {
        array[index] = new Random().Next(1,5);
        index++;
    }
    return array;
}

void PrintArray(int[] a)
{
    int count = a.Length;
    int i = 0;
    while (i < count)
    {
        Console.Write($"{a[i]}  ");
        i++;
    }
    Console.WriteLine();
}

int[] MultiPairArray(int[] a)
{
    int count = a.Length;
    int[] result = new int[(count / 2) + (count % 2)];
    result[result.Length - 1] = a[result.Length - 1]; 
    for(int i = 0; i < (count / 2); i++)
    {
        result[i] = a[i] * a[a.Length - i - 1];
    }
    return result;
}

int[] array = RandomArray(7);
PrintArray(array);
PrintArray(MultiPairArray(array));
