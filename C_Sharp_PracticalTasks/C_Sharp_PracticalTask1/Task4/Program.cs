// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4


// Функция, на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int value = Prompt("Введите число N -> ");   // Вводим значение числа

int array = 1;                               // Вводим стартовое значение
while (array < value)                        // Условие окончания цикла
{
    int Remains = array % 2;                 // Определение остатка от деления на 2
    if (Remains == 0)                        // Определение четности
    {
        System.Console.WriteLine($"{array}"); // Вывод результата
    }
    array++;                                 // Счетчик чисел
}
