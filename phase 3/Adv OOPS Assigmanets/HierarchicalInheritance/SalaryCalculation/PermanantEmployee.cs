using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class PermanantEmployee :SalaryInfo
    {
        // public string EmployeeID { get; set; }

        // public string Employee Type { get; set; }

        // public double DA { get; set; } = 0.2;
        // public double HRA { get; set; } = 0.18;

        // public double PF { get; set; } = 0.1;
        // public double TotalSalary { get; set; }
        private static int s_employeeID=1000;
        public string EmployeeID { get; set; }

       public string  EmployeeType { get; set; }

       public double DA { get; set; }=0.2;

       public double HRA { get; set; }=0.18;

       public double PF { get; set; }=0.1;

       public double TotalSalary { get; set; }

       public PermanantEmployee(double baisc,int month,string employeeID,string employeeType) :base ( baisc, month)
       {
        s_employeeID++;
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