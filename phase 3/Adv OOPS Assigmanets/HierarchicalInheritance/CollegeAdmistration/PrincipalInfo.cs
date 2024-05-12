using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmistration
{
    public class PrincipalInfo:PersonalInfo
    {

        //Properties: PrincipalID, Qualification, YearOfExperience, DateOfJoining
        //Name, FatherName, DOB, Phone, Gender, Mail
    private static int s_principalID=3000;

     public string  PrincipalIDID { get; set; }

     public string Qualification { get; set; }
     public int YearOfExperience { get; set; }
     public DateTime DateOfJoining { get; set; }

     public PrincipalInfo(string name,string fathername,DateTime dob ,string phone,Gender gender,string mail,string qualification,int yearOfExperience,DateTime dateOfJoing):base( name, fathername, dob , phone, gender, mail)
     {
        s_principalID++;
        PrincipalIDID="PID"+s_principalID;
        Qualification=qualification;
        YearOfExperience=yearOfExperience;
        DateOfJoining=dateOfJoing;

     }

   


        public void ShowDetails()
        {
            
            Console.WriteLine($"Prinipal ID:{PrincipalIDID},\nName: {Name} \nFatherName: {FatherName}  \nDOB: {Dob} \nPhone: {Phone} \nGender: {Gender} \nMail:{Mail} \nQualification: {Qualification} \nYearOfExperience: {YearOfExperience} \nDateOfJoining: {DateOfJoining}");

        }
    }
}