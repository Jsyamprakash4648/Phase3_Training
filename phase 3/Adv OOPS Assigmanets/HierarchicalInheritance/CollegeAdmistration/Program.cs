using System;
using System.Net.Sockets;
using CollegeAdmistration;

namespace CollegeAdministration;

class Program 

{
    public static void Main(string[] args)
    {
//  Create an application for a College Administration, create two objects for teacher, student and principal and show their info.
// Class PersonalInfo:
// Properties: Name, FatherName, DOB, Phone, Gender, Mail
// Class Teacher Inherit PersonalInfo
// Properties: TeacherID, Department, Subject teaching, Qualification, YearOfExperience, DateOfJoining
// Methods:  ShowDetails
// Class StudentInfo inherit PersonalInfo
// Properties: StudentID, Degree, Department, semester
// Methods: ShowDetails
// Class PrincipalInfo inherit PersonalInfo
// Properties: PrincipalID, Qualification, YearOfExperience, DateOfJoining
// Methods: ShowDetails  

    StudentInfo studentInfo1=new StudentInfo("syam","jayaprakashh",new DateTime(2000,02,23),"1234567890",Gender.Male,"asd@as","BE","EEE",08);
    studentInfo1.ShowDetails();
    Console.WriteLine("____________________________________________________________________");

    Teacher teacher1=new Teacher("vijat","kumar",new DateTime(2000,02,23),"1234567890",Gender.Male,"asd@as","EEE","Maths","BED",10,new DateTime(2000,06,20));
    teacher1.ShowDetails();
    Console.WriteLine("____________________________________________________________________");

    
    PrincipalInfo pri1=new PrincipalInfo("satyamooryt","deva",new DateTime(2000,02,23),"1234567890",Gender.Male,"asd@as","BE",20,new DateTime(2000,12,12));
    pri1.ShowDetails();
    Console.WriteLine("____________________________________________________________________");



    }
}
