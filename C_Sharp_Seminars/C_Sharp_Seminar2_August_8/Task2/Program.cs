// Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

// Функция, на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int number = new Random().Next(10, 100);    // Выбор случайного числа из указанного отрезка
System.Console.WriteLine(number);
int number1 = number % 10;
int number2 = number / 10;
if (number1 > number2)
{
    System.Console.WriteLine(number1);
}
else
{
    System.Console.WriteLine(number2);
}
