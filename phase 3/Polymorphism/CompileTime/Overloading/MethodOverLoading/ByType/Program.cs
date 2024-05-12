using System;

namespace ByType;

class Program 

{
    public static void Main(string[] args)
    {
        //add method to add integer
        int result=Add(1,2);
        double result2=Add(1,3);

        string result1=Add("kkk","kkk");
    }

    public static int Add(int a,int b)
    {
        return a+b;
    }
     public static double Add(double a,double b)
    {
        return a+b;
    }


     public static string  Add(string a,string b)
    {
        return a+b;
    }
}
