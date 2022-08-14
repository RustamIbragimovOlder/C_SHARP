// Сортировка массива методом выбора
// или
// Алгоритм сортировки методом выбора max (min)

// Суть:
// Взять первый элемент массива, определить в оставшейся части минимальный и поменять местами первый элемент с минимальным
// Взять следующий (второй) элемент массива, определить в оставшейся части минимальный и поменять их местами
// Взять следующий (третий) элемент массива, определить в оставшейся части минимальный и поменять их местами
// и т.д. пока не закончится массив

// Другими словами:
// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1, 76, 12, 0, -3, -3 }; // Объявление массива для сортировки

// Метод вывода массива на экран (консоль)
void PrintArray(int[] array) // void PrintArray - тип и имя метода
                             // int[] array - аргумент (входной массив)
{
    int count = array.Length; // назначение переменной и присвоение ей значения, равное длине массива
    for (int i = 0; i < count; i++) // Цикл проверки массива
    {
        Console.Write($"{array[i]}\t"); // Вывод массива в одну строку
                                        // \t - табуляция после элемента
    }
    Console.WriteLine(); // Вывод пустой строки
}

// Метод сортировки массива по min
void SelectionSortMin(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) //
    {
        int minPosition = i; // объявление переменной и присвоение ей значения текущего элемента
        for (int j = i + 1; j < array.Length; j++) //
        {
            if (array[j] < array[minPosition]) //
            {
                minPosition = j; //
            }
        }
        int tempPosition = array[i]; //
        array[i] = array[minPosition]; //
        array[minPosition] = tempPosition; //
    }
}

// Метод сортировки массива по max
void SelectionSortMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition])
            {
                maxPosition = j;
            }
        }
        int tempPosition = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = tempPosition;
    }
}

PrintArray(arr);
SelectionSortMin(arr);
PrintArray(arr);
SelectionSortMax(arr);
PrintArray(arr);