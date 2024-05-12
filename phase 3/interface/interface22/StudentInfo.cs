using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface22
{
    public class StudentInfo:IDisplayInfo
    {
        //// Properties: StudentID, Name, FatherName, Mobile
        ///
        /// 
            public string Name { get; private set; }
            public string StudentID { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }

        public StudentInfo(string studentID,string name,string fatherName,string mobile)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            StudentID=studentID;


        }

        public void  Dispay()
        {
            Console.WriteLine($"stuent ID {StudentID} name :{Name}  fathername: {FatherName}  moboile: {Mobile}");


        }

        
        
    }
}