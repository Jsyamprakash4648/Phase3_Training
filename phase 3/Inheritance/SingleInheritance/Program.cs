using System;
using SingleInheritance;

namespace SingleInheritancel;

    
class Program 
{
    public static void Main(string[] args)
    {
        PersonalDetails person=new PersonalDetails("syam","Jayaprakash",Gender.Male,"1234567890");
        Console.WriteLine($"Person ID: {person.UserId}  Students Name: {person.Name}  FatherName: {person.FatherName} Gender: {person.Gender} Phone Number :{person.PhoneNumber}");

        StudentDetails student=new StudentDetails(person.UserId,person.Name,person.FatherName,person.Gender,person.PhoneNumber,1,"2012");

        Console.WriteLine($"Person ID: {student.UserId}  \nStudents Name: {person.Name}  \nFatherName: {person.FatherName} \nGender: {person.Gender} \nPhone Number :{person.PhoneNumber} \nstudent standar {student.Standard} \nstudent acdamic year {student.YearOfJoining} ");
        
}
}


