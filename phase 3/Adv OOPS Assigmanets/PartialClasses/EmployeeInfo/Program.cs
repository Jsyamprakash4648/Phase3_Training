using System;

namespace EmployeeInfo;

class Program 
{
    public static void Main(string[] args)
    {

// Create an application for employee info

// Create a class file named EmployeeProps
// Inside that create a partial class EmployeeInfo and provide properties -  EmployeeID,Name,Gender,DOB, Mobile
// Create another class file named EmployeeConstructors
// Inside that create a partial class EmployeeInfo and provide Constructor
// Create another class file named EmployeeMethods
// Inside that create a partial class EmployeeInfo and provide Methods -> Update, Display


// Create one employee object for employee info and use update and display info methods      
//   



//EmployeeInfo employee=new EmployeeInfo("syam",Gender.Male,new DateTime(02/02/2000),9638527410);
EmployeeInfo employee=new EmployeeInfo("syam",Gender.Male,new DateTime(2000,12,22),9638527410);

employee.update(employee.EmployeeID,"satya",Gender.Male,new DateTime(2000,11,28),1234567890);
employee.DisplayInfo();


    }
}

