using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public sealed class EmployeeInfo
    {
        // Properties: UserID, Password, KeyInfo = 100

        public string  UserID { get; set; }

        public String  Password { get; set; }

        public int KeyInfo { get; set; }=100;

       public void UpdateInfo(string userid,string password)
       {
        UserID=userid;
        Password=password;

       }  
       public void DisplayInfo()
       {
        Console.WriteLine($"userId :{UserID} \nPassword:{Password} \nKeyInfo: {KeyInfo}");



       }

       
    }
}