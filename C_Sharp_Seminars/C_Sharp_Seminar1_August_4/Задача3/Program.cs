// Напишите программу вычисления функции x = f(a) 

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
//или int value = Promt("Введите число > ") Сразу объявляем переменную и вводим ее значение
int result = value * value;                 // Вычисляем квадрат
System.Console.WriteLine($"Квадрат числа {value} равен {result}"); // Вывод результата
