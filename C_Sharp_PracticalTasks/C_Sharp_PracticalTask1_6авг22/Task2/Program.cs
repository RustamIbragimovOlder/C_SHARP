﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

// Функция, на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int value1;                                  // Объявление переменной
int value2;                                  // Объявление переменной
int value3;                                  // Объявление переменной
int max;

value1 = Prompt("Введите число 1 -> ");       // Вводим значение 1-го числа
value2 = Prompt("Введите число 2 -> ");       // Вводим значение 2-го числа
value3 = Prompt("Введите число 3 -> ");       // Вводим значение 3-го числа

max = value1;                                 // назначение max

if (value2 > value1) max = value2;            // Сравнение данных
if (value3 > value2) max = value3;            // Сравнение данных
{
    System.Console.WriteLine($"max = {max}"); // Вывод результата
}