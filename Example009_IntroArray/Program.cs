int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//              0  1   2   3   4   5   6   7   8   Элементы массива
int[] array = { 1, 25, 36, 48, 57, 69, 77, 89, 99 };

//Console.WriteLine(array.Length);

int result = Max(
    Max(array[0], array[1], array[2] ),
    Max(array[3], array[4], array[5] ),
    Max(array[6], array[7], array[8] )
);

Console.WriteLine(result);

//int length = array.Length;
//Console.WriteLine(length);
//int i = 0;
/*while (i < length)
{
    Console.Write(array[i] + " ");
    i++;

}*/
