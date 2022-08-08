void FillArray(int[] collection)
// где
// void - тип метода, который ничего не возвращает
// FillArray - наименование метода (метод ЗаполнитьМассив)
// int[] - тип данных в массиве
// collection - имя массива

{
    int length = collection.Length; // Определение длины массива
    int index = 0; // Стартовая позиция
    while (index < length) // Пока ... выполняются действия в фигурных скобках
    {
        collection[index] = new Random().Next(1, 12);
        // В массив collection на позицию index
        // положить новое случайное целое число из диапазона 1...12
        index++; // Шаг итерации
    }
}
void PrintArray(int[] cool)
// где
// void - тип метода, который ничего не возвращает
// PrintArray - наименование метода (метод ПечатьМассива)
// int[] - тип данных в массиве
// cool - имя массива
{
    int count = cool.Length; // Количество элементов в массиве
    int position = 0; // Стартовая позиция
    while (position < count) // Пока ... выполняются действия в фигурных скобках
    {
        Console.WriteLine(cool[position]); //Вывести результат (значение элементов масиива)
        position++; // Шаг итерации
    }
}

int IndexOf(int[] collection, int find) // Метод, который возвращает результат
// IndexOf - имя
// int[] collection, int find - аргументы метода (массив и число)
{
    int count = collection.Length; // Определяем количество элементов
    int index = 0; // Стартовая позиция
    int position = -1; // Новая переменная (-1 означает: элемент не найден)

    while (index < count) // Цикл, пока мы в массиве - сравнивать элементы массива с аргументом
    {
        if (collection[index] == find) // Если элемент массива равен аргументу
        {
            position = index; // Записать в переменную position индекс этого элемента
            break; // Останов после первого совпадения
        }
        index++; // Шаг итерации
    }
    return position; // возврат позиции элемента, который совпал с find
}

int[] array = new int[12]; // Задан новый массив целых чисел из 12 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine(); // Вывод пустой строки, чтобы отделить масиив от результата поиска

int pos = IndexOf(array, 15);
// pos - новая переменная, которая является результатом работы метода IndexOf
// array - исследуемый массив
// 5 - значение элемента, индекс которого надо найти

System.Console.WriteLine(pos); // Вывод результата
