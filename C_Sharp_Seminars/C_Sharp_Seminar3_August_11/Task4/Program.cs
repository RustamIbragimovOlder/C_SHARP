// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

void SquareMethods(int value)
{
    int index = 1;
    while(index <= value)
    {
        System.Console.Write($"{index*index} ");
        index++;
    }
}

int value = Prompt("Введите число N -> ");
if(value <=0)
{
    System.Console.WriteLine("Некорректный ввод");
}
else
{
    SquareMethods(value);
}
System.Console.WriteLine();