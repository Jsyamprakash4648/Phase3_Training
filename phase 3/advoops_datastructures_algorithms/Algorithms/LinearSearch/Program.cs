using System;

namespace LinearSearch;

class Program 
{
    public static void Main(string[] args)
    {
      int [] values={12,21,14,16,19,10,15};
      int position = LinearSearch(values,19);
      Console.WriteLine(position);


    }
    static int LinearSearch(int[] values,int searchElement)
    {
        int position =-1;
        for(int i=0;i<values.Length;i++)
        {
            if(values[i]==searchElement)
            {
                position=i;
                break;
            }
        }
        return position;
    }

}
