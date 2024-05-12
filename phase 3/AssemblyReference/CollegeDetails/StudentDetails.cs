using System;

namespace CollegeDetails
{
    public enum Gender{Select,Male,Female}
    public class StudentDetails
    {
/*a.   StudentName
b.	FatherName
c.	DOB
d.	Gender – Enum (Select, Male, Female, Transgender)
e.	Physics
f.	Chemistry
g.	Maths*/

    //feild  
    //static
    //properties
    private static int s_studentID=3000;
    public string StudentID { get; }//readonly

    public string  StudentName { get; set; }

    public string  FatherName { get; set; }
    public DateTime DOB { get; set; }
    public Gender Gender { get; set; }

    public int PhysicsMark { get; set; }
    public int ChemistryMark { get; set; }
    public int MathsMark { get; set; }

    //property spaner symbol
    //box=element
    //double box =parameter
    
    //Constructor 
    public StudentDetails(string studentName,string fathersName,DateTime dob,Gender gender,int physicsmark,int chemistryMarks,int mathsMarks)
    {
        //Auto incremention
        s_studentID++;
        StudentID="SF"+s_studentID;
        StudentName=studentName;
        FatherName=fathersName;
        DOB=dob;
        Gender=gender;
        PhysicsMark=physicsmark;
        ChemistryMark=chemistryMarks;
        MathsMark=mathsMarks;


    }

    //method
    public double Average()
    {
        int total=PhysicsMark+ChemistryMark+MathsMark;
        double average=(double)total/3;
        return  average;
    }

    public bool CheckEligiblity(double cutoff)
    {
        if(Average() >=cutoff)
        {
            return true;

        }
        
            return false;
        
    }


        
    }
}