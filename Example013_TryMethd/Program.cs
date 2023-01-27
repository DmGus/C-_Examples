// ВИД МЕТОДОВ 1.
// КОТОРЫЕ НИЧЕГО НЕ ПРИНИМАЮТ И НЕ ПЕРЕДАЮТ
// Например:

void Method1()
{
    Console.WriteLine("Method 1");
    Console.WriteLine("Author is DG from GCDG");
    Console.WriteLine("Copyright 2023");
}
Method1();

// ВИД МЕТОДОВ 2.
// КОТОРЫЕ ЧТО-ТО ПРИНИМАЮТ И НИЧЕГО НЕ ПЕРЕДАЮТ
// Например:

void Method2(string msg, int count)
{
Console.WriteLine("Method 2");
for (int i = 0; i < count; i++)
{
    Console.WriteLine(msg);
}
}
Method2("Hello", 3); //Method2(msg: "Hello", count: 3); можно менять местами Method2(count: 3, msg: "Hello");

// ВИД МЕТОДОВ 3.
// КОТОРЫЕ НИЧЕГО НЕ ПРИНИМАЮТ И ЧТО-ТО ПЕРЕДАЮТ
// Например:

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine("Method 3");
Console.WriteLine(year);

// ВИД МЕТОДОВ 4.
// КОТОРЫЕ ЧТО-ТО ПРИНИМАЮТ И ЧТО-ТО ПЕРЕДАЮТ
// Например:

string Method4(int count, string text)
{
    int i=0;
    string result = String.Empty;

    while (i<count)
    {
        result = result + text;
        i++;
    }
    return result;
}

Console.WriteLine("Method 4");
string res = Method4(4, "Rep");
Console.WriteLine(res);