using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfoAssignment
{
    public class PersonalInfo :StudentInfo
    {
//  Propeties: RegisterNumber, Standard, Branch, AcadamicYear 

private static int s_registerNumber=1000;

    public string RegisterNumber { get; set; }
    public string Standard { get; set; }
    public string  Branch{ get; set; }

    public int AcadamicYear { get; set; }

    public  PersonalInfo(string name,string fathername,string phone,string mail,DateTime dob,Gender gender,string standard,string branch,int acadamicYear) :base( name, fathername, phone, mail, dob, gender)
    {
        s_registerNumber++;
        RegisterNumber="RID"+s_registerNumber;
        // RegisterNumber=registerNumber;
        Standard=standard;
        Branch=branch;
        AcadamicYear=acadamicYear;

    }


    

    }
}