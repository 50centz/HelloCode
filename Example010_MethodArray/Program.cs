int[] array = { 10, 15, 52, 53, 44, 55, 69, 78, 85, 69 };

int n = array.Length;
int find = 69;

int index = 0;

while (index < n)
{
    if (array[index] == find) 
    {
        Console.WriteLine(index);
        break;
    }
        index++;
}