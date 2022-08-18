// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int ExponentiationOfNumber(int value1, int value2)
{
    int result = 1;
    for (int i = 0; i < value2; i++)
    {
        result = result * value1;
    }
    return result;
}

int numberA = Prompt("Введите значение числа A -> ");
int numberB = Prompt("Введите значение числа B -> ");
if (numberB < 0)
{
    System.Console.WriteLine($"Некорректный ввод");
}
else Console.WriteLine($"{numberA}, {numberB} -> {ExponentiationOfNumber(numberA, numberB)}");