using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    public enum Gender{select,Male,Female,Transgender}
    public class Student
    {
        public string Name { get; set; }
        public string  FatherName { get; set; }
        public Gender StudentGender { get; set; }
        public DateTime Dob { get; set; }
        public int TotalMarks { get; set; }
        
    }
}