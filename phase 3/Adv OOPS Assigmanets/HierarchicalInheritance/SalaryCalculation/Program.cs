using System;
using SalaryCalculation;
namespace SalaryCalculaton;

class Program 
{
    public static void Main(string[] args)
    {
// Create a employee Salary calculation method.  Create two temporary and two permanent employees, calculate their salary and show their salary.
// Class SalaryInfo
// Properties: BasicSalary, Month
// Class PermanentEmployee: inherit SalaryInfo
// Properties: EmployeeID, Employee Type, DA=0.2% of basic, HRA= 0.18% of basic, PF – 0.1 % basic, Total Salary
// Method: Calculate TotalSalary – Basic +DA+HRA-PF, ShowSalary
// Class TemporaryEmployee: inherit SalaryInfo
// Properties: EmployeeID, Employee Type, DA=0.15% of basic, HRA= 0.13% of basic, Total Salary
// Method: Calculate TotalSalary – Basic +DA+HRA-PF, ShowSalary     

        PermanantEmployee employee1=new PermanantEmployee(80000,12,"EID101","PermanantEmployee");

        TemporaryEmployee employee2=new TemporaryEmployee(10000,12,"EID102","TemporaryEmployee");

        employee1.CalculateTotalSalary();
        employee1.ShowSalary();

        employee2.CalculateTotalSalary();
        employee2.ShowSalary();

    }
}
