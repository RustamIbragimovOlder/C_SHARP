/* Суть сортировки
Пусть есть массив [3, 1, 5, 0, 7, 9, 8]
Работаем в парах элементов:

1 проход массива

3 > 1 меняем элементы местами
[1, 3, 5, 0, 7, 9, 8]
Продолжаем:
3 < 5 элементы не меняются
5 > 0 меняем элементы местами
[1, 3, 0, 5, 7, 9, 8]
Продолжаем:
7 < 9 элементы не меняются
9 > 8 меняем элементы местами
[1, 3, 0, 5, 7, 8, 9]

2 проход массива
Сначала:
1 < 3 элементы не меняются
3 > 0 меняем элементы местами
[1, 0, 3, 5, 7, 8, 9]
Продолжаем:
3 < 5 элементы не меняются
5 < 7 элементы не меняются
7 < 8 элементы не меняются
8 > 9 элементы не меняются

2 проход массива
Сначала:
1 > 0 меняем элементы местам
[0, 1, 3, 5, 7, 8, 9]
Продолжаем:
1 < 3 элементы не меняются
3 < 5 элементы не меняются
5 < 7 элементы не меняются
7 < 9 элементы не меняются
8 < 9 элементы не меняются

3 проход массива
0 < 1 элементы не меняются
1 < 3 элементы не меняются
3 < 5 элементы не меняются
5 < 7 элементы не меняются
7 < 9 элементы не меняются
8 < 9 элементы не меняются

4 проход массива
0 < 1 элементы не меняются
1 < 3 элементы не меняются
3 < 5 элементы не меняются
5 < 7 элементы не меняются
7 < 9 элементы не меняются
8 < 9 элементы не меняются

5 проход массива
0 < 1 элементы не меняются
1 < 3 элементы не меняются
3 < 5 элементы не меняются
5 < 7 элементы не меняются
7 < 9 элементы не меняются
8 < 9 элементы не меняются

6 проход массива
0 < 1 элементы не меняются
1 < 3 элементы не меняются
3 < 5 элементы не меняются
5 < 7 элементы не меняются
7 < 9 элементы не меняются
8 < 9 элементы не меняются

7 проход массива
0 < 1 элементы не меняются
1 < 3 элементы не меняются
3 < 5 элементы не меняются
5 < 7 элементы не меняются
7 < 9 элементы не меняются
8 < 9 элементы не меняются

Итог:
[0, 1, 3, 5, 7, 8, 9]
Stop
*/

Console.WriteLine("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите значения массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}

