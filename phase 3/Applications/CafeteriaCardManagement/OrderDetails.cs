using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{ public enum OrderStatus{Default, Initiated, Ordered, Cancelled}
    public class OrderDetails
    {
// Properties:
// •	 (Auto – OID1001)
// •	UserID
// •	OrderDate
// •	TotalPrice
// •	OrderOrderIDStatus – (Default, Initiated, Ordered, Cancelled)
    private static int s_orderID=1000;
    public string  OrderID  { get; set; }
    public string UserID  { get; set; }
    public DateTime OrderDate { get; set; }
    public double TotalPrice { get; set; }
    public OrderStatus OrderStatus { get; set; }

   public OrderDetails(string userID,DateTime orderDate,double totalPrice,OrderStatus orderStatus )
   {
    s_orderID++;
    OrderID="OID"+s_orderID;
    UserID=userID;
    OrderDate=orderDate;
    TotalPrice=totalPrice;
    OrderStatus=orderStatus;


   }

    }
}