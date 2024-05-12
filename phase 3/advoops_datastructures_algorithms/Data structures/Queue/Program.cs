using System;

namespace Queue;


class Program 
{
    public static void Main(string[] args)
    {
        CustomQueue<int> myQueue=new CustomQueue<int>();

        myQueue.Enqueue(11);
        myQueue.Enqueue(12);
        myQueue.Enqueue(13);
        myQueue.Enqueue(14);
        myQueue.Enqueue(15);

        foreach(int value in myQueue)
        {
            Console.WriteLine("Value: "+value);
        }

        myQueue.Peek();


        Console.WriteLine(myQueue.Dequeue());
  }
    
    }
    
    
    
