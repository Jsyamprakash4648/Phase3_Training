using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo
{
    public partial class StudentInfo
    {
//Name,Gender,DOB, Mobile, Physics, Chemistry, Maths Marks
        public StudentInfo(string name,Gender gender,DateTime dob,string phoneNumber,int physics,int chemistry,int maths)
        {
            s_studentID++;
            StudentId="SID"+s_studentID;
            Name=name;
            Gender=gender;
            Dob=dob;
            PhoneNumber=phoneNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        
    }
}