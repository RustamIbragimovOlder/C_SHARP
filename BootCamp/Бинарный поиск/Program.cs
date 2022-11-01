// Бинарный поиск
// сложность алгоритма логарифмическая y = log(n)
// массив должен быть упорядочен!

int BinarySearch(int[] array, int find)
{
    int left = 0;
    int right = array.Length - 1;
    while (left <= right)
    {
        int middle = (left + right) / 2;
        if (find == array[middle]) return middle;
        else if (find < array[middle]) right = middle - 1;
        else left = middle + 1;
    }
    return -1;
}
