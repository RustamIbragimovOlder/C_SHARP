// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int FindSumNaturalElements(int numberM, int numberN)
{
    if (numberM > numberN)
    {
        return 0;
    }
    return FindSumNaturalElements(numberM + 1, numberN) + numberM;
}

int numberM = Prompt("Введите число M -> ");
int numberN = Prompt("Введите число N -> ");
if (numberM > numberN)
{
    Console.WriteLine($"Число M не должно быть больше числа N");
}
else
{
    Console.WriteLine($"M = {numberM}; N = {numberN} -> {FindSumNaturalElements(numberM, numberN)}");
}