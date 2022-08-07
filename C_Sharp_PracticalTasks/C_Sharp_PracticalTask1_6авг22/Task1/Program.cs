// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5

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
value1 = Prompt("Введите число 1 > ");       // Вводим значение 1-го числа
value2 = Prompt("Введите число 2 > ");       // Вводим значение 2-го числа

if(value1 > value2)
{
    System.Console.WriteLine($"max = {value1}, min = {value2}");          // Вывод результата
}
else
{
    System.Console.WriteLine($"max = {value2}, min = {value1}");          // Вывод результата
}
