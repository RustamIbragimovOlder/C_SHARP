// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// Функция, на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int value = Prompt("Введите число -> ");
if (value % 7 == 0 && value % 23 == 0)
{
    Console.WriteLine("Да, кратно");
}
else
{
    Console.WriteLine("Нет, не кратно");
}