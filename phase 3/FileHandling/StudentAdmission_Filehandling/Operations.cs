using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

namespace StudentAdmission11
{
    //static class

    //this beacuse for this nno need of creation of objevt in main program
    public static class Operations
    {
        //local global object creation
        static StudentDetails CurrentLoggedInStudent;
        static string temp="___________________________________";

        public static List<StudentDetails> studentList = new List<StudentDetails>();
        public static List<DepartmentDetails> departmentList = new List<DepartmentDetails>();
        public static List<AdmissionDetails> admissionList = new List<AdmissionDetails>();

        //Menu
        public static void MainMenu()
        {
            Console.WriteLine("**********Welcome*********");
            //need to show the main menu opyion

           

            //need to craete mainmenu structure
            string mainChoice="yes";
            do
            {
                 Console.WriteLine(" Main Menu \n1.Regstritaion \n2.login  \n3.department wise seat availabilty \n4.exist");
            //need to get an input forom user and validate

            Console.WriteLine("select an option: ");
            int mainOption = int.Parse(Console.ReadLine());
                switch (mainOption)
                {
                    case 1:
                        {
                            Console.WriteLine("*********Student Registration***********");

                            StudentRegistration();

                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("*********Student Login*****************");
                            StudentLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("******Department Wirse Seating Availablty*******");
                            DepartmentWiseSeatAvailability();

                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("***Application Exixted Succesfully****");
                            mainChoice="No";
                            break;
                        }
                }

            } while (mainChoice=="yes");
            //need to iterative until the opotion is exit
            }//main menu ending here


            //Student Registration
            public static void StudentRegistration()
            {
                //Need to get required details
                Console.Write("Enter your Name: ");
                string name=Console.ReadLine();
                Console.Write("Enter your fathers Name: ");
                string fathersName=Console.ReadLine();
                Console.Write("Enter your Date of Birth");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                Console.Write("enter your gender: ");
                Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
                Console.Write("Enter your physics marks: ");
                int physicsMark=int.Parse(Console.ReadLine());
                Console.Write("Enter your chemistry marks: ");
                int chemistryMark=int.Parse(Console.ReadLine());
                Console.Write("Enter your maths marks: ");
                int mathsMark=int.Parse(Console.ReadLine());
                //need to create an objecct
                StudentDetails student=new StudentDetails(name,fathersName,dob,gender,physicsMark,chemistryMark,mathsMark);
                //need to add in the list
                studentList.Add(student);

                //need to display confirmation message and Id
                Console.WriteLine($"Student Registration isnsuucesfull .Student ID :{student.StudentID}");

            }//Student Registration ends


            //Student login

            public static void StudentLogin()
            {
                //need to get input userID

                Console.Write("Enter Your styudent ID: ");
                string loginID=Console.ReadLine().ToUpper();
                //valiadate its presence in the list
                bool flag=true;
                foreach(StudentDetails student in studentList)
                {
                    if(loginID.Equals(student.StudentID))
                    {
                        flag=false;
                        //assigning current usr to global variable
                        CurrentLoggedInStudent=student;
                        Console.WriteLine("Logged In Succesfully");
                        //need call submenu
                        Submenu();
                        break;


                    }
                }
                if(flag)
                {
                    Console.WriteLine("Invalid ID or ID is not present ");

                }
                //if not-Invlid ID

            }//Student login ends

            public static void Submenu()
                {
                    string subChoice="yes";
                    do
                    {   Console.WriteLine("***********Sub menu****************");
                    //need to show submenu options
                        Console.WriteLine(" select an option 	\n1.Check Eligibility \n2.Show Details.	\n3.Take Admission.	\n4.Cancel Admission.	\n5.Show Admission Details.	\n6.Exit");                    
                        
                          //getting user option
                          Console.Write("Enter your option: ");
                          int suboption=int.Parse(Console.ReadLine());
                          switch(suboption)
                          {
                            case 1:
                            {
                                Console.WriteLine("************* Check Eligibility**********************");
                                Checkeligibility();
                                break;
                            }
                            case 2:
                            {
                                Console.WriteLine("*************Show Details**********************");
                                Showdetails();

                                break;
                            }

                            case 3:
                            {
                                Console.WriteLine("**************** Take Admission*******************");
                                TakeAdmission();
                                break;
                            }

                            case 4:
                            {
                                Console.WriteLine("****************Cancel Admission *******************");
                                CancelAdmision();
                                break;
                            }
                            case 5:
                            {
                                Console.WriteLine("****************Show Admission Details*******************");
                                ShowAdmissionDetails();
                                break;
                            }
                            case 6:
                            {
                                Console.WriteLine("****************Exit*******************");
                                subChoice="no";
                                break;
                            }
                            


                       }
                        //iterative tilll option is exit

                    }while(subChoice=="yes");

                }//Submenu ends here


                //Checkeligibility
                public static void Checkeligibility()

                {
                    //get the cuttoff value as input
                    Console.Write("Enter the cut off value:   ");
                    double cutoff=double.Parse(Console.ReadLine());
                    //check eligible or not
                    if(CurrentLoggedInStudent.CheckEligiblity(cutoff))
                    {
                            Console.WriteLine("Student is eligible");
                    }
                    else
                    {
                        Console.WriteLine("Student is not eligible");
                    }

                }//Checkeligibility ends

                //show details
                public static void Showdetails()
                {
                    //need to show details of the student
                    Console.WriteLine("|studentID|student name|Fathers name| Date Format brith|gender|phyics|chemistry|maths");
                     Console.WriteLine($"|{CurrentLoggedInStudent.StudentID} | {CurrentLoggedInStudent.StudentName} |{CurrentLoggedInStudent.FatherName} | {CurrentLoggedInStudent.DOB} | {CurrentLoggedInStudent.Gender} | {CurrentLoggedInStudent.PhysicsMark} | {CurrentLoggedInStudent.ChemistryMark}|{CurrentLoggedInStudent.MathsMark}");
                     

                    
                }

                //Take Admissions
                 public static void TakeAdmission()
                {
                    //need to show available departments
                    DepartmentWiseSeatAvailability();
                    //ask theuser Id from user
                    Console.WriteLine("select an department ID");
                    String departmentID=Console.ReadLine();

                    //check the id is present or not
                    bool flag=true;
                    foreach(DepartmentDetails department in departmentList)
                    {
                        if(departmentID.Equals(department.DepartmentID))
                        {
                            flag=false;
                    //check the student is eligible or not

                                if(CurrentLoggedInStudent.CheckEligiblity(75.0))
                                    {
                                        //checked the avialablity
                                         if(department.NumberOfSeats>0)
                                            {
                                            //check the user taken admission already
                                            int count=0;
                                            foreach(AdmissionDetails admission in admissionList)
                                            {
                                                if(CurrentLoggedInStudent.StudentID.Equals(admission.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted))
                                                {
                                                    count++;
                                                }
                                            }
                                            if(count==0)
                                            {
                                                //cretaion admission object
                                                AdmissionDetails admissiontaken=new AdmissionDetails(CurrentLoggedInStudent.StudentID,department.DepartmentID,DateTime.Now,AdmissionStatus.Admitted);

                                                //reducse the seat count
                                                department.NumberOfSeats--;
                                                //add it to the admission list
                                                admissionList.Add(admissiontaken);
                                               //dispaly admission succesfull
                                               Console.WriteLine($"you have taken admission sucessfully.admission ID: {admissiontaken.AdmissionID}");

                                            }
                                            else
                                            {
                                                    Console.WriteLine("you have already took admission");
                                            }
                                        



                                            }
                                            else
                                                {
                                                Console.WriteLine("seats are not available");
                                                }
                                        

                                    }
                                    else
                                    {
                                        Console.WriteLine("yoou are not eligible due to low cutoff");

                                    }
                    

                    break;
                    }
                    }
                    if(flag)
                    {
                        Console.WriteLine("Invalid ID or ID not found");
                    }
                    


                }//Take Admissions ends

                //cancel admision
                public static void CancelAdmision()
                {
                    //check the student is taken any admission and display it
                    bool flag=true;
                    foreach(AdmissionDetails admission in admissionList)
                    {
                        flag=false;
                        if(CurrentLoggedInStudent.StudentID.Equals(admission.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted))
                        {
                            //cancel found admission
                              admission.AdmissionStatus=AdmissionStatus.Cancelled;
                            //return seat to department
                            foreach(DepartmentDetails department in departmentList)
                                {
                                        if(admission.DepartmentID.Equals(department.DepartmentID))
                                        {
                                            department.NumberOfSeats++;
                                            break;
                                        }

                                }
                            break;

                        }
                    }
                    if(flag)
                    {
                        Console.WriteLine("you have no admisson to canceeel");
                    }
                    


                }//canceladmision ends

                //showadmission details
                public static void ShowAdmissionDetails()
                {
                    //need to show admission detail of currrent logged in user;
                    Console.WriteLine("AdmisisonId|StudentID|DepartmentID|Admission date|Admission Status");
                    foreach (AdmissionDetails admissions in admissionList)
                        {
                                if(CurrentLoggedInStudent.StudentID.Equals(admissions.StudentID))
                                {
                                    Console.WriteLine($"{admissions.AdmissionID}|{admissions.StudentID}|{admissions.DepartmentID}|{admissions.AdmissionDate}|{admissions.AdmissionStatus}");
                                }
                        }

                }
                
                ////showadmission details ends
            

            //Department waise Seat Availability

            public static void DepartmentWiseSeatAvailability()
            {

                //need to show all department datails
                Console.WriteLine(temp);
                Console.WriteLine("departmentID |department Name|NumberoFSeats");
                //Console.WriteLine($"|{"departmentID",-12} |department Name|NumberoFSeats");
                Console.WriteLine(temp);
                foreach (DepartmentDetails department in departmentList)
            {
                Console.WriteLine($"{department.DepartmentID,-13}|{department.DepartmentName,-15}|{department.NumberOfSeats,-12}");
                Console.WriteLine(temp);
            }


            }//Department waise Seat Availability ends





        //adding default Data
        public static void AddDefaultData()
        {
            //StudentDetails student1=
            StudentDetails student1 = new StudentDetails("Ravichandran", "Ettapparajan", new DateTime(1999,11,11), Gender.Male, 95, 95, 95); //type one
            StudentDetails student2 = new StudentDetails("Baskaran", "Sethurajan", new DateTime(1999,11,11), Gender.Male, 95, 95, 95);//type two
            studentList.Add(student2);
            //type  3
            studentList.AddRange(new List<StudentDetails> { student1, student2, });





            //  departmentList.Add(new DepartmentDetails("EEE",29));
            //  departmentList.Add(new DepartmentDetails("CSE",29));
            //  departmentList.Add(new DepartmentDetails("MECH",30));
            //  departmentList.Add(new DepartmentDetails("ECE",30));

            //string studentID,string departmentID,DateTime admissionDate,AdmissionStatus admissionStatus

            // admissionList.Add(new AdmissionDetails("SF3001","DID101",new  DateTime(2022/05/11),AdmissionStatus.Admitted));
            //admissionList.Add(new AdmissionDetails("SF3002","DID102",new DateTime(2022/05/12),AdmissionStatus.Admitted));

            DepartmentDetails departmentdetails1 = new DepartmentDetails("EEE", 29);
            DepartmentDetails departmentdetails2 = new DepartmentDetails("CSE", 29);
            DepartmentDetails departmentdetails3 = new DepartmentDetails("MECH", 30);
            DepartmentDetails departmentdetails4 = new DepartmentDetails("ECE", 30);

            departmentList.AddRange(new List<DepartmentDetails> { departmentdetails1, departmentdetails2, departmentdetails3, departmentdetails4 });



            AdmissionDetails admission1 = new AdmissionDetails("SF3001", "DID101", new DateTime(2022,05,11), AdmissionStatus.Admitted);
            AdmissionDetails admission2 = new AdmissionDetails("SF3002", "DID102", new DateTime(2022,05,12), AdmissionStatus.Admitted);
            admissionList.AddRange(new List<AdmissionDetails> { admission1, admission2 });


            foreach (StudentDetails student in studentList)
            {
                Console.WriteLine($"|{student.StudentID} | {student.StudentName} |{student.FatherName} | {student.DOB.ToString("dd/MM/yyyy")} | {student.Gender} | {student.PhysicsMark} | {student.ChemistryMark}|{student.MathsMark}");
            }

            foreach (DepartmentDetails department in departmentList)
            {
                Console.WriteLine($"{department.DepartmentID}|{department.DepartmentName}|{department.NumberOfSeats}");
            }

            foreach (AdmissionDetails admissions in admissionList)
            {
                Console.WriteLine($"{admissions.AdmissionID}|{admissions.StudentID}|{admissions.DepartmentID}|{admissions.AdmissionDate.ToString("dd/MM/yyyy")}|{admissions.AdmissionStatus}");
            }



        }



    }
}