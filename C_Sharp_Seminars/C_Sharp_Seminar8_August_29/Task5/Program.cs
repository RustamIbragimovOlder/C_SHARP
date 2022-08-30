// Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника.

int Prompt(string message)
{
    Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int FindFactorial(int n)
{
    int x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}

void BuildPascalTriangle(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
        {
            Console.Write(" ");
        }
        for (int c = 0; c <= i; c++)
        {
            Console.Write(" "); // создаём пробелы между элементами треугольника
            Console.Write($"{FindFactorial(i) / (FindFactorial(c) * FindFactorial(i - c))}"); //формула вычисления элементов треугольника
        }
        Console.WriteLine();
        // Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
    }
    // Console.ReadLine();

}

int numberRows = Prompt("Введите количество строк треугольника Паскаля -> ");
BuildPascalTriangle(numberRows);
Console.WriteLine();