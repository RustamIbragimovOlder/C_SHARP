int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}


int a1 = 26; // Исходные данные
int b1 = 87;
int c1 = 34;
int a2 = 44888;
int b2 = 12555;
int c2 = 98;
int a3 = 253;
int b3 = 73;
int c3 = 21;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

System.Console.WriteLine(max);