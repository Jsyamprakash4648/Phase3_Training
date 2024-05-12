using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public enum Gender{Select,Male,Female,Transgender}
    public class PersonalDetails
    {
// Properties: 
// •	Name
// •	FatherName
// •	Gender {Enum - Select, Male, Female, Transgender}
// •	Mobile
// •	MailID

   
    public string StudentID { get; }//readonly

    public string  Name { get; set; }

    public string  FatherName { get; set; }

    public Gender Gender { get; set; }
    public string Mobile { get; set; }
    public string  MailID { get; set; }
    // public string WorkStationNumber { get; set; } //WS101; 
    // public double Balance { get; set; }	//Balance


    public PersonalDetails(string name,string fathername,string mobile,string maild,Gender gender)
    {
       
        Name=name;
        FatherName=fathername;
        Gender=gender;
        Mobile=mobile;
        MailID=maild;
        // WorkStationNumber=workStationNumber;
        // Balance=balance;


    }



    }
}