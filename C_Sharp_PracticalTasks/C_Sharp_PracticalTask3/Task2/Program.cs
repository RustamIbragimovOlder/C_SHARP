// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Считывает значение, введенное с консоли
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int x1 = Prompt("Введите значение координаты точки А по оси X -> ");
int y1 = Prompt("                                    по оси Y -> ");
int z1 = Prompt("                                    по оси Z -> ");
int x2 = Prompt("Введите значение координаты точки B по оси X -> ");
int y2 = Prompt("                                    по оси Y -> ");
int z2 = Prompt("                                    по оси Z -> ");

double VectorLength()
{
    double length = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
    return length;
}

double length = VectorLength();
Console.Write($"A ({x1},{y1},{z1}); B ({x2},{y2},{z2}) -> {length}");
Console.WriteLine();