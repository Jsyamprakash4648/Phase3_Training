using System;

namespace EmployeeInfo;

class Program 

{
    public static void Main(string[] args)
    {

        EmployeeInfo empoyee1=new EmployeeInfo();
        PersonalInfo person1=new PersonalInfo();
        person1.UpDateInfo("syaaam","jayaprakash","1234567890","@qwerty@sdf",Gender.Male);
        empoyee1.UpdateInfo(":asdf","dfgh");
        


        
    }
}
// Create an application for a employee registration application.
// Class  PersonalInfo:
// Properties: Name, FatherName, Mobile, Mail, Gender
// Method: UpdateInfo
// Sealed Class EmployeeInfo:
// Properties: UserID, Password, KeyInfo = 100
// Methods: UpdateInfo, DisplayInfo
// Class Hack Inherit EmployeeInfo
// Properties: StoreUserID, StorePassword
// Method: ShowKeyInfo, GetUserInfo, ShowUserInfo
// Create object for employeeInfo and assign values to properties display value.
// Try to Create an object for Hack class. To Show the Key info