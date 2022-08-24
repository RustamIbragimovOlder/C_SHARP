// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) { Console.Write(", "); }
    }
    Console.Write("]");
    Console.WriteLine();
}

// Метод подсчета положительных элементов массива
int CountingPositiveElementsOfArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите несколько чисел через пробел, по окончании ввода нажмите <Enter> -> ");
int[] set = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); // Перевод строки чисел в массив чисел
PrintArray(set);
Console.WriteLine($"Положительных чисел -> {CountingPositiveElementsOfArray(set)}");