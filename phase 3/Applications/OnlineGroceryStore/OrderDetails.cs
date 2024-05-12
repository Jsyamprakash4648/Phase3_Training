using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class OrderDetails
    {
        //OrderID {Auto Increment – OID4000}, BookingID, ProductID, PurchaseCount, PriceOfOrder

        private int s_orderID=4000;
        public string  OrderID { get; set; }
        public string  BookingID { get; set; }
        public string  ProductID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }

        public OrderDetails(string bookingID,string productID,int purchaseCount,double priceOfOrder )
        {
            s_orderID++;
            OrderID="OID"+s_orderID;
            BookingID=bookingID;
            ProductID=productID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;






        }
    }
}