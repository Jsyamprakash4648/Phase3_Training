using System;

namespace OperatorOverLoading;

class Program 
{
    public static void Main(string[] args)
    {
        Box box1=new Box(1.2,3.2,4.2);
        Box box2=new Box(1.2,3.2,4.2);

        Console.WriteLine(box1.CalculationVolume());
        Console.WriteLine(box2.CalculationVolume());

        Box box3=Box.Add(box1,box2);
         Box box4=box1+box2;

        
    }
}
