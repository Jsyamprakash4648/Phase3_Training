using System;

namespace ListDs;

class Program 

{
    public static void Main(string[] args)
    {

        string line="___________________________________";

        CustomList<int> numberList=new CustomList<int>();
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);
        numberList.Add(50);

       

        CustomList<int> numbers=new CustomList<int>();
        numbers.Add(70);
        numbers.Add(60);

        //AddingRange
        numberList.AddRange(numbers);

        Console.WriteLine("AddingRange");

        for(int i=0;i<numberList.Count;i++)
        {
            Console.WriteLine(numberList[i]);
        }

        Console.WriteLine(line);


        //sorting
         numberList.Sort();
         Console.WriteLine("Sort");

         for(int i=0;i<numberList.Count;i++)
        {
            Console.WriteLine(numberList[i]);
        }

          Console.WriteLine(line);


        //printing
         Console.WriteLine("printing");

        
        for(int i=0;i<numberList.Count;i++)
        {
            Console.WriteLine(numberList[i]);
        }

         Console.WriteLine(line);

        //numberList Constains a number or not
        bool result=numberList.Contains(40);
         Console.WriteLine("Constains");
        Console.WriteLine(result);
         Console.WriteLine(line);


        //to know the index of a number where it loacted
        int position=numberList.IndexOf(20);
        Console.WriteLine("IndexOf");
        for(int i=0;i<numberList.Count;i++)
        {
            Console.WriteLine(numberList[i]);
        }


         Console.WriteLine(line);


        //inserting element in the list and in a spedific index
        numberList.Insert(2,30);
         Console.WriteLine("Insert");
        for(int i=0;i<numberList.Count;i++)
        {
            Console.WriteLine(numberList[i]);
        }

         Console.WriteLine(line);



        //removing a number suing a index number
        numberList.RemoveAt(2);
        Console.WriteLine("RemoveAt");

        for(int i=0;i<numberList.Count;i++)
        {
            Console.WriteLine(numberList[i]);
        }


        //romoving number from existing list
        bool temp= numberList.Remove(40);
        Console.WriteLine("Remove");

        for(int i=0;i<numberList.Count;i++)
        {
            Console.WriteLine(numberList[i]);
        }


         Console.WriteLine(line);
         

        //creating a foreach loop and manually and iterating values
        Console.WriteLine("foreach loop");
        foreach(int value in numberList)
        {
            Console.WriteLine(value);
        }
         Console.WriteLine(line);


        //reversing a list using a our own method
        numberList.Reverse();
         Console.WriteLine("Reverse");

        for(int i=0;i<numberList.Count;i++)
        {
            Console.WriteLine(numberList[i]);
        }


         Console.WriteLine(line);

        //inserting a range of numbers
        numberList.InsertRange(3,numbers);
        Console.WriteLine("InsertRange");


        for(int i=0;i<numberList.Count;i++)
        {
            Console.WriteLine(numberList[i]);
        }

         Console.WriteLine(line);

        //numberList.Sort();
        
        // for(int i=0;i<numberList.Count;i++)
        // {
        //     Console.WriteLine(numberList[i]);
        // }









       

    }
}