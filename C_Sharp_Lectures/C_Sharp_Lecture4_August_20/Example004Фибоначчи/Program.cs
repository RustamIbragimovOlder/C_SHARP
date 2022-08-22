// Последовательность Фибоначчи
// f(0) = 0;
// f(1) = 1:
// f(2) = 1;
// f(3) = f(2) + f(1)
// ....
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
    if (n == 0)
    {
        return 0;
    }
    if (n == 1)
    {
        return 1;
    }
    else
    {
        return (Fibonacci(n - 1) + Fibonacci(n - 2));
    }
}

for (int i = 0; i < 50; i++)
{
    Console.WriteLine($"{i} -> {Fibonacci(i)};");
}
