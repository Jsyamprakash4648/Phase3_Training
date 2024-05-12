using System;
using StudentInformaton;

namespace StudentInformation;

class Program 
{
    public static void Main(string[] args)
    {

        HSCDetails person1=new HSCDetails("syam","Jayaprakash",new DateTime(2000/12/25),"7410852963",Gender.Male,"12345@@220",5,"EEE",2024,963,95,45,25);
            person1.ShowInfo();
            person1.ShowMarkSheet();
            person1.Calculate();

        HSCDetails person2=new HSCDetails("syamhhhhhh","Jayadsdsaprakasggh",new DateTime(2000/12/25),"7410852963",Gender.Male,"12345@@220",5,"EEE",2024,963,55,35,45);
            person2.ShowInfo();
            person2.Calculate(); 
            person2.ShowMarkSheet();
    }
}


// Program for getting and showing student details: based on menu Create 2 student details Calculate Total, percentage, show marksheet and need to show if he wants.
// Class PersonalInfo:
// Properties: Name, FatherName,Phone,Mail, dob,Gender/
// Constructor to assign values
// Class StudentInfo: inherits PersonalInfo
// Propeties: RegisterNumber, Standard, Branch, AcadamicYear
// Method: GetStudentInfo, ShowInfo
// Class HSCDetails: Inherits StudentInfo
// Properties: HSCMarksheetNumber, Physics, Chemistry, Maths, Total, Percentage marks
// Methods: GetMarks, Calculate – Total and percentage, Show Marksheet.