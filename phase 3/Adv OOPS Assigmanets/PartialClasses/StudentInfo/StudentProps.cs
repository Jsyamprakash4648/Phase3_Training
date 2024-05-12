using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo
{
    public enum Gender{Select,Male,Female,Transgender}
    public partial class StudentInfo
    {
//StudentID,Name,Gender,DOB, Mobile, Physics, Chemistry, Maths Marks


    private static int s_studentID=1000; 
    public string  StudentId { get; set; }
    public string  Name { get; set; }
     public Gender Gender { get; set; }
     public DateTime  Dob { get; set; }
    public string  PhoneNumber { get; set; }

    public int   Physics{ get; set; }
    public int   Chemistry{ get; set; }
    public int   Maths{ get; set; }
    

   
    }
}