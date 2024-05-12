using System;

namespace ByArgument;

class Program 
{
    public static void Main(string[] args)
    {

        Add(2,3);

        Add(4,5,6);
        
    }
    public static void Add(int a,int b,int c)
    {
        Console.WriteLine(a+b+c);
    }

    public static void Add(int a,int b)
    {
        Console.WriteLine(a+b);
    }
}
