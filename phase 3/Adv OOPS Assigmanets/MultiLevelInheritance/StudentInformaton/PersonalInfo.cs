using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformaton
{
    public enum Gender{Select,Male,Female,Transgender}
    public class PersonalInfo
    {
// Properties: Name, FatherName,Phone,Mail, dob,Gender/
// Constructor to assign values

    public string  Name { get; set; }
    public string  FatherName{ get; set; }

    public string  Phone { get; set; }

    public string  Mail{ get; set; }
    public DateTime  Dob { get; set; }

    public Gender Gender { get; set; }


    public PersonalInfo(string name,string fathername,string phone,string mail,DateTime dob,Gender gender)
    {


        //s_personalID++;
        //PersonalID="PID"+s_personalID;
        Name=name;
        FatherName=fathername;
        Phone=phone;
        Mail=mail;
        Dob=dob;
        Gender=gender;
    }
    }
}