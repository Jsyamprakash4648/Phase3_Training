using System;

namespace AbstractClassesAndMethods;

class Program 

{
    public static void Main(string[] args)
    {
        Syncfusion job1=new Syncfusion();
        job1.Name="Naruto";
        Console.WriteLine(job1.Dispaly());

        Console.WriteLine(job1.salary(30));



        Employee job2=new Zoho();
        job2.Name="Sasuke";
        Console.WriteLine(job2.Dispaly());

        Console.WriteLine(job2.salary(30));
    }
}
