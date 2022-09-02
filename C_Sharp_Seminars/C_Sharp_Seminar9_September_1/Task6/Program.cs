// Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

bool PrimeNumber(int number, int divider)
{
    if (divider == 1)
    {
        return true;
    }
    return PrimeNumber(number, divider - 1) && (number % divider > 0);
}

int number = Prompt("Введите число N -> ");
int divider = number - 1;
bool result = PrimeNumber(number, divider);
if (result == true)
{
    Console.WriteLine($"N = {number} -> Это простое число");
}
else
{
    Console.WriteLine($"N = {number} -> Это непростое число");
}