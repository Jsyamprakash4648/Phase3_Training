using System;
namespace  interface22;

class Program 
{
    public static void Main(string[] args)
    {

        StudentInfo student=new StudentInfo("sit","syam","jayaprakash","7410963852");
         EmployeeInfo employeeInfo=new EmployeeInfo("sit","syam","jayaprakash");
         student.Dispay();
         employeeInfo.Dispay();
        
    }
}


// Create application for student application
// Interface IDisplayInfo
// Methods: Dispay
// Class StudentInfo inherit IDisplayInfo
// Properties: StudentID, Name, FatherName, Mobile
// Methods: Display
// Class EmployeeInfo inherit IDisplayInfo
// Properties: EmployeeID, Name, FatherName
// Methods: Display
// Create one object each for student and employee info and display their properties.