using System;

namespace StudentInfo;

class Program 
{public static void Main(string[] args)
{
// Create an application for student info

// Create a class file named StudentProps
// Inside that create a partial class Studentinfo and provide properties -  StudentID,Name,Gender,DOB, Mobile, Physics, Chemistry, Maths Marks
// Create another class file named StudentConstructors
// Inside that create a partial class Studentinfo and provide Constructor
// Create another class file named StudentMethods
// Inside that create a partial class Studentinfo and provide Methods -> Calculate total and percentage, and Display



StudentInfo student1=new StudentInfo("syam",Gender.Male,new DateTime(2000,08,22),"9638527410",85,85,85);

student1.Calculatetotal();
student1.Display();
student1.percentage();


}

}