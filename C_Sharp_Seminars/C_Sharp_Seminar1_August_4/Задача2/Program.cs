// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

// Функция, на вход получает параметр, на выходе введенное с консоли значение

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int valueOne = Prompt("Введите число, соответствующее дню недели > ");  // Объявление переменной и введение его значения

if (valueOne == 1)
{
    System.Console.WriteLine($"{valueOne} день недели -> ПОНЕДЕЛЬНИК"); // Вывод результата
}
else if (valueOne == 2)
{
    System.Console.WriteLine($"{valueOne} день недели -> ВТОРНИК"); // Вывод результата
}
else if (valueOne == 3)
{
    System.Console.WriteLine($"{valueOne} день недели -> СРЕДА"); // Вывод результата
}
else if (valueOne == 4)
{
    System.Console.WriteLine($"{valueOne} день недели -> ЧЕТВЕРГ"); // Вывод результата
}
else if (valueOne == 5)
{
    System.Console.WriteLine($"{valueOne} день недели -> ПЯТНИЦА"); // Вывод результата
}
else if (valueOne == 6)
{
    System.Console.WriteLine($"{valueOne} день недели -> СУББОТА"); // Вывод результата
}
else if (valueOne == 7)
{
    System.Console.WriteLine($"{valueOne} день недели -> ВОСКРЕСЕНЬЕ"); // Вывод результата
}
else
{
    System.Console.WriteLine("Такого дня недели не существует");
}