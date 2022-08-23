// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0, 1}", array[i]); //Дополнение числа начальными нулями {0,2},10 => 0010 (для крсты)
        if (i < array.Length - 1) { Console.Write(", "); }
    }
    Console.Write("] ");
}

int[] CopyArray(int[] array)
{
    int[] answer = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        answer[i] = array[i];
    }
    return answer;
}

int[] array = { 1, 2, 3, 4, 5 };
int[] set = CopyArray(array);

// array[1] = 10;

PrintArray(array);
Console.WriteLine();
PrintArray(set);
Console.WriteLine();