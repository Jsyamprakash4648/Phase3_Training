using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission11
{
    public class DepartmentDetails
    {
        
        /*a.	DepartmentID – (AutoIncrement - DID101)
b.	DepartmentName
c.	NumberOfSeats */

private static int  s_DepartmentID=100;

public string DepartmentID { get; set; }
public string  DepartmentName { get; set; }
public int   NumberOfSeats { get; set; }

//constructor
public DepartmentDetails(string departmentName,int  numberOfSeats)
{
    s_DepartmentID++;
    DepartmentID="DID"+s_DepartmentID;
    DepartmentName=departmentName;
    NumberOfSeats=numberOfSeats;

}

public DepartmentDetails(string department)

{
    string[] values=department.Split(",");
    
    DepartmentID=values[0];
    s_DepartmentID=int.Parse(values[0].Remove(0,3));
    DepartmentName=values[1];
    NumberOfSeats=int.Parse(values[2]);

}



    }
}