using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    public class CustomerRegistration:PesonalDetails,IBalance
    {
        //Properties: CustomerID {Auto Increment – CID1000}, WalletBalance

        private static int s_customerID=1000;

        public string  CustomerID { get; set; }

        public double WalletBalance  { get{return _balance;} }
        private double _balance;

        public CustomerRegistration(string name,string fathername,Gender gender,string mobile,DateTime dob,string mailId,double walletbalance) :base( name, fathername, gender, mobile,dob,mailId)
        {
            s_customerID++;
            CustomerID="CID"+s_customerID;
            _balance=walletbalance;




        }


        public void WalletRecharge(double amount)
        {
            _balance=WalletBalance+amount;


        }
    }
}