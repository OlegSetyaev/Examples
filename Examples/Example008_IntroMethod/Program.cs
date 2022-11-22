// Нахождение максимума из 9 чисел.
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}


int a = 12;
int b = 23;
int c = 32;
int a1 = 42;
int b1 = 1241;
int c1 = 41;
int a2 = 322;
int b2 = 51;
int c2 = 1323;

//int max = Max(a, b, c);
//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(max, max1, max2);
int max3 = Max(Max(a, b, c), Max(a1, b1, c1), Max(a2, b2, c2));
Console.WriteLine(max3);
