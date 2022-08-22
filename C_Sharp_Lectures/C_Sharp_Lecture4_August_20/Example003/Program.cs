// Факториал

double Factorial (int n) // double для того чтобы не было переполнения
{
    if (n == 1) // 1! = 1; 0! = 1
    {
        return 1;
    }
    else
    {
        return (n * Factorial (n - 1));
    }
}
// Console.WriteLine(Factorial(20));

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! -> {Factorial(i)}");
}