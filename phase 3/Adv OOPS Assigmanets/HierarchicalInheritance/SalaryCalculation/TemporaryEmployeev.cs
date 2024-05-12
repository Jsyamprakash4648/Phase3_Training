using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class TemporaryEmployee :SalaryInfo
    {

        private static int s_employeeID=1000;
        public string EmployeeID { get; set; }

        public String  EmployeeType { get; set; }

        public double DA { get; set; }=0.15;
        public double HRA { get; set; }=0.13;
        public double PF { get; set; } = 0.1;

        public double TotalSalary { get; set; }

        public TemporaryEmployee(double baisc,int month,string employeeID,string employeeType) :base( baisc, month)
        {  s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            EmployeeID=employeeID;
            EmployeeType=employeeType;



        }

        public void CalculateTotalSalary()
        {
            TotalSalary=(BasicSalary*(DA+HRA+PF))*Month;

        }

        public void ShowSalary()
        {
            Console.WriteLine("Salary: "+TotalSalary);
            
        }



    }
}