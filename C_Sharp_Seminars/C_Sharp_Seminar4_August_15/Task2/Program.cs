// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Функция, на вход получает параметр, на выходе введенное с консоли значение

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int value = Prompt("Введите число А => ");
int count = 0;
int number = value;
while (number > 0)
{
    number = number / 10;
    count++;
}

System.Console.WriteLine($"{value} -> {count}");