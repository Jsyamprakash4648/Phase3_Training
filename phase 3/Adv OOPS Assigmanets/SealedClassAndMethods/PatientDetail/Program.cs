using System;

namespace PatientDetail;

class Program 
{
    public static void Main(string[] args)
    {
//Create an application for patient detail manipulation
 // Sealed Class PatientInfo:
 // Properties: PatientID, Name, FatherName, BedNo, NativePlace, AdmittedFor
// Method: DisplayInfo
// Class DoctorInfo: Inherit PatientInfo
// Properties: DoctorID, Name, FatherName
// Methods: DisplayInfo
// Create a patient object and display his info
// Create a doctor object and display info

        PatientInfo patient1=new PatientInfo();
        patient1.DisplayInfo("kumar","sukumar",2,"Parries","cold");

        DoctorInfo doctor1=new DoctorInfo();
        doctor1.DisplayInfo("gayathree","sankar");

        


    
}
}