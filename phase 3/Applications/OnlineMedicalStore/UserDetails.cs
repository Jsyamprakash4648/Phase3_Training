using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class UserDetails:PersonalDetails,IBalance
    {
        private int s_userId=1000;

        public string UserID { get; set; }

        private double  _balance;
        public double WalletBalance { get{return _balance;}  }


        public UserDetails(string name,int age,string city,string phoneNUmber,double balance):base( name, age, city, phoneNUmber)
        {
            s_userId++;
            UserID="UID"+s_userId;
            _balance=balance;
        }

        public void WalletRecharge(double amount)
        {
            _balance=_balance+amount;
        }

        public void DeductBalance(double amount)
        {
            _balance=_balance-amount;
        }


        
    }
}