// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int value = Prompt("Введите 5-и значное число -> ");

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void ArrayFill(int array)
{
    int[] set = new int[5];
    int length = set.Length;
    int footing = 10;
    for (int index = 0; index < length; index++)
    {
        int degree = Convert.ToInt32(Math.Pow(footing, index));
        int result = value / degree;
        set[index] = result % 10;
    }
}

if (value > 9999 && value < 100000)
{
    int[] array = new int[5];
    ArrayFill(array);
    if (array[0] == array[4] && array[3] == array[1])
    {
        System.Console.WriteLine($"{value} -> да");
    }
    else
    {
        System.Console.WriteLine($"{value} -> нет");
    }
}
else
{
    System.Console.WriteLine($"Введенное число не является пятизначным");
}