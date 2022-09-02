// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int CalculatingAckermanFunction(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else
    {
        if (numberN == 0 && numberM > 0)
        {
            return CalculatingAckermanFunction(numberM - 1, 1);
        }
        else
        {
            return CalculatingAckermanFunction(numberM - 1, CalculatingAckermanFunction(numberM, numberN - 1));
        }
    }
}

int numberM = Prompt("Введите число M -> ");
int numberN = Prompt("Введите число N -> ");
Console.WriteLine(CalculatingAckermanFunction(numberM, numberN));