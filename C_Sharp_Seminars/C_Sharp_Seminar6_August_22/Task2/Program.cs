// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника:
// длина любой стороны треугольника всегда меньше
// суммы длин двух его других сторон

int Prompt(string message)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(message);
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

bool Triangle(int sideOne, int sideTwo, int sideThree)
{
    if (sideOne + sideTwo > sideThree // двойной && - оптимизация
    && sideTwo + sideThree > sideOne  // если первое (второе ...) условие не выполняется
    && sideThree + sideOne > sideTwo) // дальше проверка не проводится
    {
        return true;
    }
    else
    {
        return false;
    }
}

if (Triangle(Prompt("1 сторона -> "),
             Prompt("2 сторона -> "),
             Prompt("3 сторона -> ")))
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}