using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class SalaryInfo
    {
        //BasicSalary, Month

        public double BasicSalary { get; set; }

        public int Month { get; set; }

        public SalaryInfo(double baisc,int month)
        {
            BasicSalary=baisc;
            Month=month;
        }

        
    }
}