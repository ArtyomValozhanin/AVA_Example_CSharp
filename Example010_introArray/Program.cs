// программа сравнения 9ти чисел (функции + массивы)
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int[] array = { 11, 28, 13, 41, 5, 65, 37, 28, 91 };
//index array = 0   1   2   3   4   5   6   7   8

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(result);
