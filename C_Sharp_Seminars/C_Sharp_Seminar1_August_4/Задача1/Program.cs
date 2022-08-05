// Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

// Функция, на вход получает параметр, на выходе введенное с консоли значение

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int valueOne = Prompt("Введите число 1 > ");  // Объявление первой переменной и введение его значения
int valueTwo = Prompt("Введите число 2 > ");  // Объявление второй переменной и введение его значения

int result = valueTwo * valueTwo;            // Вычисляем квадрат первой переменной

if (result == valueOne)
{
    System.Console.WriteLine($"Квадрат числа {valueTwo}, да, равен {valueOne}"); // Вывод результата
}
else
{
    System.Console.WriteLine($"Квадрат числа {valueTwo}, нет, не равен {valueOne}"); // Вывод результата
}