// Напишите программу, которая генерирует несколько случайных чисел, и в цикле проверяет,
// кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет 
// 15 -> нет 
// 12 -> да


int Prompt(string message)                                      // Функция, на вход получает параметр, на выходе введенное с консоли значение
{
    System.Console.Write(message);                              // Вывести сообщение
    string readValue = Console.ReadLine();                      // Считавает с консоли строку
    int result = int.Parse(readValue);                          // Преобрадует строку в целое число
    return result;                                              // Возвращает результат
}

void FillArray(int[] collection)                               // Функция заполнения масссива случайными числами
{
    int length = collection.Length;                            // Определение длины массива
    int index = 0;                                             // Стартовая позиция
    while (index < length)                                     // Пока индекс меньше длины выполняются действия в фигурных скобках
    {
        collection[index] = new Random().Next(1, 50);          // В массив collection на позицию index положить новое случайное целое число из диапазона 1...50
        index++;                                               // Шаг итерации
    }
}

int value = Prompt("Введите число от 1 до 20 -> ");                              // Обращение к функции введения параметра с консоли
int valueLength = Prompt("Введите количество проверяемых чисел от 1 до 20 -> "); // Обращение к функции введения параметра с консоли

int[] array = new int[valueLength];                                              // Задан новый массив целых чисел длиной valueLength
FillArray(array);                                                                // Обращение к функции заполнения масива
int count = array.Length;                                                        // Определение длины массива
// int position = 0;                                                             // Стартовая позиция

for (int position = 0; position < count; position++)                             // Цикл, пока мы в массиве
{
    int result = array[position] % value;                                        // Определение остатка от деления 
    if (result != 0)                                                      // Если четность не выполняется
    {
        System.Console.WriteLine($"{array[position]} -> нет");                // Вывод результата
    }
    else
    // if (result == 0)                                                                     // Если четность выполняется
    {
        System.Console.WriteLine($"{array[position]} -> да");               // Вывод результата
        break;                                                               // Остановка программы
    }
    // position++;                                                          // Шаг итерации
}