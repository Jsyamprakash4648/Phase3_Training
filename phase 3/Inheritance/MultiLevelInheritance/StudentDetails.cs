using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance;

    public class StudentDetails : PersonalDetails
{
    private static int s_studentID = 2000;

    public string StudentID { get; }
    public int Standard { get; set; }

    public string YearOfJoining { get; set; }

    public StudentDetails(string userID, string name, string fathername, Gender gender, string phoneNumber, int standard, string yearOfJoining) : base(userID, name, fathername, gender, phoneNumber)
    {
        s_studentID++;

        StudentID = "SID" + s_studentID;

        Standard = standard;
        YearOfJoining = yearOfJoining;


    }

    public StudentDetails(string studentID, string userID, string name, string fathername, Gender gender, string phoneNumber, int standard, string yearOfJoining) : base(userID, name, fathername, gender, phoneNumber)
    {


        StudentID = studentID;

        Standard = standard;
        YearOfJoining = yearOfJoining;


    }
}
