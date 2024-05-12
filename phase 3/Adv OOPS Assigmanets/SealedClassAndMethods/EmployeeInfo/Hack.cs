using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public class Hack:EmployeeInfo
    {

        public string StoreUserID  { get; set; }
        public string StorePassword { get; set; }


        public void ShowKeyInfo()
        {
            DisplayInfo();

        } 
        public void GetUserInfo()
        {
            Console.WriteLine("userID"+UserID);

        }
        public void  ShowUserInfo()
        {
            Console.WriteLine("UserID: "+UserID)

        }
        
        
        
    }
}