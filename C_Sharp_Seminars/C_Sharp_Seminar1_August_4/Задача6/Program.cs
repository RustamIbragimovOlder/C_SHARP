// Напишите программу, которая на вход принимает значение,
// а  на выходе показывает обратное значение.
// 1 -> 1 
// 2 -> 0.5
// 0.25 -> 4

// Функция, на вход получает параметр, на выходе введенное с консоли значение

double Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    double result = double.Parse(readValue);   // Преобразует строку в дробное число
    return result;                          // Возвращает результат
}

double value = Prompt("Введите число -> ");  // Объявление переменной и введение его значения

double N = 1 / value; // Взятие обратного значения

System.Console.WriteLine($"Обратным для числа {value} является {N}");