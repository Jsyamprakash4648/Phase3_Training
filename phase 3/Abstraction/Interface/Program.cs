using System;

namespace Interface;

public class Program 
{
    public static void Main(string[] args)
    {
        Square Number=new Square();//class variable as object
        Number.Number=20;
        Console.WriteLine(Number.Calculate());

        Circle number2=new Circle();
        number2.Number=10;
        Console.WriteLine(number2.Calculate());


        
    }
}
