// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int a1 = Prompt("Введите значение абсциссы точки А -> ");
int b1 = Prompt("Введите значение ординаты точки А -> ");
int a2 = Prompt("Введите значение абсциссы точки B -> ");
int b2 = Prompt("Введите значение ординаты точки B -> ");

double length = Math.Sqrt((a1 - a2) * (a1 - a2) + (b1 - b2) * (b1 - b2));
System.Console.Write($"A ({a1}, {b1}); B ({a2}, {b2}) -> {length}");
System.Console.WriteLine("");