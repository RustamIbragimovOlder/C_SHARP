// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void ReturnDegre(int value)
{
    int degree = 0;
    for (int index = 1; index <= value; index++)
    {
        degree = Convert.ToInt32(Math.Pow(index, 3));
        Console.Write($"{degree}  ");
    }
}


int value = Prompt("Введите число N -> ");
if (value <= 0)
{
    System.Console.WriteLine("Некорректный ввод");
}
else
{
    Console.Write($"{value} -> ");
    ReturnDegre(value);
}
// Console.WriteLine();