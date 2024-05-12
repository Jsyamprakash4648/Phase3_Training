using System;

using System.IO;
using StudentAdmission11;


namespace StudentAdmission_Filehandling
{
    public static class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("CollegeAdmission"))
            {
                Console.WriteLine("creating folder");
                Directory.CreateDirectory("CollegeAdmission");
            }
            //filr for student info
            if(!File.Exists("CollegeAdmission/StudentInfo.csv"))
            {
                 Console.WriteLine("creating File");
                File.Create("CollegeAdmission/StudentInfo.csv").Close();

            }


            //file for  department info
            if(!File.Exists("CollegeAdmission/DepartmentInfo.csv"))
            {
                Console.WriteLine("creating File");
               File.Create("CollegeAdmission/DepartmentInfo.csv").Close();


            }

            //file for Admission
            if(!File.Exists("CollegeAdmission/AdmissionInfo.csv"))
            {
                 Console.WriteLine("creating File");
                File.Create("CollegeAdmission/AdmissionInfo.csv").Close();

            }

        }

        public static void WriteToCsv()
        {
            string [] students=new string[Operations.studentList.Count];
            for (int i=0;i<Operations.studentList.Count;i++)
            {
                students[i]=Operations.studentList[i].StudentID+","+Operations.studentList[i].StudentName+","+Operations.studentList[i].FatherName+","+Operations.studentList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.studentList[i].Gender+","+Operations.studentList[i].PhysicsMark+","+Operations.studentList[i].ChemistryMark+","+Operations.studentList[i].MathsMark;
            }
            File.WriteAllLines("CollegeAdmission/StudentInfo.csv",students);
       
       
             string[] departments=new string[Operations.departmentList.Count];
             for (int i=0;i<Operations.departmentList.Count;i++)
            { 

            departments[i]=Operations.departmentList[i].DepartmentID+","+ Operations.departmentList[i].DepartmentName+","+Operations.departmentList[i].NumberOfSeats; 
            }

            File.WriteAllLines("CollegeAdmission/DepartmentInfo.csv",departments);



            string[] admissions=new string[Operations.admissionList.Count];
             for (int i=0;i<Operations.admissionList.Count;i++)
            { 
                admissions[i]=Operations.admissionList[i].AdmissionID+","+Operations.admissionList[i].StudentID+","+Operations.admissionList[i].DepartmentID+","+Operations.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Operations.admissionList[i].AdmissionStatus;
            }
            File.WriteAllLines("CollegeAdmission/AdmissionInfo.csv",admissions);
        }


        public static void ReadFromCsv()
        {
            string [] students=File.ReadAllLines("CollegeAdmission/StudentInfo.csv");
            foreach(string student1 in students)
            {
                StudentDetails studenttt=new StudentDetails(student1);
                Operations.studentList.Add(studenttt);


            }


            string[] departemt=File.ReadAllLines("CollegeAdmission/DepartmentInfo.csv");

            foreach(string depart in departemt)
            {
                DepartmentDetails department1=new DepartmentDetails(depart);
                Operations.departmentList.Add(department1);

            }


            string[] admission=File.ReadAllLines("CollegeAdmission/AdmissionInfo.csv");

            foreach(string admisson1 in admission)
            {
                AdmissionDetails admission2=new AdmissionDetails(admisson1);
                Operations.admissionList.Add(admission2);

            }
        }

       
        
    }
}