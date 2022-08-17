// Напишите программу, которая выводит массив от 1 до N
// причем [1, 2, 2, 3, 3, 3 и т.д. до N]

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void printNumbers(int value)
{
    int count = 0; // счетчик количества выведенных чисел
    int i = 0; // счетчик групп одинаковых чисел
    while (true) // цикл групп
    {
        for (int j = 0; j < i; j++) // цикл вывода чисел в группе
        {
            System.Console.Write($"{i} "); // вывод результата
            count++;
            if (count == value) // условие выхода из функции
            {
                return;
            }
        }
        i++; // переход к следующей группе
    }
}

int number = Prompt ("Введите значение числа N -> ");
printNumbers(number);