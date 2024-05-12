using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public static  class Operations
    {
        public static CustomizedList<UserDetails> userDetailsList=new CustomizedList<UserDetails>();
        public static CustomizedList<TicketFairDetails> ticketFairDetailsList=new CustomizedList<TicketFairDetails>();
        public static CustomizedList<TravelDetails> travelDetailsList=new CustomizedList<TravelDetails>();
        public static UserDetails currentLoggedUser;


        //main menu
        public static void MainMenu()
        {
            Console.WriteLine("***************Welcome to metro******************");


            string option="yes";

            do
            {    Console.WriteLine("_______________MAIN MENU_____________________");
                 Console.WriteLine(" \n1.New User Registration   \n2.Login User \n3.Exit");
                 Console.WriteLine("Choose your Option");
                 int MainChoice=int.Parse(Console.ReadLine());
                 switch(MainChoice)
                 {
                    case 1:
                    {
                        NewUserRegistration();
                        break;
                    }
                    case 2:
                    { 
                        LoginUser();
                        break;

                    }
                    case 3:
                    {

                        option="no";
                        break;

                    }

                    default :
                    {
                        Console.WriteLine("invalid input.........");

                        break;
                    }
                 }
                 
                

            }while(option=="yes");//main menu do while loop endinh here


           }//main menu ending here 


           public static void  NewUserRegistration()
           {

            Console.WriteLine("______________Welcome To user Registration_______________");

            Console.Write("Enter your UserName:  ");
            string userName=Console.ReadLine();

            Console.Write("Enter Your Phone NUmber: ");
            string phonenumber=Console.ReadLine();

            Console.Write("Enter Balance:  ");
            double balance=double.Parse(Console.ReadLine());

            UserDetails  user=new UserDetails(userName,phonenumber,balance);

            userDetailsList.Add(user);

            Console.WriteLine("your Registration is Succesfull.your card number is "+user.CardNumber);

            }//userregistration ending here.


            //validating user login credatials
           public static void LoginUser()
           {

            Console.WriteLine("______________Welcome To User Login _______________");

            Console.WriteLine("Enter your CardNUmber: ");
            string userCardNum=Console.ReadLine();

                bool flag=true;

                foreach(UserDetails user in userDetailsList)
                {
                    if(user.CardNumber.ToLower()==userCardNum.ToLower())
                    {
                        currentLoggedUser=user;

                        flag=false;
                        Submenu();
                        
                       

                    }
                }
                if(flag)
                {
                    Console.WriteLine("invalid Cardnumber: ");


                }





           }//ending of login 




        //if login succefull then this submenu will show
         public static void  Submenu()
         {


            string option ="yes";
            do
            {
                Console.WriteLine("_______________SUB MENU_____________________");
                Console.WriteLine("1.Balance Check  \n2.Recharge  \n3.View Travel History	\n4.Travel  \n5.Exit ");

                        int subMenuChoice=int.Parse(Console.ReadLine());
                            switch(subMenuChoice)
                            {
                                case 1:
                                {
                                    BalanceCheck();
                                    break;
                                }

                                case 2:
                                { 
                                    Recharge();
                                    break;
                                }
                                case 3:
                                {
                                    ViewTravelHistory();
                                    break;
                                }
                                case 4:
                                {
                                    Travel();
                                    break;
                                }

                                case 5:
                                {
                                    option="no";
                                    break;
                                }
                                default :
                                {
                                    break;
                                }
                            }

            }while(option=="yes");
                 

         }//submenu ending here



         //showing balance
         public static void BalanceCheck()
         {

            foreach(UserDetails user in userDetailsList)
            {
                Console.WriteLine("Your current Balance: "+currentLoggedUser.Balance);
                break;
            }



         }//balance checkng ending here

         
        //rechargeing user waalet 
         public static void Recharge()
         {
            Console.WriteLine("Enter Amount to Recahage:");
            double inputRechargeAmount=double.Parse(Console.ReadLine());

            foreach(UserDetails user in userDetailsList)
            {
                currentLoggedUser.WalletRecharge(inputRechargeAmount);
                Console.WriteLine("Recharge Amount Succesfull.");
                break;

            }


         }//recharge endoong here


        //shoing travel history
         public static void ViewTravelHistory()
         {
            foreach(TravelDetails travel in travelDetailsList)
            {
                if(currentLoggedUser.CardNumber==travel.CardNumber)
                {
                    Console.WriteLine($" {travel.TravelId}   {travel.CardNumber}  {travel.FromLocation} {travel.ToLocation} {travel.Date.ToString("dd/MM/yyyy")}  {travel.TravelCost}");
                }
            }

         }
         //ViewTravelHistory() ending here 



        //travel vreation 
         public static void Travel()
         {   Console.WriteLine($"TicketID    FromLocation      ToLocation    TicketPrice  ");
             foreach(TicketFairDetails ticket in ticketFairDetailsList)
            {

                Console.WriteLine($"{ticket.TicketID,-8}     {ticket.FromLocation,-12}   {ticket.ToLocation,15}       {ticket.TicketPrice,-20}");

            }

            Console.Write("Enter TicketID from the above list: ");
            string inputTickeetID=Console.ReadLine();
            bool flag=true;
            bool balanceflag=true;

            foreach(TicketFairDetails ticket in ticketFairDetailsList)
            {

              if(inputTickeetID.ToLower()==ticket.TicketID.ToLower())
              {
                flag=false;
                foreach(UserDetails user in userDetailsList)
                {
                    if(currentLoggedUser.Balance>=ticket.TicketPrice)
                    {
                        balanceflag=false;
                        user.DeductBalance(ticket.TicketPrice);
                        TravelDetails travel=new TravelDetails(user.CardNumber,ticket.FromLocation,ticket.ToLocation,DateTime.Now,ticket.TicketPrice);

                        travelDetailsList.Add(travel);
                        Console.WriteLine("<<<<<<<<<<<<<<<<Ticked Booked succesfully>>>>>>>>>");
                        break;
                        

                        
                    }
                }

            
              }

             }//validating ticket id is present or not if not below lines are excutes

                //ifuser have no balance then this wiil ocuur
             if(balanceflag)
             {
                Console.WriteLine("No balance to purchase tickket");
             }


            //if user enters the invalid ticet id
             if(flag)
             {
                Console.WriteLine("Invalid Ticket ID...........");
             }



         }//Travel ending here











        //inesrting default data
        public static void AddDefaultData()
        {
// CardNumber	UserName	Phone	Balance
// CMRL1001	Ravi	9848812345	1000
// CMRL1002	Baskaran	9948854321	1000

        UserDetails user1=new UserDetails("Ravi","9848812345",1000);
        UserDetails user2=new UserDetails("Baskaran","9948854321",1000);

        //userDetailsList.AddRange(new CustomizedList<UserDetails>{user1,user2});
        userDetailsList.Add(user1);
         userDetailsList.Add(user2);


        foreach(UserDetails  user in userDetailsList)
        {
            Console.WriteLine($"{user.CardNumber}       {user.UserName}    {user.PhoneNumber}    {user.Balance}");

        }




// TravelID	CardNumber	FromLocation	ToLocation	Date	TravelCost
// TID2001	CMRL1001	Airport	Egmore	10/10/2023	55
// TID2002	CMRL1001	Egmore	Koyambedu	10/10/2023	32
// TID2003	CMRL1002	Alandur	Koyambedu	10/11/2023	25
// TID2004	CMRL1002	Egmore	Thirumangalam	10/11/2023	25


            TravelDetails travel1=new TravelDetails("CMRL1001","Airport","Egmore",new DateTime(2023,10,10),55);
            TravelDetails travel2=new TravelDetails("CMRL1001","Egmore","Koyambedu",new DateTime(2023,10,10),32);
            TravelDetails travel3=new TravelDetails("CMRL1002","Alandur","Koyambedu",new DateTime(2023,11,10),25);
            TravelDetails travel4=new TravelDetails("CMRL1002","Egmore","Thirumangalam",new DateTime(2023,11,10),25);
            //travelDetailsList.AddRange(new List<TravelDetails>{travel1,travel2,travel3,travel4});
            travelDetailsList.Add(travel1);
             travelDetailsList.Add(travel2);
              travelDetailsList.Add(travel3);
               travelDetailsList.Add(travel4);
                



            foreach(TravelDetails travel in travelDetailsList)
            {
                Console.WriteLine($"{travel.TravelId}     {travel.CardNumber}          {travel.FromLocation}    {travel.ToLocation}    {travel.Date.ToString("dd/MM/yyyy")}    {travel.TravelCost}");

            }


// TicketID	FromLocation	ToLocation	Fair
// MR3001	Airport	Egmore	55
// MR3002	Airport	Koyambedu	25
// MR3003	Alandur	Koyambedu	25
// MR3004	Koyambedu	Egmore	32
// MR3005	Vadapalani	Egmore	45
// MR3006	Arumbakkam	Egmore	25
// MR3007	Vadapalani	Koyambedu	25
// MR3008	Arumbakkam	Koyambedu	16

            TicketFairDetails ticket1=new TicketFairDetails("Airport","Egmore",55);
            TicketFairDetails ticket2=new TicketFairDetails("Airport","Koyambedu",25);
            TicketFairDetails ticket3=new TicketFairDetails("Alandur","Koyambedu",25);
            TicketFairDetails ticket4=new TicketFairDetails("Koyambedu","Egmore",32);
            TicketFairDetails ticket5=new TicketFairDetails("Vadapalani","Egmore",45);
            TicketFairDetails ticket6=new TicketFairDetails("Arumbakkam","Egmore",25);
            TicketFairDetails ticket7=new TicketFairDetails("Vadapalani","Koyambedu",25);
            TicketFairDetails ticket8=new TicketFairDetails("Arumbakkam","Koyambedu",16);

            //ticketFairDetailsList.AddRange(new List<TicketFairDetails>{ticket1,ticket2,ticket3,ticket4,ticket5,ticket6,ticket7,ticket8});
            ticketFairDetailsList.Add(ticket1);
            ticketFairDetailsList.Add(ticket2);
            ticketFairDetailsList.Add(ticket3);
            ticketFairDetailsList.Add(ticket4);
            ticketFairDetailsList.Add(ticket5);
            ticketFairDetailsList.Add(ticket6);
            ticketFairDetailsList.Add(ticket7);
            ticketFairDetailsList.Add(ticket8);
            //ticketFairDetailsList.Add(ticket1);



            foreach(TicketFairDetails ticket in ticketFairDetailsList)
            {

                Console.WriteLine($"{ticket.TicketID}     {ticket.FromLocation}   {ticket.ToLocation}       {ticket.TicketPrice}");

            }
           











        }
        
    }
}