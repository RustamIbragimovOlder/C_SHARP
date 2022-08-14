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

void Power3Method(int value)
{
    int index = 1;
    while (index <= value)
    {
        System.Console.Write($"{Math.Pow(index, 3)} \t");
        index++;
    }
}

int value = Prompt("Введите число N -> ");
if (value <= 0)
{
    System.Console.WriteLine("Некорректный ввод");
}
else
{
    Power3Method(value);
}
System.Console.WriteLine(); // Для удобства восприятия результата