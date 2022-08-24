// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    double result = double.Parse(readValue);
    return result;
}

double CalculationRootSystemEquationsX(double b1, double b2, double k1, double k2)
{
    double x = (b2 - b1) / (k1 - k2); // корень системы уравнений х
    return x;
}

double CalculationRootSystemEquationsY(double b1, double b2, double k1, double k2)
{
    double y = ((b1 * k2) - (b2 * k1)) / (k2 - k1); // корень системы уравнений y
    return y;
}

double b1 = Prompt("Введите значение коэффициента b1 -> ");
double k1 = Prompt("Введите значение коэффициента k1 -> ");
double b2 = Prompt("Введите значение коэффициента b2 -> ");
double k2 = Prompt("Введите значение коэффициента k2 -> ");

if ((k1 == k2) && (b1 == b2))
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельные, пересечений нет");
    }
    else
    {
        Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ");
        Console.Write($"({CalculationRootSystemEquationsX(b1, b2, k1, k2):f2}, {CalculationRootSystemEquationsY(b1, b2, k1, k2):f2})");
        Console.WriteLine();
    }
}