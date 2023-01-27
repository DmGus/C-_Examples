// Ввести массив из 8 числел,
// и отсортировать его по убыванию
// по возрастанию.

// Var
int arraysize = 8, minarraynum = 0, maxarraynum = 9;

// Body
int[] arr = CreateArrayRndInt(arraysize, minarraynum, maxarraynum);
PrintArray(arr);
int[] arrhi=SortArrayHi(arr);
PrintArray(arrhi);
int[] arrlo=SortArrayLow(arr);
PrintArray(arrlo);

// Methods
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write(array[i] + ",");
        else System.Console.Write(array[i]);
    }
    System.Console.WriteLine("]");
}

int[] SortArrayHi(int[] arraysort)
{
    int[] newarray = new int [arraysort.Length]; 
    newarray = arraysort;    
    for (int i = 0; i < newarray.Length; i++)
    {
        int minpos=i;
        for (int j = i; j < newarray.Length; j++) if (newarray[j]<newarray[minpos]) minpos=j;
        int temp = newarray[i];
        newarray[i] = newarray[minpos];
        newarray[minpos]=temp;
    }
    return newarray;
}

int[] SortArrayLow(int[] arraysort)
{
    int[] newarray = new int [arraysort.Length]; 
    newarray = arraysort;    
    for (int i = 0; i < newarray.Length; i++)
    {
        int maxpos=i;
        for (int j = i; j < newarray.Length; j++) if (newarray[j]>newarray[maxpos]) maxpos=j;
        int temp = newarray[i];
        newarray[i] = newarray[maxpos];
        newarray[maxpos]=temp;
    }
    return newarray;
}