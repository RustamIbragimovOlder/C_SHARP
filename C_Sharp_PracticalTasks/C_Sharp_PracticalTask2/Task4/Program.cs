// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

int Prompt(string message)                         // Функция, на вход получает параметр, на выходе введенное с консоли значение
{
    System.Console.Write(message);                 // Вывести сообщение
    string readValue = Console.ReadLine();         // Считавает с консоли строку
    int result = int.Parse(readValue);             // Преобрадует строку в целое число
    return result;                                 // Возвращает результат
}

int value = Prompt("Введите число, соответствующее дню недели -> "); // Ввод исходных данных

    if (value < 1 || value > 7)
        System.Console.WriteLine("Такого дня недели не существует");
else
{
    if (value < 6)
    {
        System.Console.WriteLine($"{value} -> нет"); // Вывод результата
    }
    else
    {
        System.Console.WriteLine($"{value} -> да");
    }
}