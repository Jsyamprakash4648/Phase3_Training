using System;

namespace CollegeDetails
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

    }
}