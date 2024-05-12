using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDetailsInfo
{
    public enum Gender{Select,Male,Female}
    public class PersonalInfo
    {
        
// Properties: Name, FatherName, Phone ,Mail, DOB, Gender
    private static int s_personalID=2000;

    public string  PersonalID { get; set; }


    public string  Name { get; set; }
    public string  FatherName{ get; set; }

    public string  Phone { get; set; }

    public string  Mail{ get; set; }
    public DateTime  Dob { get; set; }
    public Gender Gender { get; set; }


    public PersonalInfo(string name,string fathername,string phone,string mail,DateTime dob,Gender gender)
    {


        s_personalID++;
        PersonalID="PID"+s_personalID;
        Name=name;
        FatherName=fathername;
        Phone=phone;
        Mail=mail;
        Dob=dob;
        Gender=gender;
    }
    }
}