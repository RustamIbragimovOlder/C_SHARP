// Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран.
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных)
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

// Функция генерации массива
int[] FillArray(int Length, int firstElement, int lastElement)
{
    int[] array = new int[Length];
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(firstElement, lastElement);
        i++;
    }
    return array;
}

// Функция вывода массива
void PrintArray(int[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        Console.Write($"{array[count]} \t");
        count++;
    }
}

// Функция поиска второго максимума в массиве
int SearchSecondMaximum(int[] array)
{
    int max1 = 0;
    int max2 = 0;
    for( int i=0; i < array.Length; i++)
        if (array[i] > max1)
        {
            max2 = max1;
            max1 = array[i];
        }
    else
    {
       if (array[i] != max1 && array[i] > max2)
       {
          max2 = array[i];
       }
    }
    return max2;
}

int value = Prompt("Введите число N, соответствующее количеству элементов в массиве -> ");
int firstElement = Prompt("Введите число, соответствующее нижней границе диапазона -> ");
int lastElement = Prompt("                              верхней границе диапазона -> ");
int[] set = FillArray(value, firstElement, lastElement);
PrintArray(set);
System.Console.WriteLine($"Второй максимум -> {SearchSecondMaximum(set)}");