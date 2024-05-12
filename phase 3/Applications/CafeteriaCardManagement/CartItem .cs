using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public class CartItem 
    {

        private static int s_itemID=100;

        public string ItemID { get; set; }
        public string OrderID  { get; set; }

        public string FoodID { get; set; }
        public double OrderPrice { get; set; }

        public int OrderQuantity { get; set; }

        public CartItem(string orderId,string foodId,double orderprice,int orderQuantity)
        {
            s_itemID++;
            ItemID="ITID"+s_itemID;
            OrderID=orderId;
            FoodID=foodId;
            OrderPrice=orderprice;
            OrderQuantity=orderQuantity;




        }



    }
}