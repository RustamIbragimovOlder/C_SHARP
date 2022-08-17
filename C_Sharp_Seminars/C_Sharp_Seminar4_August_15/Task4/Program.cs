// Напишите программу, которая выводит массив из N элементов, заполненный нулями и единицами в случайном порядке.
// 8 -> [1,0,1,1,0,1,0,0]

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

// Функция генерации массива
int[] FillArray(int Length)
{
    int[] array = new int[Length];
    int i = 0;
    while (i < array.Length)
    {
        array[i] = new Random().Next(0, 2);
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
        System.Console.Write($" {array[count]}");
        count++;
    }
    System.Console.WriteLine();
}

int value = Prompt("Введите число N -> ");
int[] set = FillArray(value);
System.Console.Write($"{value} ->"); 
PrintArray(set);