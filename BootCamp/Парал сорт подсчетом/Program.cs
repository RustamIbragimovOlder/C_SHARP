const int THREADS_NUMBER = 50; // число потоков
const int N = 10000000; // размер массива
object lock_object = new object(); // объявление объекта "локер"

Random rand = new Random();
// следующая строка - создание рандомного массива
int[] resSerial = new int[N].Select(r => rand.Next(0, 5)).ToArray();
int[] resParallel = new int[N];

Array.Copy(resSerial, resParallel, N); // копирование массива для второго варианта сортировки

// Console.WriteLine(string.Join(", ", resSerial));

CountingSortExtended(resSerial);
PrepareParallelCountingSort(resParallel);
Console.WriteLine(EqualityMatrix(resSerial, resParallel));

// Console.WriteLine(string.Join(", ", resSerial));
// Console.WriteLine(string.Join(", ", resParallel));

void PrepareParallelCountingSort(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] counters = new int[max + offset + 1];

    int eachThreadCalc = N / THREADS_NUMBER; // количество вычислений для каждого потока
    var threadsParall = new List<Thread>(); // создание коллекции (списка) потоков

    for (int i = 0; i < THREADS_NUMBER; i++) // запуск потоков
    {
        int startPos = i * eachThreadCalc; // определение стартовой позиции потока
        int endPos = (i + 1) * eachThreadCalc; // определение конечной позиции потока
        if (i == THREADS_NUMBER - 1) endPos = N; // условие для последнего потока (все что остается от первых потоков)
        threadsParall.Add(new Thread(() => CountingSortParallel(inputArray, counters, offset, startPos, endPos)));
        threadsParall[i].Start();
    }

    foreach(var thread in threadsParall)
    {
        thread.Join();
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }
}

// Функция синхронизации для параллельной сортировки подсчетом
void CountingSortParallel(int[] inputArray, int[] counters, int offset, int startPos, int endPos)
{
    for (int i = startPos; i < endPos; i++)
    {
        lock (lock_object) // замок на работу других потоков, если уже работает поток
        {
            counters[inputArray[i] + offset]++; // запись только для одного потока!!!
        }
    }
}

// Функция для обычной сортировки подсчетом
void CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] counters = new int[max + offset + 1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }
}

// Функция для сравнения двух массивов (результатов сортировки)
bool EqualityMatrix(int[] fmatrix, int[] smatrix)
{
    bool res = true;
    for (int i = 0; i < N; i++)
    {
        res = res && (fmatrix[i] == smatrix[i]);
    }
    return res;
}