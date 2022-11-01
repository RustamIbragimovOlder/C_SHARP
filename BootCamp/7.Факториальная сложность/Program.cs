// y = n!
// Эффективность низкая
// Например:
// рекурсивная функция факториала

int Factor(int n)
{

    if (n == 0 || n == 1) return 1;
    else return n * Factor(n - 1);
}

int res = Factor(5);
Console.WriteLine(res);
