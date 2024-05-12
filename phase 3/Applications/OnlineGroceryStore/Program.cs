
using System;
using System.Globalization;

namespace OnlineGroceryStore;

class Program 
{
    public static void Main(string[] args)
    {
        Operations.AddDefaultData();
        Operations.MainMenu();
        
    }
}