// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деление.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int valueOne = Prompt("Введите число 1 -> ");  // Объявление переменной и введение его значения
int valueTwo = Prompt("Введите число 2 -> ");  // Объявление переменной и введение его значения
int result = valueTwo % valueOne;

if (result==0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine(result);
}
