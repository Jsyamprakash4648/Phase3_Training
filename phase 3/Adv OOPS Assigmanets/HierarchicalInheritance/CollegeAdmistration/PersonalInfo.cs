using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmistration
{
    public enum Gender{Select,Male,Female,Transgender}
    public class PersonalInfo
    {
    //private static int s_personalID=2000;

    //public string  PersonalID { get; set; }

//Name, FatherName, DOB, Phone, Gender, Mail
    public string  Name { get; set; }
    public string  FatherName{ get; set; }
    public DateTime  Dob { get; set; }

    public string  Phone { get; set; }
    public Gender Gender { get; set; }

    public string  Mail{ get; set; }


    public PersonalInfo(string name,string fathername,DateTime dob ,string phone,Gender gender,string mail)
        {
           Name=name;
           FatherName=fathername;
           Dob=dob;
           Phone=phone;
           Gender=gender;
           Mail=mail;

            
        
        }
    


    }
}