using System;
using StudentAdmission_Filehandling;
using StudentAdmission11;

namespace StudentAdmisson;

class Program 
{
    public static void Main(string[] args)
    {

        FileHandling.Create();
        //Default data calling 
        //Operations.AddDefaultData();
        FileHandling.ReadFromCsv();
 

        Operations.MainMenu();

        FileHandling.WriteToCsv();
    }
}