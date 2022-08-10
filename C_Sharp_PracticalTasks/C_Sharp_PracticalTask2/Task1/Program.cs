// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int[] array = new int[20];                          // Задание массива
    Random rand = new Random();                // В массив [collection] на позицию [index] положить новое случайное целое число из диапазона от 1 до [maxNumber]
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = rand.Next(1, 100);
        System.Console.WriteLine(array[index]);
    }