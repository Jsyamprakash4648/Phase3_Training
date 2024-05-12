using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public enum OrderStatus{Seelect,Purchased, Cancelled}
    public class OrderDetails
    {
// Properties:
// a.	OrderID (Auto increment - OID2001)
// b.	UserID
// c.	MedicineID
// d.	MedicineCount
// e.	TotalPrice
// f.	OrderDate
// g.	OrderStatus {Enum – Purchased, Cancelled}


        private static int s_orderID=2000;
        public string OrderID { get; set; }

        public string UserID { get; set; }

        public string MedicineID { get; set; }
        public int MedicineCount { get; set; }

        public double TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }

        public OrderStatus OrderStatus { get; set; }


        public OrderDetails(string userID,string medicineID,int medicineCount, double totalPrice,DateTime orderDate , OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID="OID"+OrderID;
            UserID=userID;
            MedicineID=medicineID;
            MedicineCount=medicineCount;
            TotalPrice=totalPrice;
            OrderDate=orderDate;
            OrderStatus=orderStatus;

        }



    }
}