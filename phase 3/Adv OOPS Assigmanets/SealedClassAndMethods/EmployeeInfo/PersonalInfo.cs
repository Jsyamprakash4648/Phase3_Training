using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public enum Gender{Select,Male,Female,Trans}
    //// Properties: Name, FatherName, Mobile, Mail, Gender
    public class PersonalInfo
    {

    public string  Name { get; set; }
    public string  FatherName{ get; set; }

    public string  Phone { get; set; }

    public string  Mail{ get; set; }
    //public DateTime  Dob { get; set; }

    public Gender Gender { get; set; }


       
       public void UpDateInfo(String name,string fathername,string phone,string mail,Gender gender)
       {

        Name=name;
        FatherName=fathername;
        Phone=phone;
        Mail=mail;
        Gender=gender;
        
     


       }

    }
}