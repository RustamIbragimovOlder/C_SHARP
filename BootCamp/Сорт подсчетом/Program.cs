// // простая сортировка подсчетом работает только с цифрами (от 0 до 9)

// int[] array = {0, 2, 3, 2, 1, 5, 9, 1, 6, 0, 7, 5, 2, 1, 8, 9, 2, 3, 6};
// Console.WriteLine(string.Join(", ", array));
// int[] sortedArray = CountingSort(array);
// Console.WriteLine(string.Join(", ", sortedArray));

// int[] CountingSort(int[] inputArray)
// {
//     int[] counters = new int[10]; //массив повторений
//     // int ourNumber;
//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         // ourNumber = inputArray[i];
//         // counters[ourNumber]++;
//         counters[inputArray[i]]++;
//     }
//     Console.WriteLine(string.Join(", ", counters));
//     int index = 0;
//     for (int i = 0; i < counters.Length; i++)
//     {
//         for (int j = 0; j < counters[i]; j++)
//         {
//             inputArray[index] = i;
//             index++;
//         }
//     }
//     return inputArray;
// }

// Работа усложненной сортировки подсчетом с числами

int[] array = {-10, 12, 35, -5, -9, 0, 2, 5, 1, 3, 1, -26, 0, 1};
Console.WriteLine(string.Join(", ", array));
int[] sortedArray = CountingSortExtended(array);
Console.WriteLine(string.Join(", ", sortedArray));

int[] CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] sortedArray = new int[inputArray.Length];
    int[] counters = new int[max + offset + 1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }
    Console.WriteLine(string.Join(", ", counters));

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            sortedArray[index] = i - offset;
            index++;
        }
    }
    return sortedArray;
}
