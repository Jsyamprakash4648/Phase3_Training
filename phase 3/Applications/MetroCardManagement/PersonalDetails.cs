using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class PersonalDetails
    {
//         //Properties:
// •	UserName
// •	Phone Number
//getting user name
public string  UserName { get; set; }
// getting phonenumber
public string PhoneNumber { get; set; }
        // construtor
        public PersonalDetails(string username,string phoneNumber)
        {

            UserName=username;
            PhoneNumber=phoneNumber;


        }

    }
}