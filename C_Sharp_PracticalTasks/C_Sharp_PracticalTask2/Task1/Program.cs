// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int value = Prompt("Введите 3-х значное число -> "); // Ввод исходных данных

int Prompt(string message)                         // Функция, на вход получает параметр, на выходе введенное с консоли значение
{
    System.Console.Write(message);                 // Вывести сообщение
    string readValue = Console.ReadLine();         // Считавает с консоли строку
    int result = int.Parse(readValue);             // Преобрадует строку в целое число
    return result;                                 // Возвращает результат
}

void DecompositionNumber(int[] array)              // Функция разложения 3-х значного числа по разрядам
{
    int number1 = value % 10;                      // Определение 1 разряда
    int number2 = value / 10 % 10;                 // Определение 2 разряда
    int number3 = value / 100 % 10;                // Определение 3 разряда
    array[0] = number3;                            // В массив array на позицию [0] положить значение 3 разряда
    array[1] = number2;                            // В массив array на позицию [1] положить значение 2 разряда
    array[2] = number1;                            // В массив array на позицию [2] положить значение 1 разряда
}

if (value > 99 && value < 1000)
{
    int[] set = new int[3];                           // Создание нового массива
    DecompositionNumber(set);                         // Обращение к функции
    System.Console.WriteLine($"{value} -> {set[1]}"); // Вывод результата
}
else
{
    System.Console.WriteLine($"Введенное число не является трехзначным"); // Вывод результата
}