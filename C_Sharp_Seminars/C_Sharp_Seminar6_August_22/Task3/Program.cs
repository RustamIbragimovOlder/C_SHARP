// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсты)
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] ReplacingDecimalBinary(int value)
{
    int[] array = new int[20];
    int i = array.Length - 1;
    while (value > 0)
    {
        int bit = value % 2;
        value = value / 2;
        array[i] = bit;
        i--;
    }
    return array;
}

int[] set = ReplacingDecimalBinary(Prompt("Введите дестичное число -> "));
PrintArray(set);