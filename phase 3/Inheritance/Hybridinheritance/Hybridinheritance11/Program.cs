using System;
using Hybridinheritance11;

namespace Hybridinheritance;

class Program 
{
    public static void Main(string[] args)
    {
        Marksheet marksheet=new Marksheet();
        marksheet.Name="syam";
        marksheet.FatherName="jayaparakash";
        marksheet.Gender=Gender.Male;
        marksheet.Mobile="7410852963";
        marksheet.DOB=DateTime.Now;
        marksheet.Sem1=new int[]{85,74,96,69,58,47};
        marksheet.Sem2=new int[]{65,74,56,69,58,47};
        marksheet.Sem3=new int[]{45,64,26,79,58,47};
        marksheet.Sem4=new int[]{95,64,96,69,48,47};
        marksheet.ProjectMark=94;
        marksheet.DateOfIssue=DateTime.Today;
        marksheet.MyMarksheetNumber="1234";
        marksheet.CalculateUG();
        marksheet.ShowUgMarkSheet();
    }
}