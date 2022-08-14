// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка (++ 1, -+ 2, -- 3, +- 4).

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    return 4;
}
int x = Prompt("Введите значение X -> ");
int y = Prompt("Введите значение Y -> ");

if (x == 0 || y == 0)
{
    System.Console.WriteLine("Нет возможности определить четверть, точка на оси");
    return;
}
int quaretr = GetQuarter(x, y);
System.Console.WriteLine(quaretr);