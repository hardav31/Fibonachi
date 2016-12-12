using System;
static class StaticClass
{
    public static void Method(int fib)
    {

        bool bo = true;
        int x1 = 0;
        int x2 = 1;
        int x3 = 1;

        if (fib < 0) { return; }
        if (fib == 0) { Console.WriteLine(x1); }
        if (fib == 1) { Console.WriteLine(x2); }
        int i = 2;
        while (bo)
        {
            x3 = x1 + x2;
            if (i == fib)
            {
                bo = false;
            }
            i++;
            x1 = x2;
            x2 = x3;
        }
        Console.WriteLine(x3);
    }
}
class davo 
{
    static void Main() 
    {
        StaticClass.Method(8);
    }
}