// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void SelectDigits(int number)
{
    int[] array = new int[5];
    int size = array.Length;
    for (int index = 0; index < size; index++)
    {
        int x = 4 - index;
        int y = Convert.ToInt32(Math.Pow(10, x));
        int z = number / y;
        array[index] = z % 10;
        index++;
    }
    if (array[0] == array[4] & array[1] == array[3])
    {
        Console.WriteLine($"{number} -> да");
    }
    else
    {
        Console.WriteLine($"{number} -> нет");
    }
}

int value = Prompt("Введите 5-и значное число -> ");
if (value > 9999 & value < 100000)
{
    SelectDigits(value);
}
else
{
    Console.WriteLine("Введенное число не является пятизначным");
}