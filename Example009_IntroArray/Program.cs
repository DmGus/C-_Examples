
int[] array = { 11, 21, 31, 4, 11, 61, 17, 11, 19 };

int n = array.Length;
int find = 11;

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