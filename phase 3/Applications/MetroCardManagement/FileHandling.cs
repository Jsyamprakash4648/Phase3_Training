using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using MetroCardManagement;



namespace MetroCardManagement
{
    public static class FileHandling
    {
        public static void CreateFile()
        {
            if (!Directory.Exists("TestFolder"))
            {
                Console.WriteLine("creating folder...");
                Directory.CreateDirectory("TestFolder");
            }
            else
            {
                Console.WriteLine("Directory exist..");
            }
            //testfloder


            if (!File.Exists("TestFolder/userInfo.csv"))
            {
                Console.WriteLine("creating File");
                File.Create("TestFolder/userInfo.csv").Close();

            }
            else
            {
                Console.WriteLine("Directory exist..");
            }
            //userinfofile



            if (!File.Exists("TestFolder/travelInfo.csv"))
            {
                Console.WriteLine("creating File");
                File.Create("TestFolder/travelInfo.csv").Close();

            }
            else
            {
                Console.WriteLine("Directory exist..");
            }//travel info file




           if (!File.Exists("TestFolder/ticketInfo.csv"))
            {
                Console.WriteLine("creating File");
                File.Create("TestFolder/ticketInfo.csv").Close();

            }
            else
            {
                Console.WriteLine("Directory exist..");
            }






        }


         public static void WriteToCsv()
        {
            string [] users=new string[Operations.userDetailsList.Count];
            for (int i=0;i<Operations.userDetailsList.Count;i++)
            {
                users[i]=Operations.userDetailsList[i].CardNumber+","+Operations.userDetailsList[i].UserName+","+Operations.userDetailsList[i].PhoneNumber+","+Operations.userDetailsList[i].Balance;
            }
            File.WriteAllLines("TestFolder/userInfo.csv",users);





            string [] travels=new string[Operations.travelDetailsList.Count];
            for (int i=0;i<Operations.travelDetailsList.Count;i++)
            {
                travels[i]=Operations.travelDetailsList[i].TravelId+","+Operations.travelDetailsList[i].CardNumber+","+Operations.travelDetailsList[i].FromLocation+","+Operations.travelDetailsList[i].ToLocation+","+Operations.travelDetailsList[i].Date.ToString("dd/MM/yyyy")+","+Operations.travelDetailsList[i].TravelCost;
            }
            File.WriteAllLines("TestFolder/travelInfo.csv",travels);
            //adding values to the csv file;



            string[] tickets=new  string[Operations.ticketFairDetailsList.Count];
            for(int i=0;i<Operations.ticketFairDetailsList.Count;i++)
            {
                tickets[i]=Operations.ticketFairDetailsList[i].TicketID+","+Operations.ticketFairDetailsList[i].FromLocation+","+Operations.ticketFairDetailsList[i].ToLocation+","+Operations.ticketFairDetailsList[i].TicketPrice;

            }
            File.WriteAllLines("TestFolder/ticketInfo.csv",tickets);
    }


    public  static void ReadCsv()
    {
        
            string [] users=File.ReadAllLines("TestFolder/userInfo.csv");
            foreach(string user in users)
            {
               string[] array=user.Split(",");
               UserDetails user1=new UserDetails(array[0],array[1],array[2],double.Parse(array[3]));
                Operations.userDetailsList.Add(user1);


            }



            string [] ticket=File.ReadAllLines("TestFolder/ticketInfo.csv");
            foreach(string tickets in ticket)
            {
                string[] array=tickets.Split(",");
                TicketFairDetails tick=new TicketFairDetails(array[0],array[1],array[2],int.Parse(array[3]));
                Operations.ticketFairDetailsList.Add(tick);
            }


            string [] travell=File.ReadAllLines("TestFolder/travelInfo.csv");
            foreach(string trav in travell)
            {
                string [] array=trav.Split(",");
                TravelDetails travel1=new TravelDetails(array[0],array[1],array[2],array[3],DateTime.ParseExact(array[4],"dd/MM/yyyy)",null),double.Parse(array[5]));
                Operations.travelDetailsList.Add(travel1);
            }

    }


    }
}




