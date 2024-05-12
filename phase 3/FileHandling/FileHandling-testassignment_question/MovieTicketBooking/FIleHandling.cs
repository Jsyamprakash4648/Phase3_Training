using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;


namespace MovieTicketBooking
{
    public static class FIleHandling
    {

         public static void Create()
        {
            if(!Directory.Exists("TestFolder"))
            {
                Console.WriteLine("creating folder");
                Directory.CreateDirectory("TestFolder");
            }
            //filr for student info
            if(!File.Exists("TestFolder/NumbersInfo.csv"))
            {
                 Console.WriteLine("creating File");
                File.Create("TestFolder/MovieDetails.csv").Close();

            }

            if(!File.Exists("TestFolder/NumbersInfo.csv"))
            {
                 Console.WriteLine("creating File");
                File.Create("TestFolder/ScreeningDetails.csv").Close();

            }

            if(!File.Exists("TestFolder/NumbersInfo.csv"))
            {
                 Console.WriteLine("creating File");
                File.Create("TestFolder/TheatreDetails.csv").Close();

            }


            
            if(!File.Exists("TestFolder/NumbersInfo.csv"))
            {
                 Console.WriteLine("creating File");
                File.Create("TestFolder/BookingDetails.csv").Close();

            }

            if(!File.Exists("TestFolder/NumbersInfo.csv"))
            {
                 Console.WriteLine("creating File");
                File.Create("TestFolder/UserDetails.csv").Close();

            }
        }



                public static void WriteToCsv()
        {
            
            string [] students=new string[Program.userDetailsList.Count];
            for(int i=0;i<Program.userDetailsList.Count;i++)
            {
                students[i]=Program.userDetailsList[i].UserID+","+Program.userDetailsList[i].Name+","+Program.userDetailsList[i].Age+","+Program.userDetailsList[i].PhoneNumber+","+Program.userDetailsList[i].WalletBalance;

            }
            File.WriteAllLines("TestFolder/UserDetails.csv",students);
             

           
        }

















           
        }
        
    }
