// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> Четное

// Функция, на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int value;                                  // Объявление переменной

value = Prompt("Введите число -> ");        // Вводим значение числа

int AbsRemains = Math.Abs(value % 2);       // Определение модуля остатка от деления на 2

if (AbsRemains > 0)                            // Определение четности
{
    System.Console.WriteLine($"{value} -> нечетное"); // Вывод результата
}
else
{
    System.Console.WriteLine($"{value} -> четное"); // Вывод результата
}