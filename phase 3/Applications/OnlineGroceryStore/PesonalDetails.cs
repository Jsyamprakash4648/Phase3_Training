using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStore
{
    
    public enum Gender{Select,Male,Female,Transgender}

    public class PesonalDetails
    {
    public string  Name { get; set; }

    public string  FatherName { get; set; }

    public Gender Gender { get; set; }
    public string Mobile { get; set; }
    public string  MailID { get; set; }
    public DateTime DOb { get; set; }

    public PesonalDetails(string name,string fathername,Gender gender,string mobile,DateTime dob,string mailId)
    {
        Name=name;
        FatherName=fathername;
        Gender=gender;
        Mobile=mobile;
        DOb=dob;
        MailID=mailId;
    }



        
    }   
}