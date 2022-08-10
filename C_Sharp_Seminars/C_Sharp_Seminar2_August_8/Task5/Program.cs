// Напишите программу, которая выводит случайное число из отрезка
// [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

// Функция, на вход получает параметр, на выходе введенное с консоли значение
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int number = new Random().Next(10, 1000);  // 
System.Console.WriteLine(number);//
int max = 0;
while (number > 0)
{
    int a = number % 10;
    if (max > a);
    {
        max = a;
        number = number / 10;
    }
}
System.Console.WriteLine(max);         // Вывод результата