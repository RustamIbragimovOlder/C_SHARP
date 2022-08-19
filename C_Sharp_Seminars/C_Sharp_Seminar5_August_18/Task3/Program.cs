// Задайте массив. Напишите программу,
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// Функция считывания числа с консоли
int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

// Функция создания массива
int[] CreateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

// Функция вывода массива на консоль
void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

// Функция проверки наличия элемента в массиве
bool CheckingForPresenceElement(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

int[] set = CreateArray(15, -10, 11);
PrintArray(set);
int number = Prompt("Введите значение элемента для поиска -> ");
if(CheckingForPresenceElement(set, number))
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}