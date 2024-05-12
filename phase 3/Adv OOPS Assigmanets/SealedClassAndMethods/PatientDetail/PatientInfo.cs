using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientDetail
{
    public sealed class PatientInfo
    {
         // Properties: PatientID, Name, FatherName, BedNo, NativePlace, AdmittedFor
        private static int s_patientID=100;
         public String PatientID { get; set; }
         public string  Name { get; set; }

         public string FatherName { get; set; }
        public int BedNo { get; set; }
        public string NativePlace { get; set; }
        public string AdmittedFor { get; set; }

        public void DisplayInfo(string name,string fathername,int bedno,string nativeplace,string admittedfor)
        {
            s_patientID++;
            PatientID="PID"+s_patientID;
            Name=name;
            FatherName=fathername;
            BedNo=bedno;
            NativePlace=nativeplace;
            AdmittedFor=admittedfor;
 

 

            Console.WriteLine($"PatientID:{PatientID}name :{Name} fathername: {FatherName}BedNo: {BedNo} NativePlace: {NativePlace} AdmittedFor:{AdmittedFor}");


        }
    }
}