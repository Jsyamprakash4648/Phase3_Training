using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public class UserDetails:PersonalDetails,IBalance
  
   {

     private static int s_userID=1000;

    //public string UserID { get; set; }
        //  

    public String  UserID { get; }
    public string WorkStationNumber { get; set; } //WS101; 
     public double Balance { get; set; }
     private double _balance;	//Balance
      public   double WalletBalance { get{return _balance;} }

     

     public UserDetails(string name,string fathername,string mobile,string maild,Gender gender,string workStationNumber,double balance):base( name, fathername, mobile, maild,gender)
     
     {
        s_userID++;
        UserID="SF"+s_userID;
        WorkStationNumber=workStationNumber;
        _balance=balance;
        
    }

        
        

     public void WalletRecharge(double amount)
     {
        _balance=_balance+amount;

     } 
        public void DeductAmount(double amount)
        {
           _balance=_balance-amount;
        }

     






        
    }
}