using System;
using System.Windows.Markup;


namespace BinarySearch;


class Program 
{
    public static void Main(string[] args)
    {
        int [] values={12,13,21,10,8,11,9};

        Array.Sort(values);
        int position =BinarySearch(values,21);
        if(position>-1)
        {
            Console.WriteLine("Element is foun at "+position);
        }
        else
        {
            Console.WriteLine("Eelement is not present in the array");
            }
    }

    static int BinarySearch(int [] values,int searchElement)
    {
        int left=0;
        int right=values.Length-1;
        while(left<=right)
        {
            int middle=left+((right-left)/2);
            if(values[middle]==searchElement)
            {
                return middle;

            }
            else if(values[middle]<searchElement)//if the search element is greater than middle
                {
                    //Search in right half by changing value to left
                    left=middle+1;
                }
                else
                {
                    right =middle-1;
                    //If the search element is lees then middle
                    // search the half of middle

                }
        }//element not present in the array
        return -1;

    }
}