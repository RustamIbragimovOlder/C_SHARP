// Напишите программу, которая на вход принимает число и выдаёт его модуль.

// Функция, на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int value;                                  // Объявление переменной
value = Prompt("Введите число > ");          // Вводим значение
if (value > 0)                 // Проверка условия
{
    System.Console.WriteLine($"Модуль числа {value} равен {value}");  // Вывод результата
}

else
{
    System.Console.WriteLine($"Модуль числа {value} равен {-value}");  
}