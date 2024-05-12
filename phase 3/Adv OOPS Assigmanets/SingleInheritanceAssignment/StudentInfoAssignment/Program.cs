using System;

namespace StudentInfoAssignment;

class Program 
{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("syam","jayaprakash","1234567890","mail@id",new DateTime(02/02/2000),Gender.Male,"2","eee",2012);

        Console.WriteLine($"Person ID: {person.RegisterNumber}  \nStudents Name: {person.Name}  \nFatherName: {person.FatherName} \nGender: {person.Gender} \nPhone Number :{person.Phone} \nMail :{person.Mail} \nStandard : {person.Standard} \nBranch: {person.Branch} \nAcadamic year :{person.AcadamicYear}");
    }
}
