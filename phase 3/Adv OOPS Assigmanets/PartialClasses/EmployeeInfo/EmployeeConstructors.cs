using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public partial  class EmployeeInfo
    {
        public EmployeeInfo(string name,Gender gender,DateTime dob,long phoneNumber )
        {
            s_employeeID++;
            EmployeeID="EMPID"+s_employeeID;

            Name=name;
            Gender=gender;
            Dob=dob;
            PhoneNumber=phoneNumber;
            
        }
        
    }
}