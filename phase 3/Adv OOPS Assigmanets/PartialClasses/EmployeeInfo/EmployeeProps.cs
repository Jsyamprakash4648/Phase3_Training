using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public enum Gender{Select,Male,Female,Transgender}
    
    public partial class EmployeeInfo
    {
        //EmployeeID,Name,Gender,DOB, Mobile
        private static int s_employeeID=1000;

        public string  EmployeeID { get; set; }
        public string  Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Dob { get; set; }
        public long PhoneNumber { get; set; }


        
    }
}