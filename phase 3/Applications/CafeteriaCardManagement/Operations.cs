using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public static class Operations
    {
        static CustomList<FoodDetails> foodDetailsList = new CustomList<FoodDetails>();
        static List<CartItem> cartItemList = new List<CartItem>();
        static CustomList<OrderDetails> orderDetailsList = new CustomList<OrderDetails>();
        static CustomList<UserDetails> userDetailsList = new CustomList<UserDetails>();
        static string line="_____________________________________________________________";

        public static UserDetails currentLoggedUser;


        public static void MainMenu()
        {
            Console.WriteLine("__________Welcome to Syncfusion Cafeteria______________");
            int mainOption;

            string choice = "yes";
            do
            {

                Console.WriteLine($"   \n1.User Registration  \n2.User Login  \n3.Exit");
                Console.Write("enter your option: ");
                mainOption = int.Parse(Console.ReadLine());


                switch (mainOption)
                {
                    case 1:
                        {
                            UserRegistration();
                            break;
                        }

                    case 2:
                        {
                            UserLogin();
                            break;


                        }
                    case 3:
                        {
                            choice = "no";
                            break;
                        }
                }



            } while (choice == "yes");

        }




        public static void UserRegistration()
        {

            Console.WriteLine("**************Registration Form******************");

            //Need to get required details
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your fathers Name: ");
            string fatherName = Console.ReadLine();

            Console.Write("Enter your mobileNumber : ");
            string mobileNumber = Console.ReadLine();

            Console.Write("Enter your MailID : ");
            string mailID = Console.ReadLine();

            Console.Write("enter your gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            Console.Write("Enter your WorkstationNumber : ");
            string workstationNumber = Console.ReadLine();

            Console.Write("Balance: ");
            double balance = double.Parse(Console.ReadLine());

            UserDetails user1 = new UserDetails(name, fatherName, mobileNumber, mailID, gender, workstationNumber, balance);
            userDetailsList.Add(user1);

            Console.WriteLine("your registration is successfull. your id is: " + user1.UserID);






        }//registration ending here


        public static void UserLogin()
        {
            Console.WriteLine("_________Login_____________");
            Console.WriteLine("enter your userId");
            string UserInputID = Console.ReadLine();
            bool flag = true;
            foreach (UserDetails user in userDetailsList)
            {
                if (user.UserID == UserInputID)
                {
                    currentLoggedUser = user;


                    flag = false;
                    Submenu();


                }

            }


            if (flag)
            {
                Console.Write("Invalid UserID");
            }

        }//login ending 



        public static void Submenu()
        {

            Console.WriteLine("**************Welccome to Cafeteria*******");


            string choice = "yes";

            do
            {

                Console.WriteLine($"1.Show My Profile  \n2.Food Order \n3.Modify Order \n4.Cancel Order  \n5.Order History \n6.Wallet Recharge \n7.Show WalletBalance \n8.Exit");
                Console.Write("Choose your option: ");

                int subMenuOption = int.Parse(Console.ReadLine());
                switch (subMenuOption)
                {
                    case 1:
                        {
                            ShowMyProfile();
                            break;
                        }
                    case 2:
                        {
                            FoodOrder();
                            break;
                        }
                    case 3:
                        {
                            ModifyOrder();
                            break;
                        }
                    case 4:
                        {
                            CancelOrder();
                            break;
                        }
                    case 5:
                        {
                            OrderHistory();
                            break;
                        }
                    case 6:
                        {
                            WalletRecharge();
                            break;

                        }
                    case 7:
                        {
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            choice = "no";
                            break;
                        }

                }


            } while (choice == "yes");


        }//submenu ending here



        public static void ShowMyProfile()
        {

            foreach (UserDetails user in userDetailsList)
            {
                Console.WriteLine($"{currentLoggedUser.UserID}           {currentLoggedUser.Name}           {currentLoggedUser.FatherName}       {currentLoggedUser.Mobile}      {currentLoggedUser.MailID}    {currentLoggedUser.Gender}    {currentLoggedUser.WorkStationNumber}    {currentLoggedUser.WalletBalance}");
                break;
            }

        }//ShowMyProfile() method ending here


        public static void FoodOrder()
        {           Console.WriteLine($"FoodID    Food Name      Price      availablequantity     ");
                    Console.WriteLine(line);

            foreach (FoodDetails fd in foodDetailsList)
                {   
                    Console.WriteLine($"{fd.FoodID,-10}   {fd.FoodName,-10}     {fd.FoodPrice,-10}    {fd.AvailableQuantity,-10}");
                }

                
              List<CartItem> tempCartlist2=new List<CartItem>();
              OrderDetails order=new OrderDetails(currentLoggedUser.UserID,DateTime.Now,0,OrderStatus.Initiated);
              string useraddingitem="yes";

              do
              {

                //input food id
              System.Console.Write("enter Food ID: ");
              string userFoodID=Console.ReadLine();
            //taking inpout food quanity
              System.Console.Write("enter food quantity: ");
              int userFoodQuantity=int.Parse(Console.ReadLine());
              double price;
            //trevesring food is presnted or not
              foreach(FoodDetails food in foodDetailsList)
              {
                if(userFoodID==food.FoodID && userFoodQuantity<=food.AvailableQuantity)
                {
                    food.AvailableQuantity=food.AvailableQuantity-userFoodQuantity;
                    price=food.FoodPrice*userFoodQuantity;
                     CartItem cart =new CartItem(order.UserID,food.FoodID,price,userFoodQuantity);
                     tempCartlist2.Add(cart);
                    
                }
              }
              System.Console.WriteLine("Is you want add another food");
              useraddingitem=Console.ReadLine().ToLower();

              }while(useraddingitem=="yes");





              System.Console.WriteLine("confirm the wish list to purchase -yes/no");
              string userWish=Console.ReadLine().ToLower();

              if(userWish=="no")
              {
                foreach (CartItem cart in cartItemList)
                {
                    Console.WriteLine($"{cart.ItemID}    {cart.OrderID}     {cart.FoodID}     {cart.OrderPrice}    {cart.OrderQuantity}");
                }

              }
                
              else if(userWish=="yes")
              {
                  double total=0;
                foreach(CartItem item in tempCartlist2)
                {
                    total=total+item.OrderPrice;

                }
                  if(currentLoggedUser.WalletBalance>=total)
                {
                    currentLoggedUser.Balance=currentLoggedUser.WalletBalance-total;
                    cartItemList=tempCartlist2;
                    order.TotalPrice=total;
                    order.OrderStatus=OrderStatus.Ordered;
                    orderDetailsList.Add(order);

                    System.Console.WriteLine("Order placed successfully, and OrderID is "+order.OrderID);


                }
                else
                {   System.Console.WriteLine("In sufficient balance to purchase.");
                    System.Console.WriteLine("Are you willing to recharge");
                    string userrechargeenquery=Console.ReadLine();

                    if(userrechargeenquery=="yes")
                    {  double diff=order.TotalPrice-currentLoggedUser.WalletBalance;
                        System.Console.WriteLine($"you need {diff} please recharge accordingly ");
                        System.Console.WriteLine("enter Amount to recharge ");

                        double amount=double.Parse(Console.ReadLine());
                        if(amount>=diff)
                        {
                            currentLoggedUser.WalletRecharge(amount);

                        }
                        else
                        {
                            System.Console.WriteLine("add more money to purchase:");
                        }



                    }
                    else if(userrechargeenquery=="no")
                    {
                        System.Console.WriteLine("Exiting without Order due to insufficient balance");

                    }
                    else
                    {
                        System.Console.WriteLine("inavlid input");

                    }
                }


              }
              else
              {
                System.Console.WriteLine("invlaid choice: ");
              }




            

             




            
            



        }
              



        public static void ModifyOrder()
        {
                bool foodordetailflag=false;
            foreach (OrderDetails ord in orderDetailsList)
                {       //checking whether current user oderlist
                    if (currentLoggedUser.UserID == ord.UserID && ord.OrderStatus==OrderStatus.Ordered)
                    {   foodordetailflag=true;
                        Console.WriteLine($"{ord.OrderID}     {ord.UserID}   {ord.OrderDate.ToString("dd/MM/yyyy")}   {ord.TotalPrice}   {ord.OrderStatus}");

                    }
                }

                if(foodordetailflag)
                {           System.Console.Write("Pick an orderID to modify:");
                            string userInputOrderIDtomodify=Console.ReadLine();
                            bool userInputOrderflag=false;
                             foreach(CartItem cart in cartItemList)
                                {
                                 if(cart.OrderID==userInputOrderIDtomodify)
                                    {
                                        userInputOrderflag=true;
                                      Console.WriteLine($"{cart.ItemID}    {cart.OrderID}     {cart.FoodID}     {cart.OrderPrice}    {cart.OrderQuantity}");
                                    }
                                
                        
                                }

                                if(!userInputOrderflag)
                                    {
                                        System.Console.WriteLine(" invalid order number:");
                                    }
                }

                if(foodordetailflag)
                {

                                  System.Console.WriteLine("enter item id to modify: ");

                                  string userItemID=Console.ReadLine();
                                  bool userInputItemflag=false;
                                  foreach(CartItem cart in cartItemList)    
                                        {
                                          if(cart.ItemID==userItemID)
                                            {
                                                userInputItemflag=true;
                                                System.Console.WriteLine("Enter the new quantity of food");

                                                int newQuantityFood=int.Parse(Console.ReadLine());
                                                 cart.OrderQuantity=cart.OrderQuantity+newQuantityFood;
                                                     foreach(FoodDetails food in foodDetailsList)
                                                            {
                                                              if(cart.FoodID==food.FoodID)
                                                                {
                                                                   cart.OrderPrice=food.FoodPrice*cart.OrderQuantity;
                                                                  foreach(OrderDetails order in orderDetailsList)
                                                                            {
                                                                                order.TotalPrice=order.TotalPrice+cart.OrderPrice;
                                                                                
                                                                            }
                                                                            
                                                                }
                                                             }
                                                              
                                            }
                                        }
                                        if(!userInputItemflag)
                                            {
                                               System.Console.WriteLine("invalid Item/ wrong Item number:");
                                            }



                }
                
                

                if(!foodordetailflag)
                {
                    System.Console.WriteLine("tou have no orders to Modify");
                }

                            
                                    

                                      
 


        }//modifyinh oreder ending here
                                    

                




        


        public static void CancelOrder()
        {


            //showing current user's order details whch ordered
            foreach (OrderDetails ord in orderDetailsList)
            {
                if (currentLoggedUser.UserID == ord.UserID && ord.OrderStatus == OrderStatus.Ordered)
                {
                    Console.WriteLine($"{ord.OrderID}     {ord.UserID}   {ord.OrderDate.ToString("dd/MM/yyyy")}   {ord.TotalPrice}   {ord.OrderStatus}");

                }

            }

            System.Console.Write("pick an OrderID to cancel : ");

            string userInputOrderID = Console.ReadLine();
            bool flag = true;
            foreach (OrderDetails ord in orderDetailsList)
            {

                if (userInputOrderID == ord.OrderID)
                {
                    flag = false;
                    currentLoggedUser.WalletRecharge(ord.TotalPrice);
                    //System.Console.WriteLine(currentLoggedUser.Balance);

                    foreach (CartItem cart in cartItemList)
                    {
                        if (cart.OrderID == ord.OrderID)
                        {
                            foreach (FoodDetails food in foodDetailsList)
                            {
                                food.AvailableQuantity = food.AvailableQuantity + cart.OrderQuantity;

                                ord.OrderStatus = OrderStatus.Cancelled;

                            }

                        }
                    }
                    System.Console.WriteLine("Order cancelled successfully");




                }
            }

                if (flag)
                {
                    System.Console.WriteLine("Invalid OrderID");
                }
            
            
        }//Ccnacel oerder ending here



            public static void OrderHistory()
            {

                foreach (OrderDetails ord in orderDetailsList)
                {
                    if (currentLoggedUser.UserID == ord.UserID)
                    {
                        Console.WriteLine($"{ord.OrderID}     {ord.UserID}   {ord.OrderDate.ToString("dd/MM/yyyy")}   {ord.TotalPrice}   {ord.OrderStatus}");

                    }

                }






            }



            public static void WalletRecharge()
            {

                Console.Write("Enter Amount: ");
                double amount = double.Parse(Console.ReadLine());
                currentLoggedUser.WalletRecharge(amount);
                Console.WriteLine("__Recharge Succesfull.___");

            }



            public static void ShowWalletBalance()
            {

                foreach (UserDetails user in userDetailsList)
                {
                    Console.WriteLine($"Your current WalletBalance:  {currentLoggedUser.WalletBalance}");
                    break;
                }



            }





            public static void AddDefaultData()
            {


                // SF1001	Ravichandran	Ettapparajan	8857777575	ravi@gmail.comMale	WS101	400
                // SF1002	Baskaran	Sethurajan	9577747744	baskaran@gmail.com	Male	WS105	500

                UserDetails user1 = new UserDetails("Ravichandran", "Ettapparajan", "8857777575", "ravi@gmail.com", Gender.Male, "WS101", 400);
                UserDetails user2 = new UserDetails("Baskaran", "Sethurajan", "9577747744", "baskaran@gmail.com", Gender.Male, "WS105", 500);

                userDetailsList.AddRange(new CustomList<UserDetails> { user1, user2 });


                foreach (UserDetails user in userDetailsList)
                {
                    Console.WriteLine($"{user.UserID}           {user.Name}           {user.FatherName}       {user.Mobile}      {user.MailID}    {user.Gender}    {user.WorkStationNumber}    {user.WalletBalance}");
                }











                OrderDetails order1 = new OrderDetails("SF1001", new DateTime(2022, 06, 15), 70, OrderStatus.Ordered);
                OrderDetails order2 = new OrderDetails("SF1002", new DateTime(2022, 06, 15), 100, OrderStatus.Ordered);

                orderDetailsList.AddRange(new CustomList<OrderDetails> { order1, order2 });

                foreach (OrderDetails ord in orderDetailsList)
                {
                    Console.WriteLine($"{ord.OrderID}     {ord.UserID}   {ord.OrderDate.ToString("dd/MM/yyyy")}   {ord.TotalPrice}   {ord.OrderStatus}");
                }







                FoodDetails food1 = new FoodDetails("Coffee", 20, 100);
                FoodDetails food2 = new FoodDetails("Tea", 15, 100);
                FoodDetails food3 = new FoodDetails("Biscuit", 10, 100);
                FoodDetails food4 = new FoodDetails("Juice", 50, 100);
                FoodDetails food5 = new FoodDetails("Puff", 40, 100);
                FoodDetails food6 = new FoodDetails("Milk", 10, 100);
                FoodDetails food7 = new FoodDetails("Popcorn", 20, 20);


                foodDetailsList.AddRange(new CustomList<FoodDetails> { food1, food2, food3, food4, food5, food6, food7 });


                foreach (FoodDetails fd in foodDetailsList)
                {
                    Console.WriteLine($"{fd.FoodID}   {fd.FoodName}     {fd.FoodPrice}    {fd.AvailableQuantity}");
                }

                // ItemID	OrderID	FoodID	OrderPrice	OrderQuantity
                // ITID101	OID1001	FID101	20	1
                // ITID102	OID1001	FID103	10	1
                // ITID103	OID1001	FID105	40	1
                // ITID104	OID1002	FID103	10	1
                // ITID105	OID1002	FID104	50	1
                // ITID106	OID1002	FID105	40	1


                CartItem cart1 = new CartItem("OID1001", "FID101", 20, 1);
                CartItem cart2 = new CartItem("OID1001", "FID103", 10, 1);
                CartItem cart3 = new CartItem("OID1001", "FID105", 40, 1);
                CartItem cart4 = new CartItem("OID1002", "FID103", 10, 1);
                CartItem cart5 = new CartItem("OID1002", "FID104", 50, 1);
                CartItem cart6 = new CartItem("OID1002", "FID105", 40, 1);

                cartItemList.AddRange(new List<CartItem> { cart1, cart2, cart3, cart4, cart5, cart6 });

                foreach (CartItem cart in cartItemList)
                {
                    Console.WriteLine($"{cart.ItemID}    {cart.OrderID}     {cart.FoodID}     {cart.OrderPrice}    {cart.OrderQuantity}");
                }



                //CartItem cartItem1=new CartItem()

            }
        }
    }