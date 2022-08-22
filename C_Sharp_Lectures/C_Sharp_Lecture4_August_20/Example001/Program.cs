// Двумерные массивы

// string[,] table = new string[3, 5]; // задание массива

// по умолчанию для строк инициализация осуществляется константой String.Empty (т.е. ПУСТО) 
// Вид массива
// table[0, 0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1, 0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]
// table[2, 0] table[2, 1] table[2, 2] table[2, 3] table[2, 4]

// table[1, 2] = "слово"; // присвоение элементу значения
//for (int rows = 0; rows < 3; rows++)
//{
//for (int colums = 0; colums < 5; colums++)
//{
//Console.WriteLine($"-{table[rows, colums]}-");
//}
//}

int[,] matrix = new int[3, 5]; // задание массива

matrix[1, 2] = 8;

for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) количество строк
{
    for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) количество столбцов
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}
