// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Функция, на вход получает параметр, на выходе введенное с консоли значение

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int ProductOfNumbers(int number)
{
    // int answer = 0;
    // for (int i = 0; i <= number; i++)
    // {
        // answer = answer + i;
    // }
    // return answer;
}

int number = Prompt("Введите число N => ");
System.Console.WriteLine($"{number} -> {}");
