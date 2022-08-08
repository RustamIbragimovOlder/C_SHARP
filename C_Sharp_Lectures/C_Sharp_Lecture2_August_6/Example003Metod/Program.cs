int[] array = { 42, 1, 42, 33, 64, 25, 6, 97, 18, 42, 29, 123 }; // Задание массива

int n = array.Length; // Переменная n равна величине (длине, количеству элементов) массива

int find = 42; // Значение элемента, которое надо найти

int index = 0; // Стартовое значения индекса элемента

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}