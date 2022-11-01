// y = n^2
// Например:
// цикл в цикле

void FillWays(int[,] map)
{
    int n = map.GetLength(0);
    int m = map.GetLength(1);
    for (int i = 0; i < n; i++) map[i, 0] = 1;
    for (int i = 0; i < m; i++) map[0, i] = 1;

        for (int i = 1; i < n; i++)
            for (int j = 1; j < m; j++)
                map[i, j] = map[i - 1, j] + map[i, j - 1];
}