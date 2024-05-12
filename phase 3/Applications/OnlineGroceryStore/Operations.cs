using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public static class Operations
    {





        
        static List<CustomerRegistration> customersList=new List<CustomerRegistration>();
         static List<ProductDetails> productsList=new List<ProductDetails>();
          static List<BookingDetails> bookingsLIst=new List<BookingDetails>();
           static List<OrderDetails> ordersList=new List<OrderDetails>();
           public static CustomerRegistration currentLoggedUser;






           public static void MainMenu()
           {

            Console.WriteLine("....................WELCOME TO SYNC ONLLINE GROCERY STORE.................");

            
             string maintoptionflag="yes";
            do
            {
                Console.WriteLine("1.Customer Registration \n2.Customer Login  \n3.Exit  \nchoose one option:  ");
            int mainChoice=int.Parse(Console.ReadLine());
           


                switch(mainChoice)
            {
                case 1:
                {
                    Registration();
                    break;
                }

                case 2:
                {
                    login();
                    break;
                }

                case 3:
                {
                    maintoptionflag="no";
                    
                    break;
                }
                default :
                {
                    System.Console.WriteLine("invlid opytion: ");
                    break;
                }




            }

            }while(maintoptionflag=="yes");

            

           }





           public static void  Registration()
        

            // public CustomerRegistration(string name,string fathername,Gender gender,string mobile,DateTime dob,string mailId,double walletbalance) :
              
            {
                //Need to get required details
                Console.Write("Enter your Name: ");
                string name=Console.ReadLine();

                Console.Write("Enter your fathers Name: ");
                string fathersName=Console.ReadLine();

                Console.Write("enter your gender: ");
                Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);

                 Console.Write("Enter your  Num: ");
                string mobile=Console.ReadLine();
                

                Console.Write("Enter your Date of Birth");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

                  Console.Write("Enter your  MailID : ");
                string mailID=Console.ReadLine();


                Console.Write("Enter your  Wallet balance : ");
                double Walletbalance=double.Parse(Console.ReadLine());

                 
              
                //need to create an objecct
                CustomerRegistration customer=new CustomerRegistration(name,fathersName,gender,mobile,dob,mailID,Walletbalance);
                //need to add in the list
                customersList.Add(customer);

                //need to display confirmation message and Id
                Console.WriteLine($"Your Customer is "+customer.CustomerID);

            }// Registration ends




            public static void  login()
            {
                System.Console.WriteLine("......................Welcome to loin:.................");



                System.Console.WriteLine("Enter yopur customer Id");
                

                string customerId=Console.ReadLine();
                bool flag=true;

                
            foreach(CustomerRegistration customer  in customersList)
            {
                if(customerId==customer.CustomerID)
                {
                    flag=false;
                    currentLoggedUser=customer;
                    System.Console.WriteLine("welcome ..."+customer.Name);

                    SubMenu();
                }
            }
            if(flag)
            {
                System.Console.WriteLine("invalid customer ID:   ");
            }
  }














        public static void SubMenu()
        {



            

                         string submenuoptionflag="yes";
                        do
                        {

                            System.Console.WriteLine("  1)Show Customer Details  \n2)Show Product Details   \n3)Wallet Recharge   \n4)Take Order   \n5)Modify Order Quantity  \n6)Cancel Order \n7)Sow Blance \n8)Exit");
                            int submenuoption=int.Parse(Console.ReadLine());

                            switch(submenuoption)
                            {
                                case 1:
                                {
                                    ShowCustomerDetails();
                                    break;
                                }
                                case 2:
                                {
                                    ShowProductDetails();
                                    break;
                                }
                                case 3:
                                {

                                    WalletRecharge();
                                    break;
                                }
                                case 4:
                                {

                                    //TakeOrder();
                                    break;
                                }
                                case 5:
                                {

                                    ModifyOrderQuantity();
                                    break;
                                }
                                case 6:
                                {
                                   // CancelOrder();
                                    break;
                                }
                                case 7:
                                {
                                    ShowBlance();
                                    break;
                                }
                                case 8:
                                {
                                    submenuoptionflag="no";
                                    break;
                                }



                            }

                        }while(submenuoptionflag=="yes");
            
        }



        public static void ShowCustomerDetails()
        {

            foreach(CustomerRegistration customer  in customersList)
            {
                Console.WriteLine($"{currentLoggedUser.CustomerID}   {currentLoggedUser.Name}   {currentLoggedUser.FatherName}   {currentLoggedUser.Gender}   {currentLoggedUser.Mobile}   {currentLoggedUser.DOb.ToString("dd/MM/yyyy")}   {currentLoggedUser.MailID}   {currentLoggedUser.WalletBalance}");
            break;
            }


        }



        public static void  ShowProductDetails()
        {

            foreach(ProductDetails product in productsList)
                        {
                                  Console.WriteLine($"{product.ProductID}   {product.ProductName}     {product.QuantityAvailable}   {product.PricePerQuantity}");
                        }

        }
        
        
        public static void WalletRecharge()
        {

            System.Console.WriteLine("Enter Amount:  ");
            double amount=double.Parse(Console.ReadLine());

                currentLoggedUser.WalletRecharge(amount);
            
            


        }



        public static void  ModifyOrderQuantity()
        {


            
             foreach(BookingDetails booking in bookingsLIst)
             {

                if(currentLoggedUser.CustomerID==booking.CustomerID && booking.BookingStatus==BookingStatus.Booked)
                {
                    Console.WriteLine($"{booking.BookingID}  {booking.CustomerID} {booking.DateOfBooking.ToString("dd/MM/yyyy")}  {booking.BookingStatus}");
                  

                }
             }




            System.Console.WriteLine("enter new quanty of booking id : ");
            string  bookingId=Console.ReadLine();
            int count=0;
            
             foreach(BookingDetails booking in bookingsLIst)
             {


                if( booking.BookingID==bookingId)
                {
                    count++;
                }
             }
             if (count==0)
             {
                
                        foreach(OrderDetails order in ordersList)
                        {
                            if(bookingId==order.BookingID)
                            {
                                 Console.WriteLine($"{order.OrderID}   {order.BookingID} {order.ProductID}   {order.PurchaseCount}   {order.PriceOfOrder}");

                            }
                           
                        }
                
             }

             System.Console.WriteLine("enter the new quantity: ");

             int newquantity=int.Parse(Console.ReadLine());



              foreach(OrderDetails order in ordersList)
                        {
                            if(bookingId==order.BookingID && newquantity<=order.PurchaseCount)
                            {
                               System.Console.WriteLine("modifyed Succesfully");
                               

                            }
                            
                           
                        }







            







        }


        public static void  ShowBlance()
        {
             
                Console.WriteLine(currentLoggedUser.WalletBalance);            

         }
        public static  void AddDefaultData()
        {

            CustomerRegistration customer1=new CustomerRegistration("Ravi","Ettapparajan",Gender.Male,"974774646",new DateTime(1999,11,11),"ravi@gmail.com",10000 );
               CustomerRegistration customer2=new CustomerRegistration("Baskaran","Sethurajan",Gender.Male,"847575775",new DateTime(1999,11,11),"baskaran@gmail.com",15000);
            customersList.AddRange(new List<CustomerRegistration>{customer1,customer2});




            foreach(CustomerRegistration customer  in customersList)
            {
                Console.WriteLine($"{customer.CustomerID}   {customer.Name}   {customer.FatherName}   {customer.Gender}   {customer.Mobile}   {customer.DOb.ToString("dd/MM/yyyy")}   {customer.MailID}   {customer.WalletBalance}");
            }





            ProductDetails product1=new ProductDetails("Sugar",20,40);
             ProductDetails product2=new ProductDetails("Rice",100,50);
              ProductDetails product3=new ProductDetails("Milk",10,40);
               ProductDetails product4=new ProductDetails("Coffee",10,10);
                ProductDetails product5=new ProductDetails("Tea",10,10);
                 ProductDetails product6=new ProductDetails("Masala Powder",10,20);
                  ProductDetails product7=new ProductDetails("Salt",10,10);
                   ProductDetails product8=new ProductDetails("Turmeric Powder",10,25);
                    ProductDetails product9=new ProductDetails("Chilli Powder",10,20);
                     ProductDetails product10=new ProductDetails("Groundnut Oil",10,140);
                     productsList.AddRange(new List<ProductDetails>{product1,product2,product3,product4,product5,product6,product7,product8,product9,product10});


                        foreach(ProductDetails product in productsList)
                        {
                                  Console.WriteLine($"{product.ProductID}   {product.ProductName}     {product.QuantityAvailable}   {product.PricePerQuantity}");
                        }




                        BookingDetails book1=new BookingDetails("CID1001",220,new DateTime(2022,07,26),BookingStatus.Booked);
                        BookingDetails book2=new BookingDetails("CID1002",400,new DateTime(2022,07,26),BookingStatus.Booked);
                        BookingDetails book3=new BookingDetails("CID1001",280,new DateTime(2022,07,26),BookingStatus.Cancelled);
                        BookingDetails book4=new BookingDetails("CID1002",0,new DateTime(2022,07,26),BookingStatus.Initiated);


                        bookingsLIst.AddRange(new List<BookingDetails>{book1,book2,book3,book4});

                        foreach(BookingDetails booking in bookingsLIst)
                        {
                                  Console.WriteLine($"{booking.BookingID}  {booking.CustomerID} {booking.DateOfBooking.ToString("dd/MM/yyyy")}  {booking.BookingStatus}");
                        }




                        OrderDetails order1=new OrderDetails("BID3001","PID2001",2,80);
                        OrderDetails order2=new OrderDetails("BID3001","PID2002",2,100);
                        OrderDetails order3=new OrderDetails("BID3001","PID2003",1,40);
                        OrderDetails order4=new OrderDetails("BID3002","PID2001",1,40);
                        OrderDetails order5=new OrderDetails("BID3002","PID2002",4,200);
                        OrderDetails order6=new OrderDetails("BID3002","PID2010",1,140);
                        OrderDetails order7=new OrderDetails("BID3002","PID2009",1,20);
                        OrderDetails order8=new OrderDetails("BID3003","PID2002",2,100);
                        OrderDetails order9=new OrderDetails("BID3003","PID2008",4,100);
                        OrderDetails order10=new OrderDetails("BID3003","PID2001",2,80);



                        ordersList.AddRange(new List<OrderDetails>{order1,order2,order3,order4,order5,order6,order7,order8,order9,order10});


                        foreach(OrderDetails order in ordersList)
                        {
                            Console.WriteLine($"{order.OrderID}   {order.BookingID} {order.ProductID}   {order.PurchaseCount}   {order.PriceOfOrder}");
                        }









                       
                   








        }
    }
}