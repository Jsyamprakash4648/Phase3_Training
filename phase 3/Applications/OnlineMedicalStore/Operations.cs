using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public static class Operations
    {
        public static List <UserDetails> userDetailsList=new List<UserDetails>();
        public static List <MedicineDetails> MedicineDetailsList=new List<MedicineDetails>();
        public static List <OrderDetails> OrderDetailsList=new List<OrderDetails>();






        public static void AddDefaultData()
        {

// Baskaran	33	Chennai	8847757470	500

            UserDetails user1=new UserDetails("Ravi",33,"Theni","9877774440",400);
            UserDetails user2=new UserDetails("Baskaran",33,"Chennai","8847757470",500);

            userDetailsList.AddRange( new List<UserDetails>{user1,user2});

            foreach(UserDetails user in userDetailsList)
            {
                Console.WriteLine($"{user.UserID}   {user.Name}   {user.Age}  {user.City}  {user.PhoneNUmber}  {user.WalletBalance}");

            }






        MedicineDetails medicine1=new MedicineDetails("Paracitamol",40,5,new DateTime(2024,06,30));
        MedicineDetails medicine2=new MedicineDetails("Calpol",10,5,new DateTime(2024,05,30));
        MedicineDetails medicine3=new MedicineDetails("Gelucil",3,40,new DateTime(2024,04,30));
        MedicineDetails medicine4=new MedicineDetails("Metrogel",5,50,new DateTime(2024,12,30));
        MedicineDetails medicine5=new MedicineDetails("Povidin Iodin",10,50,new DateTime(2024,10,30));


        foreach(MedicineDetails medicine in MedicineDetailsList)
        {
            Console.WriteLine($"{medicine.MedicineID}  {medicine.MedicineName}  {medicine.AvailableCount}  {medicine.Price}   {medicine.DateOfExpiry}");
        }






        OrderDetails order1=new OrderDetails("UID1001","MD101",3,15,	new DateTime(2022,11,13),OrderStatus.Purchased);
        OrderDetails order2=new OrderDetails("UID1001","MD102",2,10,	new DateTime(2022,11,13),OrderStatus.Cancelled);
        OrderDetails order3=new OrderDetails("UID1001","MD104",2,100,	new DateTime(2022,11,13),OrderStatus.Purchased);
        OrderDetails order4=new OrderDetails("UID1001","MD103",3,120,	new DateTime(2022,11,15),OrderStatus.Cancelled);
        OrderDetails order5=new OrderDetails("UID1001","MD105",5,250,	new DateTime(2022,11,15),OrderStatus.Purchased);
        OrderDetails order6=new OrderDetails("UID1001","MD102",3,15,	new DateTime(2022,11,15),OrderStatus.Purchased);


        OrderDetailsList.AddRange(new List<OrderDetails>{order1,order2,order3,order4,order5,order6});



        foreach(OrderDetails order in OrderDetailsList)
        {
            System.Console.WriteLine($"{order.OrderID}   {order.UserID}   {order.MedicineID}   {order.MedicineCount}  {order.TotalPrice}  {order.OrderDate}  {order.OrderStatus}");
        }
        






        }

            

        
        
    }
}