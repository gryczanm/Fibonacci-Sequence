// See https://aka.ms/new-console-template for more information

FibonacciSequenceIteration(20);

static void FibonacciSequenceIteration(int n)
{
    int a = 0, b = 1;

    for (int i = 0; i < n; i++)
    {
        b = b + a;
        a = b - a;
        
        Console.Write(a + " ");
    }
}

Console.WriteLine("\n\n");

static int GetFibonacciSequenceRecursion(int i)
{
    if (i <= 2)
    {
        return 1;
    }
    
    return GetFibonacciSequenceRecursion(i - 2) + GetFibonacciSequenceRecursion(i - 1);
}

Console.WriteLine(GetFibonacciSequenceRecursion(5));