using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmistration
{
    public class StudentInfo:PersonalInfo
    {

// Properties: StudentID, Degree, Department, semester
    private static int s_studentID=2000;

    public string StudentID { get; set; }

    public string  Degree { get; set; }
    public string  Department { get; set; }
    public int Semester { get; set; }        

    public StudentInfo(string name,string fathername,DateTime dob ,string phone,Gender gender,string mail,string degree,string department,int semester):base( name, fathername, dob , phone, gender, mail)
    {
        s_studentID++;
        StudentID="SID"+s_studentID;
        Degree=degree;
        Department=department;
        Semester=semester;
    }

    public void ShowDetails()
        {
            
            Console.WriteLine($"Student ID:{StudentID},\nName: {Name} \nFatherName: {FatherName}  \nDOB: {Dob} \nPhone: {Phone} \nGender: {Gender} \nMail:{Mail}  StudentID: {StudentID} Degree: {Degree} Department: {Department} semester: {Semester}");

        }
    }
}