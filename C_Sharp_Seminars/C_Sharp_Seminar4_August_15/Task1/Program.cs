// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Функция, на вход получает параметр, на выходе введенное с консоли значение

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int SumSequence(int number)
{
    int answer = 0;
    for (int i = 0; i <= number; i++)
    {
        answer = answer + i;
    }
    return answer;
}

int SumGauss(int number)
{
    int answer = (int)((number + 1) * (number / 2.0));
    return answer;
}

int number = Prompt("Введите число А => ");
Console.WriteLine($"{number} -> {SumSequence(number)}");
System.Console.WriteLine($"По Гауссу {number} -> {SumGauss(number)}");
