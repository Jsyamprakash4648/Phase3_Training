using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmistration
{
    public class Teacher:PersonalInfo
    {
//TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining

     private static int s_teacherID=1000;

     public string  TeacherID { get; set; }

     public string  Department { get; set; }
     public string  SubjectTeaching { get; set; }

     public string Qualification { get; set; }
     public int YearOfExperience { get; set; }
     public DateTime DateOfJoining { get; set; }


     public Teacher(string name,string fathername,DateTime dob ,string phone,Gender gender,string mail,string department,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateofjoining):base( name, fathername, dob , phone, gender, mail)
     {
        s_teacherID++;
        TeacherID="TID"+s_teacherID;
        Department=department;
        SubjectTeaching=subjectTeaching;
        Qualification=qualification;
        YearOfExperience=yearOfExperience;
        DateOfJoining=dateofjoining;



     }

     public void ShowDetails()
        {
            
            Console.WriteLine($"Teacher ID:{TeacherID},\nName: {Name} \nFatherName: {FatherName}  \nDOB: {Dob} \nPhone: {Phone} \nGender: {Gender} \nMail:{Mail}  \nTeacherID: {TeacherID} \nDepartment: {Department} \nSubjectteaching: {SubjectTeaching} \nQualification: {Qualification} \nYearOfExperience: {YearOfExperience} \nDateOfJoining : {DateOfJoining}");

        }


        
    }
}