// y = n
// чем больше входных данных - тем больше операций
// Например:
// цикл перебора массива

int FindIndexByValue(int[] array, int find)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == find) return i;
    return -1;
}