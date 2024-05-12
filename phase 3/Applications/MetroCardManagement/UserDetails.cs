using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class UserDetails:PersonalDetails,IBalance
    {

// Properties:
// •	CardNumber(Auto generation- CMRL1001)
// •	Balance 

        private static int s_cardNumber=1000;

        public string  CardNumber { get; set; }

        public double Balance { get{return _balance;}  }
        private double _balance;

        public UserDetails(string username,string phoneNumber,double balance):base( username, phoneNumber)
        {
            s_cardNumber++;
            CardNumber="CMRL"+s_cardNumber;



            _balance=balance;
        }

        public UserDetails(string cardnumber,string username,string phoneNumber,double balance):base( username, phoneNumber)
        {   CardNumber=cardnumber;
        s_cardNumber=int.Parse(cardnumber.Remove(0,4));
            UserName=username;
            PhoneNumber=phoneNumber;
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