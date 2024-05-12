using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HirarchicalInheritance
{
    public enum Gender{Select,Male,Female}
    public  class PersonalDetails
    {
        private static int s_userId=1000;


        public string  UserId { get;  }
        public string  Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }

        public string PhoneNumber { get; set; }

        public PersonalDetails(string name,string fathername, Gender gender,string phoneNumber)
            {

                s_userId++;
                UserId="UID"+s_userId;
                Name=name;
                FatherName=fathername;
                Gender=gender;
                PhoneNumber=phoneNumber;
        

            }

        public PersonalDetails(string userID,string name,string fathername, Gender gender,string phoneNumber)
            {

            
                UserId=userID;
                Name=name;
                FatherName=fathername;
                Gender=gender;
                PhoneNumber=phoneNumber;
        

            }

    }
}