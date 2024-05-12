using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybridinheritance11
{
    public class Marksheet:TheoryExamMarks,ICalculate
    {

        //Properties: MarksheetNumber, DateOfIssue, Total, Percentage

        public string  MyMarksheetNumber { get; set; }

        public DateTime DateOfIssue { get; set; }
        public int Total { get; set; }

        public double Percentage { get; set; }
        public int ProjectMark { get; set; }

        public void CalculateUG ()
        {
            Total=Sem1.Sum()+Sem2.Sum()+Sem3.Sum()+Sem4.Sum()+ProjectMark;
            Percentage=(Total/2400.0)*100;

        }


        public void ShowUgMarkSheet()
        {
            Console.Write($"Registration Number: {RegistationNumber} \nname {Name}  \nfathername {FatherName} \nphone {Mobile} \ngender {Gender} \nDOB {DOB.ToString("dd/MM/yyy")} \nTotal marks: {Total}  \nPercentage: {Percentage} \nDate of issue {DateOfIssue.ToString("dd/MM/yyy")}");
        }
        
    }
}