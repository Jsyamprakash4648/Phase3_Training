using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace interface22
{
    public class EmployeeInfo 
    {
        //
        //Properties: , Name, FatherName

        //Methods: DisplayEmployeeID
        public string EmployeeID { get; set; }

         public string Name { get; set; }
        public string FatherName { get; set; }

        public  EmployeeInfo(string employeeID,string name,string fatherName)
        {
            EmployeeID=EmployeeID;
            Name=name;
            FatherName=fatherName;



        }

         public void  Dispay()
         {

              Console.WriteLine($"stuent ID {EmployeeID} name :{Name}  fathername: {FatherName}  ");

         }

    

  }
}