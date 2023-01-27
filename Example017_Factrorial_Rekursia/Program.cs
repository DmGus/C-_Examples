int Factorial(int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

// F(1) = 1
// F(2) = 1
// F(n) = F(n-1)+f(n-2)
double Fibonachi(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonachi(n - 1) + Fibonachi(n - 2);
}

// Console.WriteLine(Factorial(5));

for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i} -> {Fibonachi(i)}");
}
