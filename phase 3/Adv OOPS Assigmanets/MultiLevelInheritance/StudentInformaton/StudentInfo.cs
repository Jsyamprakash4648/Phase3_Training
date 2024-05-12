using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformaton
{
    public class StudentInfo:PersonalInfo
    {
        // Class StudentInfo: inherits PersonalInfo
        // Propeties: RegisterNumber, Standard, Branch, AcadamicYear
        // Method: GetStudentInfo, ShowInfo

        private static int s_registerNumber=1000;

        public string RegisterNumber { get; set; }

        public int Standard { get; set; }
        public string  Branch { get; set; }

        public int AcadamicYear { get; set; }

         public StudentInfo(string name,string fathername,DateTime dob ,string phone,Gender gender,string mail,int standard,string branch,int acadamicYear):base( name, fathername, phone, mail, dob, gender)
        {
            s_registerNumber++;
            RegisterNumber="RID"+s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }

          public void ShowInfo()
        {
            Console.WriteLine($"RegisterNumber: {RegisterNumber} \nStandard: {Standard} \nBranch: {Branch} AcadamicYear {AcadamicYear}" );
        }
    





    }
}