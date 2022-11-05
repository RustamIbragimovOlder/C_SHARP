const int N = 1000; // размер матрицы
const int THREADS_NUMBER = 10; // количество потоков

int[,] serialMulRes = new int[N, N]; //результат выполнения умножения матриц в однопотоке
int[,] threadMulRes = new int[N, N]; //результат параллельного умножения матриц

int[,] firstMatrix = MatrixGenerator(N, N);
int[,] secondMatrix = MatrixGenerator(N, N);

SerialMatrixMul(firstMatrix, secondMatrix);
PrepareParallelMatrixMul(firstMatrix, secondMatrix);
Console.WriteLine(EqualityMatrix(serialMulRes, threadMulRes));

// Функция рандомного заполнения матрицы
int[,] MatrixGenerator(int rows, int columns)
{
    Random _rand = new Random();
    int[,] res = new int[rows, columns];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = _rand.Next(-100, 100);
        }
    }
    return res;
}

// Функция последовательного умножения матриц
void SerialMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                serialMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

// Функция подготовки для параллельного умножения матриц
// Разделение процессов между потоками
void PrepareParallelMatrixMul(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Нельзя умножить такие матрицы");
    int eachThreadCalc = N / THREADS_NUMBER; // eachThreadCalc - переменная - сколько вычислений приходится на каждый поток
    Thread[] arr = new Thread[2];
    var threadsList = new List<Thread>(); // коллекция для хранения потоков
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPos = i * eachThreadCalc; // начало диапазона потока
        int endPos = (i + 1) * eachThreadCalc; // конец диапазона потока
        if (i == THREADS_NUMBER - 1) endPos = N; // если последний поток
        threadsList.Add(new Thread(() => ParallelMatrixMul(a, b, startPos, endPos))); // создание потока и запись его в коллекцию
        threadsList[i].Start(); // запуск потоков, не все сразу, а по мере готовности очередного потока
    }
    for (int i = 0; i < THREADS_NUMBER; i++) // цикл проверки завершения работы всех потоков
    {
        threadsList[i].Join();
    }
}

// Функция параллельного умножения матриц
void ParallelMatrixMul(int[,] a, int[,] b, int startPos, int endPos)
{
    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                threadMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

// Метод сравнения двух матриц
bool EqualityMatrix(int[,] fmatrix, int[,] smatrix)
{
    bool res = true;
    for (int i = 0; i < fmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fmatrix.GetLength(1); j++)
        {
            res = res && (fmatrix[i, j] == smatrix[i, j]);
        }
    }
    return res;
}
