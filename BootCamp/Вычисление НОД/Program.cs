Console.Clear();
#region y = 1

void What()
{
  const int size = 10;
  int[] array = new int[size];

  int position = 0;
  array[position] = 2022;
}

#endregion

#region y = log(n)
int BinarySearch(int[] array, int find)
{
  int left = 0;
  int right = array.Length - 1;
  while (left <= right)
  {
    int middle = (left + right) / 2;
    if (find == array[middle]) return middle;
    else if (find < array[middle]) right = middle - 1;
    else left = middle + 1;
  }
  return -1;
}
#endregion

#region y = n

int FindIndexInArray(int[] array, int find)
{
  for (int i = 0; i < array.Length; i++)
    if (array[i] == find) return i;
  return -1;
}
#endregion

#region y = n²

void FillWays(int[,] map)
{
  int n = map.GetLength(0);
  int m = map.GetLength(1);
  for (int i = 0; i < n; i++) map[i, 0] = 1;
  for (int i = 0; i < m; i++) map[0, i] = 1;

  for (int i = 1; i < n; i++)
    for (int j = 1; j < m; j++)
      map[i, j] = map[i - 1, j] + map[i, j - 1];

  // for (int i = 0; i < n; i++)
  // {
  //   for (int j = 0; j < m; j++)
  //     System.Console.Write($"{map[i, j],5}");
  //   System.Console.WriteLine();
  // }
}

// FillWays(new int[8, 8]);
#endregion



#region Умножение аⁿ

long Pow(int a, int n)
{
  long result = 1;
  while (n != 0)
  {
    result = result * a;
    n--;
  }
  return result;
}

long QuickPow(int a, int n)
{
  long result = 1;
  while (n != 0)
  {
    if (n % 2 != 0)
    {
      n--;
      result *= a;
    }
    else
    {
      a *= a;
      n /= 2;
    }
  }
  return result;
}

// Console.WriteLine(Pow(2, 10));
// Console.WriteLine(QuickPow(2, 10));

#endregion

#region НОД(x, y)

///greatest common divisor

int GcdForUp(int x, int y)
{
  int count = 0;

  int gcd = 1;
  int min = x < y ? x : y;

  for (int i = 2; i <= min; i++)
  {
    count++;
    if (x % i == 0 && y % i == 0) gcd = i;
  }
  Console.WriteLine($"GcdForUp, count: {count}");

  return gcd;
}
int GcdForDown(int x, int y)
{
  int count = 0;

  int gcd = 1;
  int min = x < y ? x : y;
  for (int i = min; i >= 2; i--)
  {
    count++;
    if (x % i == 0 && y % i == 0) { gcd = i; break; }
  }
  Console.WriteLine($"GcdForDown, count: {count}");
  return gcd;
}

// int from = 14, to = 21;
// Console.WriteLine(GcdForUp(from, to));
// Console.WriteLine(GcdForDown(from, to));

int EuclideanAlgorithm(int x, int y)
{
  int count = 0;

  while (x != y)
  {
    count++;

    if (x > y)
      x = x - y;
    else
      y = y - x;
  }
  Console.WriteLine($"EuclideanAlgorithm, count: {count}");

  return x;
}

// int from = 10, to = 1000;
// Console.WriteLine(GcdForUp(from, to));
// Console.WriteLine(GcdForDown(from, to));
// Console.WriteLine(EuclideanAlgorithm(from, to));

int QuickEuclideanAlgorithm(int x, int y)
{
  int count = 0;

  int t;

  while (y != 0)
  {
    count++;

    t = x % y;
    x = y;
    y = t;
  }
  Console.WriteLine($"QuickEuclideanAlgorithm, count: {count}");

  return x;
}

// int from = 1, to = 1;
// Console.WriteLine(GcdForUp(from, to));
// Console.WriteLine(GcdForDown(from, to));
// Console.WriteLine(EuclideanAlgorithm(from, to));
// Console.WriteLine(QuickEuclideanAlgorithm(from, to));

#endregion