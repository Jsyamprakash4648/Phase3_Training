using System;

namespace MetroCardManagement;

class Program
{
    public static void Main(string[] args)
    {
        FileHandling.CreateFile();
        //Adding default data in application
        //Operations.AddDefaultData();
        FileHandling.ReadCsv();
       
        Operations.MainMenu();

        
         FileHandling.WriteToCsv();

        
    }
}
