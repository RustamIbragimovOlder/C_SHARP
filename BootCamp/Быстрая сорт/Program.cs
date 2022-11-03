/* Квик-сорт
y = n * log(n)
arr = [1, 0, -6, -1, 5, 3, 2]
1 шаг - инициализация массива
2 шаг - выбор опорного элемента (пивот)
как правило - первый или последний, но можно другой
сейчас - последний
pivot = arr[6]
- все элементы меньше pivot должны стоять левее pivot
- все элементы больше pivot должны стоять правее pivot
arr = [1, 0, -6, -1, 2, 5, 3]    
3 шаг - повторить шаги 1 и 2 для левого и правого подмассивов

левый подмассив [1, 0, -6, -1]
pivot = -1 -> [-6, -1, 1, 0]
левый подмассив [-6]
правый подмассив [1, 0]
pivot = 0 -> [0, 1]
правый подмассив [1]
на выходе -> [-6, -1, 0, 1]

правый подмассив [5, 3]
pivot = 3 -> [3, 5]

итог -> [-6, -1, 0, 1, 2, 3, 5]

*/

int[] arr = { 0, -5, 2, 3, 5, 9, -1, 7, -10, 15, 4, -4 };
QuickSort(arr, 0, arr.Length - 1);
Console.Write($"Отсортированный массив [{string.Join(", ", arr)}]");
Console.WriteLine();

void QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return;
}

int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(inputArray, i, pivotIndex);
        }
    }
    pivotIndex++;
    Swap(inputArray, pivotIndex, maxIndex);
    return pivotIndex;
}

void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}
