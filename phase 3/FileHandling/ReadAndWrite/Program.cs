using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace ReadAndWrite;

class Program 
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            Console.WriteLine("creating folder...");
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            Console.WriteLine("Directory exist..");
        }

        //csv file
        if(!File.Exists("TestFolder/Data.csv"))
        {
            Console.WriteLine("creating CSV file...");
            File.Create("TestFolder/Data.csv");

        }
        else
        {
             Console.WriteLine("CSV file already exist..");
        }

        //JSOn file
         if(!File.Exists("TestFolder/Data1.Json"))
        {
            Console.WriteLine("creating Json file...");
            File.Create("TestFolder/Data1.Json");

        }
        else
        {
             Console.WriteLine(" Json file already exist..");
        }



        List<Student> studentList=new List<Student>();
        studentList.Add(new Student(){Name="syam",FatherName="jayaprakash",StudentGender=Gender.Male,Dob=new DateTime(2000,08,28),TotalMarks=400});
         studentList.Add(new Student(){Name="satya",FatherName="jayaprakash",StudentGender=Gender.Male,Dob=new DateTime(2001,08,05),TotalMarks=450});
          studentList.Add(new Student(){Name="prakash",FatherName="sundhar",StudentGender=Gender.Male,Dob=new DateTime(2000,04,14),TotalMarks=400});
            WriteToCsv(studentList);
            ReadCSV();


    }

    static void WriteToCsv(List<Student> studentList)
    {
        StreamWriter sw=new StreamWriter("TestFolder/Data.csv");
        foreach(Student student in studentList)
        {   string line=student.Name+","+student.FatherName+","+student.StudentGender+","+student.Dob.ToString("dd/MM/yyyy")+","+student.TotalMarks;

            sw.WriteLine(line);
        }
        sw.Close();


    }

    static void ReadCSV()
    {
        List<Student> newList=new List<Student>();
        StreamReader sr=new StreamReader("TestFolder/data.csv");
        String line =sr.ReadLine();
        while(line!=null)
        {
            string [] values=line.Split(",");
            if(values[0]!="")
            {
                Student student=new Student()
                {
                    Name=values[0],
                    FatherName=values[1],
                    StudentGender=Enum.Parse<Gender>(values[2]),
                    Dob=DateTime.ParseExact(values[3],"dd/MM/yyyy",null),
                    TotalMarks=int.Parse(values[4])

                    
                };
                newList.Add(student);
            }
            line=sr.ReadLine();
        }

        sr.Close();
        foreach(Student student in newList)
        {
            Console.WriteLine($"Name {student.Name}  fathername: {student.FatherName}  gender: {student.StudentGender}  DOB: {student.Dob.ToString("dd/MM/yyyy")}  Total marks {student.TotalMarks}");

        }
    }
}
