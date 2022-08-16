// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Считывает значение, введенное с консоли
int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

// Проверяет является ли введенное число пятизначням
bool ComplianceCheck(int number)
{
    if (number > 9999 & number < 100000)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Осуществляет переворот разрядов числа (01234 -> 43210)
int SelectDigits(int number)
{
    int value = 0;
    while (number > 0)
    {
        int remains = number % 10;
        number = number / 10;
        value = value * 10 + remains;
    }
    return value;
}

// Проверяет равенство двух чисел
bool CheckingEqualityOfDigits(int value1, int value2)
{
    if (value1 == value2)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int value1 = Prompt("Введите 5-и значное число -> ");
bool valid = ComplianceCheck(value1);
if (valid)
{
    {
        int value2 = SelectDigits(value1);
        bool Palindrome = CheckingEqualityOfDigits(value1, value2);
        if (Palindrome)
        {
            Console.WriteLine($"{value1} -> да");
        }
        else
        {
            Console.WriteLine($"{value1} -> нет");
        }
    }
}
else
{
    Console.WriteLine("Введенное число не является пятизначным");
}