// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

bool IsBinary(int number)
{
    if (number == 1)
    {
        return (true);
    }
    return IsBinary(number / 2) && (number % 2 == 0);
}

int number = Prompt("Введите число N -> ");
bool result = IsBinary(number);
if (result == true)
{
    Console.WriteLine($"N = {number} -> является степенью двойки");
}
else
{
    Console.WriteLine($"N = {number} -> не является степенью двойки");
}