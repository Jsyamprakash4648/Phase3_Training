using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo
{
    public partial  class StudentInfo
    {
//Methods -> Calculate total and percentage, and Display  
    public void Calculatetotal()
    {
        Console.WriteLine("TotalMarks: "+(Physics+Chemistry+Maths));

    }

    public void percentage()
    {
        double percentage=((Physics+Chemistry+Maths)*100)/300;
        Console.WriteLine(" percentage: "+percentage);

    }
//StudentID,Name,Gender,DOB, Mobile, Physics, Chemistry, Maths Marks
    public void Display()
    {
        Console.WriteLine($"Student ID{StudentId}  \nStudent Name: {Name}  \nGender{Gender} \nDOB: {Dob.ToString("dd/MM/yyyy")} \nMobile: {PhoneNumber} \nPhysics: {Physics} \nChemistry: {Chemistry} \nMaths:{Maths}");
    }




    }
}