// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Напишите программу, которая принимает на вход N-значное число и на выходе показывает нужные цифры этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int value = Prompt("Введите N-х значное число -> "); // Ввод исходных данных

int Prompt(string message)                         // Функция, на вход получает параметр, на выходе введенное с консоли значение
{
    System.Console.Write(message);                 // Вывести сообщение
    string readValue = Console.ReadLine();         // Считавает с консоли строку
    int result = int.Parse(readValue);             // Преобрадует строку в целое число
    return result;                                 // Возвращает результат
}

void DecompositionNumber(int number)              // Функция разложения N-значного числа по разрядам
{
    int number1 = value % 10;                      // Определение 1 разряда числа
    int numericDigit = 0;
    int result = value / 10;
    int[] array = new int[numericDigit];           // Объявление нового массива|
    array[0] = number1;                            // В массив array на позицию 0 положить значение 1 разряда
    while (result > 10)
    {
        result = result / 10 % 10;
        numericDigit++;
        array[numericDigit] = result;                  // В массив array на max-1 позицию положить значение очередного разряда
    }
}

DecompositionNumber(value);                   // Обращение к функции
System.Console.WriteLine(value);              // Вывод результата
// System.Console.WriteLine(array[numericDigit] ); // Вывод результата
