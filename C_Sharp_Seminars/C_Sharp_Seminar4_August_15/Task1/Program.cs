// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Функция, на вход получает параметр, на выходе введенное с консоли значение

int Prompt(string message)
{
    System.Console.Write(message);
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

int number = Prompt("Введите число А => ");
System.Console.WriteLine($"{number} -> {SumSequence(number)}");
