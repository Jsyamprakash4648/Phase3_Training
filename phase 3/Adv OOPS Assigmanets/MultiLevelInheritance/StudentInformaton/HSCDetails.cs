using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace StudentInformaton
{
    public class HSCDetails:StudentInfo
    {
// Class HSCDetails: Inherits StudentInfo
// Properties: HSCMarksheetNumber, Physics, Chemistry, Maths, Total, Percentage marks
// Methods: GetMarks, Calculate – Total and percentage, Show Marksheet.
        public int HSCMarksheetNumber{ get; set; }
        public int Physics{ get; set; }
        public int Chemistry{ get; set; }
        public int Maths{ get; set; }
        public int Total{ get; set; }

        public double Percentagemarks { get; set; }

        public HSCDetails(string name,string fathername,DateTime dob ,string phone,Gender gender,string mail,int standard,string branch,int acadamicYear,int hSCMarksheetNumber,int physics,int chemistry,int maths) :base( name, fathername, dob , phone, gender, mail, standard, branch, acadamicYear)
        {

            HSCMarksheetNumber=hSCMarksheetNumber;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;

        }

        public void Calculate()
        {
            Total=Physics+Chemistry+Maths;

            Percentagemarks=(Total/300)*100;

        }
    
        public void ShowMarkSheet()
        {
            Console.WriteLine($"Physics: {Physics}  Chemistry: {Chemistry} Maths: {Maths} Tatal :{Total}  Percantage:{Percentagemarks} ");
        }




    }
}