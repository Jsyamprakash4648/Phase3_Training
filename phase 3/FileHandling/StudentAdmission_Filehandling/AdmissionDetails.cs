using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdmission11
{
    public enum AdmissionStatus{Select, Admitted, Cancelled} 
    public class AdmissionDetails
    {

        
//         a.	AdmissionID – (Auto Increment ID - AID1001)
// b.	StudentID
// c.	DepartmentID
// d.	AdmissionDate
// e.	AdmissionStatus – Enum- (Select, Admitted, Cancelled)

        //feild

private static int s_AdmissionID=1000;
public string AdmissionID { get;  }
public string   StudentID { get; set; }
public string  DepartmentID { get; set; }
public DateTime AdmissionDate { get; set; }
public AdmissionStatus AdmissionStatus { get; set; }


//constructor

public AdmissionDetails(string studentID,string departmentID,DateTime admissionDate,AdmissionStatus admissionStatus )
{

    s_AdmissionID++;
    AdmissionID="AID"+s_AdmissionID;
    StudentID=studentID;
    DepartmentID=departmentID;;
    AdmissionDate=admissionDate;
    AdmissionStatus=admissionStatus;


}




public AdmissionDetails(string admissionn )
{
    string[] values =admissionn.Split(",");
    
    AdmissionID=values[0];
    s_AdmissionID=int.Parse(values[0].Remove(0,3));
    StudentID=values[1];
    DepartmentID=values[2];;
    AdmissionDate=DateTime.ParseExact((values[3]),"dd/MM/yyyy",null);
    AdmissionStatus=Enum.Parse<AdmissionStatus>(values[4]);


}

    }
}