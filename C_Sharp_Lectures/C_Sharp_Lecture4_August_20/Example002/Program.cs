// Методы работы с двумерными массивами

// Метод 1 Заполнение массива случайными числами

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
        }
        Console.WriteLine();
    }


}



// Метод 2 Печать массива

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t");
        }
        Console.WriteLine();
    }

}

int[,] matrix = new int[3, 5]; // задание массива
PrintArray(matrix); // вызов метода
FillArray(matrix); // вызов метода
Console.WriteLine();
PrintArray(matrix); // вызов метода