using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public partial  class EmployeeInfo
    {

        public void  update(string employeeid,string name,Gender gender,DateTime dob,long number)
        {
            EmployeeID=employeeid;
            Name=name;
            Gender=gender;
            Dob=dob;
            PhoneNumber=number;

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Employee ID {EmployeeID} \nEmployee Name: {Name} \nGender :{Gender} \nDateOf Birth: {Dob.ToString("dd/MM/yyyy")}\nPhoneNUmber: {PhoneNumber}");
        }
        
    }
}