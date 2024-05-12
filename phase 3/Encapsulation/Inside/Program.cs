using System;
using OutSide;

namespace Inside;

class Program 
{
    public static void Main(string[] args)
    {
        First first=new First();
       Console.WriteLine(first.PrivateOut) ;
       Console.WriteLine(first.PublicNumber);
       

       Second second=new Second();
       Console.WriteLine(second.ProtectedNnumberOut);
      // Console.WriteLine(second.internalProtected);

       Console.WriteLine(second.protectedinternalOut);


        
    }
}
