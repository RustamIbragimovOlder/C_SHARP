// Заполнить массив случайными числами

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int[] arrayFill (int size, int number)                   // Функция заполнения массива случаными числами
{
    int index = 0;
    int[] array = new int[size];
    while(index < size)
    {
        array[index] = new Random().Next(0, number);
        index++;
    }
    return array;
}

void printArray(int[] array)                            // Функция вывода массива
{
    for(int index = 0; index < array.Length; index++)
    {
        System.Console.Write($"{array [index]}\t");      // \t табулятор
    }
}

int MaxNumber(int[] array)                               // Функция нахождения максимального числа в массиве
{
    int max = array[0];
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > max) {max = array[index];}
    }
    return max;
}

int MinNumber(int[] array)                             // Функция нахождения минимального числа в массиве
{
    int min = array[0];
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] < min)
        {
            min = array[index];
        }
    }
    return min;
}

double MidleMath(int[] array)                   // Функция нахождения среднеарифметического всех элементов массива
{
    double sumArray = 0;
    for (int index = 0; index < array.Length; index++)
    {
        sumArray += array[index];                // заменяет sumArray = sumArray + array[index]
    }
    double result = ((double) sumArray) / array.Length;
    return result;
}

int number = Prompt("Введите верхнюю границу массива -> ");
int value = Prompt("Введите количество чисел в массиве -> ");
if(value <=0)
{
    System.Console.WriteLine("Некорректный ввод");
}
else
{
    int[] set = arrayFill(value, number);      // Обращение к функции
    printArray(set);                           // Обращение к функции
    System.Console.WriteLine();                // Ввод пустой строки для удобства
    System.Console.WriteLine($"max = {MaxNumber(set)}");
    System.Console.WriteLine($"min = {MinNumber(set)}");
    System.Console.WriteLine($"mid = {MidleMath(set)}");
    System.Console.WriteLine();                // Ввод пустой строки для удобства
}
