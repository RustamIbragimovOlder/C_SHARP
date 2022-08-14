// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

void GetCoordinates(int quaretr)
{
    if (quaretr == 1)
    {
        System.Console.WriteLine("x > 0, y > 0");
    }
    if (quaretr == 2)
    {
        System.Console.WriteLine("x < 0, y > 0");
    }
    if (quaretr == 3)
    {
        System.Console.WriteLine("x < 0, y < 0");
    }
    if (quaretr == 4)
    {
        System.Console.WriteLine("x > 0, y < 0");
    }
}

int quaretr = Prompt("Введите значение четверти -> ");
GetCoordinates(quaretr);