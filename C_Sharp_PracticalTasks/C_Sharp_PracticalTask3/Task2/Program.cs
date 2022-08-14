// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int a1 = Prompt("Введите значение координаты точки А по оси X -> ");
int b1 = Prompt("                                    по оси Y -> ");
int z1 = Prompt("                                    по оси Z -> ");
int a2 = Prompt("Введите значение координаты точки B по оси X -> ");
int b2 = Prompt("                                    по оси Y -> ");
int z2 = Prompt("                                    по оси Z -> ");

double length = Math.Sqrt((a1 - a2) * (a1 - a2) + (b1 - b2) * (b1 - b2) + (z1 - z2) * (z1 - z2));
Console.Write($"A ({a1},{b1},{z1}); B ({a2},{b2},{z2}) -> {length}");
Console.WriteLine();