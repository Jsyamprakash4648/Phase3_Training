using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientDetail
{
    public class DoctorInfo:PatientInfo
    {
        // Properties: DoctorID, Name, FatherName
        private static int s_doctorID=200;
        public String DoctorID{ get; set; }
        public string  Name { get; set; }
        public string  FatherName { get; set; }

        public void DisplayInfo(string name,string fathername)
        {
            s_doctorID++;
            DoctorID="DID"+s_doctorID;
            Name=name;
            FatherName=fathername;

            Console.WriteLine($" DoctorID: {DoctorID} Name:{Name} FatherName{FatherName}");


        }
    }
}