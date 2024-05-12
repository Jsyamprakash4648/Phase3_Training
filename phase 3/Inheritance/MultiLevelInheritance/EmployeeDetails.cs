using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class EmployeeDetails:PersonalDetails
    {
        private static int s_employeeID=1000;

        public string EmployeeID { get; set; }
        public string  Designaton { get; set; }

        public EmployeeDetails(string userID, string name, string fathername, Gender gender, string phoneNumber, string designaton):base( userID,  name,  fathername,  gender,  phoneNumber)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Designaton=designaton;
        }
    }
}