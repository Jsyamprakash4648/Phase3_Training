using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HirarchicalInheritance 
{
    public class CustomerDetails:PersonalDetails 
    {
        
        private static int s_customerID=2000;

        public string  CustomerID { get; set; }

         public int Balance { get; set; }



         public CustomerDetails(string userID,string name,string fathername, Gender gender,string phoneNumber,int balance):base( userID, name, fathername,  gender, phoneNumber)
         {
            s_customerID++;

            CustomerID="CID"+s_customerID;
            Balance=balance;

         }

         


    }
}