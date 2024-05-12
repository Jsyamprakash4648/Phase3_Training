using System;
using MultiLevelInheritance;

namespace MultiLevelInheritance;

    
class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails person=new PersonalDetails("syam","Jayaprakash",Gender.Male,"1234567890");
        Console.WriteLine($"Person ID: {person.UserId}  Students Name: {person.Name}  FatherName: {person.FatherName} Gender: {person.Gender} Phone Number :{person.PhoneNumber}");

        StudentDetails student=new StudentDetails(person.UserId,person.Name,person.FatherName,person.Gender,person.PhoneNumber,1,"2012");

        EmployeeDetails employee=new EmployeeDetails(student.StudentID,person.UserId,person.Name,person.FatherName,person.Gender,person.PhoneNumber,student.Standard,student.YearOfJoining,"Developer");
    }
}


